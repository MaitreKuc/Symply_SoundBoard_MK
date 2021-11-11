
namespace Symply_SoundBoard_MK
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ComboPb = new System.Windows.Forms.ComboBox();
            this.lblPlayback2 = new System.Windows.Forms.Label();
            this.lblPlayback1 = new System.Windows.Forms.Label();
            this.lblLoopback = new System.Windows.Forms.Label();
            this.btnReloadDevices = new System.Windows.Forms.Button();
            this.ComboVC = new System.Windows.Forms.ComboBox();
            this.ComboMic = new System.Windows.Forms.ComboBox();
            this.LabelRow = new System.Windows.Forms.Label();
            this.RemoveRow = new System.Windows.Forms.Button();
            this.AddRow = new System.Windows.Forms.Button();
            this.LabelCol = new System.Windows.Forms.Label();
            this.AddCol = new System.Windows.Forms.Button();
            this.RemoveCol = new System.Windows.Forms.Button();
            this.vsSoundVolume = new NAudio.Gui.VolumeSlider();
            this.nSoundVolume = new System.Windows.Forms.NumericUpDown();
            this.cbEnableLoopback = new System.Windows.Forms.CheckBox();
            this.DeleteProfile = new System.Windows.Forms.Button();
            this.LabelidProfile = new System.Windows.Forms.Label();
            this.SaveProfile = new System.Windows.Forms.Button();
            this.LoadProfile = new System.Windows.Forms.Button();
            this.ComboProfile = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablePanelAbout = new System.Windows.Forms.TableLayoutPanel();
            this.BtAbout = new System.Windows.Forms.Button();
            this.TablePanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtInfo = new System.Windows.Forms.Button();
            this.PanelLanguage = new System.Windows.Forms.Panel();
            this.BtLanguage = new System.Windows.Forms.Button();
            this.PanelLoopback = new System.Windows.Forms.Panel();
            this.BtVolLoopback = new System.Windows.Forms.Button();
            this.TablePanelDevices = new System.Windows.Forms.TableLayoutPanel();
            this.BtAudioDevice = new System.Windows.Forms.Button();
            this.TablePanelCustomize = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtCustomize = new System.Windows.Forms.Button();
            this.TablePanelProfil = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).BeginInit();
            this.panel1.SuspendLayout();
            this.TablePanelAbout.SuspendLayout();
            this.TablePanelInfo.SuspendLayout();
            this.PanelLanguage.SuspendLayout();
            this.PanelLoopback.SuspendLayout();
            this.TablePanelDevices.SuspendLayout();
            this.TablePanelCustomize.SuspendLayout();
            this.TablePanelProfil.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            resources.ApplyResources(this.TableLayout, "TableLayout");
            this.TableLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.TableLayout.Name = "TableLayout";
            // 
            // ComboPb
            // 
            resources.ApplyResources(this.ComboPb, "ComboPb");
            this.ComboPb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPb.FormattingEnabled = true;
            this.ComboPb.Name = "ComboPb";
            this.ComboPb.SelectedIndexChanged += new System.EventHandler(this.ComboPb_SelectedIndexChanged);
            // 
            // lblPlayback2
            // 
            resources.ApplyResources(this.lblPlayback2, "lblPlayback2");
            this.lblPlayback2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayback2.Name = "lblPlayback2";
            // 
            // lblPlayback1
            // 
            resources.ApplyResources(this.lblPlayback1, "lblPlayback1");
            this.lblPlayback1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayback1.Name = "lblPlayback1";
            // 
            // lblLoopback
            // 
            resources.ApplyResources(this.lblLoopback, "lblLoopback");
            this.lblLoopback.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLoopback.Name = "lblLoopback";
            // 
            // btnReloadDevices
            // 
            resources.ApplyResources(this.btnReloadDevices, "btnReloadDevices");
            this.btnReloadDevices.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReloadDevices.Name = "btnReloadDevices";
            this.btnReloadDevices.UseVisualStyleBackColor = true;
            this.btnReloadDevices.Click += new System.EventHandler(this.btnReloadDevices_Click);
            // 
            // ComboVC
            // 
            resources.ApplyResources(this.ComboVC, "ComboVC");
            this.ComboVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboVC.FormattingEnabled = true;
            this.ComboVC.Name = "ComboVC";
            this.ComboVC.SelectedIndexChanged += new System.EventHandler(this.ComboVC_SelectedIndexChanged);
            // 
            // ComboMic
            // 
            resources.ApplyResources(this.ComboMic, "ComboMic");
            this.ComboMic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMic.FormattingEnabled = true;
            this.ComboMic.Name = "ComboMic";
            this.ComboMic.SelectedIndexChanged += new System.EventHandler(this.ComboMic_SelectedIndexChanged);
            // 
            // LabelRow
            // 
            resources.ApplyResources(this.LabelRow, "LabelRow");
            this.LabelRow.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelRow.Name = "LabelRow";
            // 
            // RemoveRow
            // 
            resources.ApplyResources(this.RemoveRow, "RemoveRow");
            this.RemoveRow.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveRow.Name = "RemoveRow";
            this.RemoveRow.UseVisualStyleBackColor = true;
            this.RemoveRow.Click += new System.EventHandler(this.RemoveRow_Click);
            // 
            // AddRow
            // 
            resources.ApplyResources(this.AddRow, "AddRow");
            this.AddRow.ForeColor = System.Drawing.SystemColors.Control;
            this.AddRow.Name = "AddRow";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // LabelCol
            // 
            resources.ApplyResources(this.LabelCol, "LabelCol");
            this.LabelCol.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelCol.Name = "LabelCol";
            // 
            // AddCol
            // 
            resources.ApplyResources(this.AddCol, "AddCol");
            this.AddCol.ForeColor = System.Drawing.SystemColors.Control;
            this.AddCol.Name = "AddCol";
            this.AddCol.UseVisualStyleBackColor = true;
            this.AddCol.Click += new System.EventHandler(this.AddCol_Click);
            // 
            // RemoveCol
            // 
            resources.ApplyResources(this.RemoveCol, "RemoveCol");
            this.RemoveCol.ForeColor = System.Drawing.SystemColors.Control;
            this.RemoveCol.Name = "RemoveCol";
            this.RemoveCol.UseVisualStyleBackColor = true;
            this.RemoveCol.Click += new System.EventHandler(this.RemoveCol_Click);
            // 
            // vsSoundVolume
            // 
            resources.ApplyResources(this.vsSoundVolume, "vsSoundVolume");
            this.vsSoundVolume.Name = "vsSoundVolume";
            this.vsSoundVolume.TabStop = false;
            // 
            // nSoundVolume
            // 
            resources.ApplyResources(this.nSoundVolume, "nSoundVolume");
            this.nSoundVolume.Name = "nSoundVolume";
            this.nSoundVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cbEnableLoopback
            // 
            resources.ApplyResources(this.cbEnableLoopback, "cbEnableLoopback");
            this.cbEnableLoopback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.cbEnableLoopback.ForeColor = System.Drawing.SystemColors.Control;
            this.cbEnableLoopback.Name = "cbEnableLoopback";
            this.cbEnableLoopback.UseVisualStyleBackColor = false;
            this.cbEnableLoopback.CheckedChanged += new System.EventHandler(this.cbEnableLoopback_CheckedChanged);
            // 
            // DeleteProfile
            // 
            resources.ApplyResources(this.DeleteProfile, "DeleteProfile");
            this.DeleteProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteProfile.Name = "DeleteProfile";
            this.DeleteProfile.UseVisualStyleBackColor = true;
            this.DeleteProfile.Click += new System.EventHandler(this.DeleteProfile_Click);
            // 
            // LabelidProfile
            // 
            resources.ApplyResources(this.LabelidProfile, "LabelidProfile");
            this.LabelidProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelidProfile.Name = "LabelidProfile";
            // 
            // SaveProfile
            // 
            resources.ApplyResources(this.SaveProfile, "SaveProfile");
            this.SaveProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveProfile.Name = "SaveProfile";
            this.SaveProfile.UseVisualStyleBackColor = true;
            this.SaveProfile.Click += new System.EventHandler(this.SaveProfile_Click);
            // 
            // LoadProfile
            // 
            resources.ApplyResources(this.LoadProfile, "LoadProfile");
            this.LoadProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.LoadProfile.Name = "LoadProfile";
            this.LoadProfile.UseVisualStyleBackColor = true;
            this.LoadProfile.Click += new System.EventHandler(this.LoadProfile_Click);
            // 
            // ComboProfile
            // 
            resources.ApplyResources(this.ComboProfile, "ComboProfile");
            this.ComboProfile.FormattingEnabled = true;
            this.ComboProfile.Name = "ComboProfile";
            this.ComboProfile.SelectedIndexChanged += new System.EventHandler(this.ComboProfile_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(194)))), ((int)(((byte)(145)))));
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.TablePanelAbout);
            this.panel1.Controls.Add(this.BtAbout);
            this.panel1.Controls.Add(this.TablePanelInfo);
            this.panel1.Controls.Add(this.BtInfo);
            this.panel1.Controls.Add(this.PanelLanguage);
            this.panel1.Controls.Add(this.BtLanguage);
            this.panel1.Controls.Add(this.PanelLoopback);
            this.panel1.Controls.Add(this.BtVolLoopback);
            this.panel1.Controls.Add(this.TablePanelDevices);
            this.panel1.Controls.Add(this.BtAudioDevice);
            this.panel1.Controls.Add(this.TablePanelCustomize);
            this.panel1.Controls.Add(this.BtCustomize);
            this.panel1.Controls.Add(this.LabelidProfile);
            this.panel1.Controls.Add(this.TablePanelProfil);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Name = "panel1";
            // 
            // TablePanelAbout
            // 
            resources.ApplyResources(this.TablePanelAbout, "TablePanelAbout");
            this.TablePanelAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.TablePanelAbout.Controls.Add(this.linkLabel1, 1, 0);
            this.TablePanelAbout.Controls.Add(this.label2, 0, 0);
            this.TablePanelAbout.Name = "TablePanelAbout";
            // 
            // BtAbout
            // 
            resources.ApplyResources(this.BtAbout, "BtAbout");
            this.BtAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.BtAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.BtAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.BtAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.BtAbout.Name = "BtAbout";
            this.BtAbout.UseVisualStyleBackColor = true;
            this.BtAbout.Click += new System.EventHandler(this.BtAbout_Click);
            // 
            // TablePanelInfo
            // 
            resources.ApplyResources(this.TablePanelInfo, "TablePanelInfo");
            this.TablePanelInfo.Controls.Add(this.label1, 0, 0);
            this.TablePanelInfo.Name = "TablePanelInfo";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // BtInfo
            // 
            resources.ApplyResources(this.BtInfo, "BtInfo");
            this.BtInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.BtInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.BtInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.BtInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.BtInfo.Name = "BtInfo";
            this.BtInfo.UseVisualStyleBackColor = true;
            this.BtInfo.Click += new System.EventHandler(this.BtInfo_Click);
            // 
            // PanelLanguage
            // 
            resources.ApplyResources(this.PanelLanguage, "PanelLanguage");
            this.PanelLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.PanelLanguage.Controls.Add(this.comboBox1);
            this.PanelLanguage.Name = "PanelLanguage";
            // 
            // BtLanguage
            // 
            resources.ApplyResources(this.BtLanguage, "BtLanguage");
            this.BtLanguage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.BtLanguage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.BtLanguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.BtLanguage.ForeColor = System.Drawing.SystemColors.Control;
            this.BtLanguage.Name = "BtLanguage";
            this.BtLanguage.UseVisualStyleBackColor = true;
            this.BtLanguage.Click += new System.EventHandler(this.BtLanguage_Click);
            // 
            // PanelLoopback
            // 
            resources.ApplyResources(this.PanelLoopback, "PanelLoopback");
            this.PanelLoopback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.PanelLoopback.Controls.Add(this.nSoundVolume);
            this.PanelLoopback.Controls.Add(this.vsSoundVolume);
            this.PanelLoopback.Controls.Add(this.cbEnableLoopback);
            this.PanelLoopback.Name = "PanelLoopback";
            // 
            // BtVolLoopback
            // 
            resources.ApplyResources(this.BtVolLoopback, "BtVolLoopback");
            this.BtVolLoopback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.BtVolLoopback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.BtVolLoopback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.BtVolLoopback.ForeColor = System.Drawing.SystemColors.Control;
            this.BtVolLoopback.Name = "BtVolLoopback";
            this.BtVolLoopback.UseVisualStyleBackColor = true;
            this.BtVolLoopback.Click += new System.EventHandler(this.BtVolLoopback_Click);
            // 
            // TablePanelDevices
            // 
            resources.ApplyResources(this.TablePanelDevices, "TablePanelDevices");
            this.TablePanelDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.TablePanelDevices.Controls.Add(this.ComboPb, 1, 2);
            this.TablePanelDevices.Controls.Add(this.btnReloadDevices, 2, 0);
            this.TablePanelDevices.Controls.Add(this.lblPlayback1, 0, 0);
            this.TablePanelDevices.Controls.Add(this.lblLoopback, 0, 1);
            this.TablePanelDevices.Controls.Add(this.lblPlayback2, 0, 2);
            this.TablePanelDevices.Controls.Add(this.ComboMic, 1, 1);
            this.TablePanelDevices.Controls.Add(this.ComboVC, 1, 0);
            this.TablePanelDevices.Name = "TablePanelDevices";
            // 
            // BtAudioDevice
            // 
            resources.ApplyResources(this.BtAudioDevice, "BtAudioDevice");
            this.BtAudioDevice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.BtAudioDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.BtAudioDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.BtAudioDevice.ForeColor = System.Drawing.SystemColors.Control;
            this.BtAudioDevice.Name = "BtAudioDevice";
            this.BtAudioDevice.UseVisualStyleBackColor = true;
            this.BtAudioDevice.Click += new System.EventHandler(this.BtAudioDevice_Click);
            // 
            // TablePanelCustomize
            // 
            resources.ApplyResources(this.TablePanelCustomize, "TablePanelCustomize");
            this.TablePanelCustomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.TablePanelCustomize.Controls.Add(this.RemoveRow, 0, 3);
            this.TablePanelCustomize.Controls.Add(this.AddRow, 2, 3);
            this.TablePanelCustomize.Controls.Add(this.LabelRow, 1, 3);
            this.TablePanelCustomize.Controls.Add(this.RemoveCol, 0, 1);
            this.TablePanelCustomize.Controls.Add(this.AddCol, 2, 1);
            this.TablePanelCustomize.Controls.Add(this.LabelCol, 1, 1);
            this.TablePanelCustomize.Controls.Add(this.label3, 0, 0);
            this.TablePanelCustomize.Controls.Add(this.label4, 0, 2);
            this.TablePanelCustomize.Name = "TablePanelCustomize";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Name = "label4";
            // 
            // BtCustomize
            // 
            resources.ApplyResources(this.BtCustomize, "BtCustomize");
            this.BtCustomize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.BtCustomize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.BtCustomize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.BtCustomize.ForeColor = System.Drawing.SystemColors.Control;
            this.BtCustomize.Name = "BtCustomize";
            this.BtCustomize.UseVisualStyleBackColor = true;
            this.BtCustomize.Click += new System.EventHandler(this.button1_Click);
            // 
            // TablePanelProfil
            // 
            resources.ApplyResources(this.TablePanelProfil, "TablePanelProfil");
            this.TablePanelProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(55)))), ((int)(((byte)(153)))));
            this.TablePanelProfil.Controls.Add(this.ComboProfile, 0, 0);
            this.TablePanelProfil.Controls.Add(this.DeleteProfile, 0, 3);
            this.TablePanelProfil.Controls.Add(this.LoadProfile, 0, 1);
            this.TablePanelProfil.Controls.Add(this.SaveProfile, 0, 2);
            this.TablePanelProfil.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TablePanelProfil.Name = "TablePanelProfil";
            // 
            // buttonProfile
            // 
            resources.ApplyResources(this.buttonProfile, "buttonProfile");
            this.buttonProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TableLayout);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TablePanelAbout.ResumeLayout(false);
            this.TablePanelAbout.PerformLayout();
            this.TablePanelInfo.ResumeLayout(false);
            this.TablePanelInfo.PerformLayout();
            this.PanelLanguage.ResumeLayout(false);
            this.PanelLoopback.ResumeLayout(false);
            this.PanelLoopback.PerformLayout();
            this.TablePanelDevices.ResumeLayout(false);
            this.TablePanelDevices.PerformLayout();
            this.TablePanelCustomize.ResumeLayout(false);
            this.TablePanelCustomize.PerformLayout();
            this.TablePanelProfil.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.Label lblPlayback2;
        private System.Windows.Forms.Label lblPlayback1;
        private System.Windows.Forms.Label lblLoopback;
        private System.Windows.Forms.Button btnReloadDevices;
        private System.Windows.Forms.Label LabelRow;
        private System.Windows.Forms.Button RemoveRow;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Label LabelCol;
        private System.Windows.Forms.Button AddCol;
        private System.Windows.Forms.Button RemoveCol;
        public System.Windows.Forms.CheckBox cbEnableLoopback;
        public System.Windows.Forms.ComboBox ComboVC;
        public System.Windows.Forms.ComboBox ComboMic;
        public System.Windows.Forms.ComboBox ComboPb;
        public NAudio.Gui.VolumeSlider vsSoundVolume;
        public System.Windows.Forms.NumericUpDown nSoundVolume;
        private System.Windows.Forms.Button SaveProfile;
        private System.Windows.Forms.Button LoadProfile;
        private System.Windows.Forms.ComboBox ComboProfile;
        private System.Windows.Forms.Label LabelidProfile;
        private System.Windows.Forms.Button DeleteProfile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel TablePanelProfil;
        private System.Windows.Forms.TableLayoutPanel TablePanelCustomize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtCustomize;
        private System.Windows.Forms.Button BtAudioDevice;
        private System.Windows.Forms.TableLayoutPanel TablePanelDevices;
        private System.Windows.Forms.TableLayoutPanel TablePanelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtInfo;
        private System.Windows.Forms.Panel PanelLanguage;
        private System.Windows.Forms.Button BtLanguage;
        private System.Windows.Forms.Panel PanelLoopback;
        private System.Windows.Forms.Button BtVolLoopback;
        private System.Windows.Forms.TableLayoutPanel TablePanelAbout;
        private System.Windows.Forms.Button BtAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

