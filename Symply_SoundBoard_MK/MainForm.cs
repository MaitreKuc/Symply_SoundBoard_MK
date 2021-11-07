using System;
using System.Collections.Generic;
using System.Media;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;
using Symply_SoundBoard_MK.Naudio;
using Symply_SoundBoard_MK.SQL;


namespace Symply_SoundBoard_MK
{
    public partial class MainForm : Form
    {
        GenerateTableLayout Build = new GenerateTableLayout();
        SQLClass sql = new SQLClass();

        AudioParam DeviceVC = new AudioParam();
        AudioParam DevicePlayBack = new AudioParam();
        WaveIn loopbackSourceStream = null;
        BufferedWaveProvider loopbackWaveProvider = null;
        WaveOut loopbackWaveOut = null;
        
        

        private bool volumeChangedBySlider = false;
        private bool volumeChangedByField = false;
        

        private int SelectedPlaybackDevice1
        {
            get
            {
                if (ComboVC.Items.Count > 0)
                {
                    return ComboVC.SelectedIndex;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value >= 0 && value <= ComboVC.Items.Count - 1)
                {
                    ComboVC.SelectedIndex = value;
                }
            }
        }

        private int SelectedPlaybackDevice2
        {
            get
            {
                if (ComboPb.Items.Count > 0)
                {
                    //minus one to account for null entry
                    return ComboPb.SelectedIndex - 1;
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                if (value >= -1 && value <= ComboPb.Items.Count - 2)
                {
                    ComboPb.SelectedIndex = value + 1;
                }
            }
        }


        public MainForm()
        {
            int lang = sql.LastLang();
            switch (lang)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    break;
            }
            
            InitializeComponent();
            this.Icon = Properties.Resources.ico;
                sql.ReadListProfil(ComboProfile);
                sql.ReadLastProfil(ComboProfile, LabelidProfile);
                Build.idprofile = Convert.ToInt32(LabelidProfile.Text);
                sql.ReadSQL(TableLayout, LabelRow, LabelCol, LabelidProfile, this, Build);

                DisableCheckboxChangeEvents();
                DisableSoundVolumeChangeEvents();

                loadSoundDevices(false);

                EnableCheckboxChangeEvents();
                EnableSoundVolumeChangeEvents();
                EnableDeviceChangeEvents();

                initAudioPlaybackEngine1();
                initAudioPlaybackEngine2();
                restartLoopback();
                Build.sound = vsSoundVolume.Volume;
        }

        //-----------------BUTTON----------------------------------------
        private void RemoveCol_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(LabelCol.Text) - 1) != 0)
            {
                LabelCol.Text = (Convert.ToInt32(LabelCol.Text) - 1).ToString();
            }
            Build.Generate(Convert.ToInt32(LabelCol.Text), Convert.ToInt32(LabelRow.Text), TableLayout,this);
        }

        private void AddCol_Click(object sender, EventArgs e)
        {
            LabelCol.Text = (Convert.ToInt32(LabelCol.Text) + 1).ToString();
            Build.Generate(Convert.ToInt32(LabelCol.Text), Convert.ToInt32(LabelRow.Text), TableLayout,this);
        }

        private void RemoveRow_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(LabelRow.Text) - 1) != 0)
            {
                LabelRow.Text = (Convert.ToInt32(LabelRow.Text) - 1).ToString();
            }
            Build.Generate(Convert.ToInt32(LabelCol.Text), Convert.ToInt32(LabelRow.Text), TableLayout,this);
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            LabelRow.Text = (Convert.ToInt32(LabelRow.Text) + 1).ToString();
            Build.Generate(Convert.ToInt32(LabelCol.Text), Convert.ToInt32(LabelRow.Text), TableLayout,this);
        }
        //----------------CHECKBOX---------------------------------------
        private void cbEnableLoopback_CheckedChanged(object sender, EventArgs e)
        {
            restartLoopback();  
        }
        //-----------------COMBO------------------------
        private void ComboVC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loopbackWaveOut != null && loopbackSourceStream != null)
            {
                restartLoopback();
                
            }

            stopPlayback();


            initAudioPlaybackEngine1();
        }

        private void ComboMic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loopbackWaveOut != null && loopbackSourceStream != null)
            {
                restartLoopback();
            }

            stopPlayback();


            initAudioPlaybackEngine2();
        }

        private void ComboPb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEnableLoopback.Checked) //start loopback on new device, or stop loopback
            {
                restartLoopback();
            }
        }

        //-----------------VOLUME CHANGE--------------------------
        private void vsSoundVolume_VolumeChanged(object sender, EventArgs e)
        {


            Build.sound = vsSoundVolume.Volume;
                 


            //prevent infinite or skipped changes
            if (volumeChangedByField)
            {
                volumeChangedByField = false;

                return;
            }

            volumeChangedBySlider = true;

           // nSoundVolume.Value = Helper.linearVolumeToInteger(vsSoundVolume.Volume);
        }


        private void nSoundVolume_ValueChanged(object sender, EventArgs e)
        {
            //prevent infinite or skipped changes
            if (volumeChangedBySlider)
            {
                volumeChangedBySlider = false;

                return;
            }

            volumeChangedByField = true;

            vsSoundVolume.Volume = (float)(nSoundVolume.Value / 100);
        }

        //--------------------------STOP PLAYBACK --------------------------
        public void stopPlayback()
        {
            DeviceVC.StopAllSounds();
            DevicePlayBack.StopAllSounds();
        }

        //-----------------------PLAY SOUND -----------------------------------
        public void playSound(string file, float soundVolume)
            {
                stopPlayback();

                try
                {
                    DeviceVC.PlaySound(file, soundVolume);

                    //Don't try to play the sound if the device is not selected or the device is the same as #1.
                    if (SelectedPlaybackDevice2 >= 0 && SelectedPlaybackDevice2 != SelectedPlaybackDevice1)
                    {
                        DevicePlayBack.PlaySound(file, soundVolume);
                    }
                }
                catch (FormatException ex)
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show(ex.ToString());
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    SystemSounds.Beep.Play();
                    MessageBox.Show(ex.ToString());
                }
                catch (NAudio.MmException ex)
                {
                    SystemSounds.Beep.Play();
                    string msg = ex.ToString();
                    MessageBox.Show((msg.Contains("UnspecifiedError calling waveOutOpen") ? "Something is wrong with either the sound you tried to play (" + file.Substring(file.LastIndexOf("\\") + 1) + ") (try converting it to another format) or your sound card driver\n\n" + msg : msg));
                }
            }
        


        //------------------INIT DEVICE -------------------------------
        private void initAudioPlaybackEngine1()
        {
            try
            {
                DeviceVC.Init(SelectedPlaybackDevice1);
            }
            catch (NAudio.MmException ex)
            {
                SystemSounds.Beep.Play();

                string msg = ex.ToString();

                if (msg.Contains("AlreadyAllocated calling waveOutOpen"))
                {
                    msg = "Failed to open device. Already in exclusive use by another application? \n\n" + msg;
                }

                MessageBox.Show("Playback 1" + msg);
            }
        }

        private void initAudioPlaybackEngine2()
        {
            //Don't init if the null entry is selected
            if (SelectedPlaybackDevice2 >= 0)
            {
                try
                {
                    DevicePlayBack.Init(SelectedPlaybackDevice2);
                }
                catch (NAudio.MmException ex)
                {
                    SystemSounds.Beep.Play();

                    string msg = ex.ToString();

                    if (msg.Contains("AlreadyAllocated calling waveOutOpen"))
                    {
                        msg = "Failed to open device. Already in exclusive use by another application? \n\n" + msg;
                    }

                    MessageBox.Show("Playback 2" + msg);
                }
            }
        }


        //-----------------CHECKBOX-----------------------
        private void DisableCheckboxChangeEvents()
        {
            cbEnableLoopback.CheckedChanged -= cbEnableLoopback_CheckedChanged;
        }

        private void EnableCheckboxChangeEvents()
        {
            cbEnableLoopback.CheckedChanged += cbEnableLoopback_CheckedChanged;
        }


        //---------------------VOLUME--------------------------
        private void DisableSoundVolumeChangeEvents()
        {
            vsSoundVolume.VolumeChanged -= vsSoundVolume_VolumeChanged;
            nSoundVolume.ValueChanged -= nSoundVolume_ValueChanged;
        }

        private void EnableSoundVolumeChangeEvents()
        {
            vsSoundVolume.VolumeChanged += vsSoundVolume_VolumeChanged;
            nSoundVolume.ValueChanged += nSoundVolume_ValueChanged;
        }

        //------------------DEVICE CHANGE -------------------------
        private void DisableDeviceChangeEvents()
        {
            ComboVC.SelectedIndexChanged -= ComboVC_SelectedIndexChanged;
            ComboPb.SelectedIndexChanged -= ComboMic_SelectedIndexChanged;
            ComboMic.SelectedIndexChanged -= ComboPb_SelectedIndexChanged;
        }

        private void EnableDeviceChangeEvents()
        {
            ComboVC.SelectedIndexChanged += ComboVC_SelectedIndexChanged;
            ComboPb.SelectedIndexChanged += ComboMic_SelectedIndexChanged;
            ComboMic.SelectedIndexChanged += ComboPb_SelectedIndexChanged;
        }


        //----------------------LOAD DEVICE ---------------------------
        private void loadSoundDevices(bool enableEvents = true)
        {
            DisableDeviceChangeEvents(); //avoid audio related errors

            var playbackSources = new List<WaveOutCapabilities>();
            var loopbackSources = new List<WaveInCapabilities>();

            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                playbackSources.Add(WaveOut.GetCapabilities(i));
            }

            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                loopbackSources.Add(WaveIn.GetCapabilities(i));
            }

            ComboVC.Items.Clear();
            ComboPb.Items.Clear();
            ComboMic.Items.Clear();

            foreach (var source in playbackSources)
            {
                ComboVC.Items.Add(source.ProductName);
                ComboPb.Items.Add(source.ProductName);
            }

            ComboMic.Items.Insert(0, "DO_NOT_USE");
            ComboPb.Items.Insert(0, "DO_NOT_USE");

            SelectedPlaybackDevice1 = -1;
            SelectedPlaybackDevice2 = -1;

            if (ComboVC.Items.Count > 0)
            {
                SelectedPlaybackDevice1 = 0;
            }

            if (ComboPb.Items.Count > 0)
            {
                SelectedPlaybackDevice2 = -1;
            }

            foreach (var source in loopbackSources)
            {
                ComboMic.Items.Add(source.ProductName);
            }

            ComboMic.SelectedIndex = 0;

            if (enableEvents)
            {
                EnableDeviceChangeEvents();
            }
        }


        //---------------------LOOPBACK------------------------------
        private void restartLoopback()
        {
            stopLoopback();

            //Subtract one from index to account for null entry.
            int deviceNumber = ComboMic.SelectedIndex - 1;

            if (deviceNumber >= 0 && cbEnableLoopback.Checked)
            {
                if (loopbackSourceStream == null)
                    loopbackSourceStream = new WaveIn();
                loopbackSourceStream.DeviceNumber = deviceNumber;
                loopbackSourceStream.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(deviceNumber).Channels);
                loopbackSourceStream.BufferMilliseconds = 25;
                loopbackSourceStream.NumberOfBuffers = 5;
                loopbackSourceStream.DataAvailable += loopbackSourceStream_DataAvailable;

                loopbackWaveProvider = new BufferedWaveProvider(loopbackSourceStream.WaveFormat);
                loopbackWaveProvider.DiscardOnBufferOverflow = true;

                if (loopbackWaveOut == null)
                    loopbackWaveOut = new WaveOut();
                loopbackWaveOut.DeviceNumber = ComboVC.SelectedIndex;
                loopbackWaveOut.DesiredLatency = 125;
                loopbackWaveOut.Init(loopbackWaveProvider);

                loopbackSourceStream.StartRecording();
                loopbackWaveOut.Play();
            }
        }

        private void stopLoopback()
        {
            try
            {
                if (loopbackWaveOut != null)
                {
                    loopbackWaveOut.Stop();
                    loopbackWaveOut.Dispose();
                    loopbackWaveOut = null;
                }

                if (loopbackWaveProvider != null)
                {
                    loopbackWaveProvider.ClearBuffer();
                    loopbackWaveProvider = null;
                }

                if (loopbackSourceStream != null)
                {
                    loopbackSourceStream.StopRecording();
                    loopbackSourceStream.Dispose();
                    loopbackSourceStream = null;
                }
            }
            catch (Exception) { }
        }

        private void loopbackSourceStream_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (loopbackWaveProvider != null && loopbackWaveProvider.BufferedDuration.TotalMilliseconds <= 100)
                loopbackWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }


        //--------------PROFILE-----------------------------

        private void LoadProfile_Click(object sender, EventArgs e)
        {
            Build.idprofile = Convert.ToInt32(LabelidProfile.Text);
            sql.ReadSQL(TableLayout, LabelRow, LabelCol, LabelidProfile,this,Build);
            sql.WriteLastProfil(Convert.ToInt32(LabelidProfile.Text));
        }

        private void SaveProfile_Click(object sender, EventArgs e)
        {
            string profil = Regex.Replace(ComboProfile.Text, @"[0-9\-]", "");

            sql.WriteSQL(profil, Convert.ToInt32(LabelCol.Text), Convert.ToInt32(LabelRow.Text), LabelidProfile);
            sql.WriteLastProfil(Convert.ToInt32(LabelidProfile.Text));
            sql.ReadListProfil(ComboProfile);
            sql.ReadLastProfil(ComboProfile, LabelidProfile);
            LoadProfile_Click(sender, e);
        }

        private void ComboProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] id;
            id = ComboProfile.SelectedItem.ToString().Split('-');
            LabelidProfile.Text = id[0];
        }

        private void DeleteProfile_Click(object sender, EventArgs e)
        {
            if(LabelidProfile.Text=="1")
            {
                MessageBox.Show("Impossible to delete Default profile !");
            }
            else
            { 
            sql.DeleteProfile(Convert.ToInt32(LabelidProfile.Text));
            sql.ReadListProfil(ComboProfile);
            ComboProfile.SelectedIndex = 0;
            ComboProfile_SelectedIndexChanged(sender,e);
            LoadProfile_Click(sender, e);
            }
        }

        //---------------MENUSTRIP-----------------------------
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {       
            
            //frenchToolStripMenuItem.Checked = false;
            //englishToolStripMenuItem.Checked = true;
            sql.UpdateLang(0);
            Application.Restart();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            
            //frenchToolStripMenuItem.Checked = true;
            //englishToolStripMenuItem.Checked = false;
            sql.UpdateLang(1);
            Application.Restart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int lang = sql.LastLang();
            switch (lang)
            {
                case 0:
                    frenchToolStripMenuItem.Checked = false;
                    englishToolStripMenuItem.Checked = true;
                    break;
                case 1:
                    frenchToolStripMenuItem.Checked = true;
                    englishToolStripMenuItem.Checked = false;
                    break;
            }
        }

        //--------------ABOUT FORM-----------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {
                form.Text = "A propos";
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle= FormBorderStyle.FixedSingle;
                form.Icon = this.Icon;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.ClientSize = new System.Drawing.Size(250, 150);
                Label lb = new Label();
                lb.Size= new System.Drawing.Size(250, 75);

                lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lb.Text = "Create by Maitre Kuc";
                lb.AutoSize = false;

                lb.Dock = DockStyle.None;
                
                lb.Width = form.Width - 10;
                form.Controls.Add(lb);

                LinkLabel lk = new LinkLabel();
                
                lk.Size = new System.Drawing.Size(250, 75);
                lk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lk.Text = "Github";
                lk.Location = new System.Drawing.Point(0, 75);
                lk.LinkClicked+=(s, ee) => { System.Diagnostics.Process.Start("https://github.com/MaitreKuc/Symply-SoundBorard-MK"); };
                     
                form.Controls.Add(lk);
                form.ShowDialog();
            }
        }
    }
}
