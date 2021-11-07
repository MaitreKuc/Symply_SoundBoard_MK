
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
            this.gbAudioDevices = new System.Windows.Forms.GroupBox();
            this.ComboPb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayback2 = new System.Windows.Forms.Label();
            this.lblPlayback1 = new System.Windows.Forms.Label();
            this.lblLoopback = new System.Windows.Forms.Label();
            this.btnReloadDevices = new System.Windows.Forms.Button();
            this.ComboVC = new System.Windows.Forms.ComboBox();
            this.ComboMic = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelRow = new System.Windows.Forms.Label();
            this.RemoveRow = new System.Windows.Forms.Button();
            this.AddRow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelCol = new System.Windows.Forms.Label();
            this.AddCol = new System.Windows.Forms.Button();
            this.RemoveCol = new System.Windows.Forms.Button();
            this.gbSoundboard = new System.Windows.Forms.GroupBox();
            this.vsSoundVolume = new NAudio.Gui.VolumeSlider();
            this.nSoundVolume = new System.Windows.Forms.NumericUpDown();
            this.cbEnableLoopback = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteProfile = new System.Windows.Forms.Button();
            this.LabelidProfile = new System.Windows.Forms.Label();
            this.SaveProfile = new System.Windows.Forms.Button();
            this.LoadProfile = new System.Windows.Forms.Button();
            this.ComboProfile = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAudioDevices.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSoundboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayout
            // 
            resources.ApplyResources(this.TableLayout, "TableLayout");
            this.TableLayout.Name = "TableLayout";
            // 
            // gbAudioDevices
            // 
            resources.ApplyResources(this.gbAudioDevices, "gbAudioDevices");
            this.gbAudioDevices.Controls.Add(this.ComboPb);
            this.gbAudioDevices.Controls.Add(this.label6);
            this.gbAudioDevices.Controls.Add(this.lblPlayback2);
            this.gbAudioDevices.Controls.Add(this.lblPlayback1);
            this.gbAudioDevices.Controls.Add(this.lblLoopback);
            this.gbAudioDevices.Controls.Add(this.btnReloadDevices);
            this.gbAudioDevices.Controls.Add(this.ComboVC);
            this.gbAudioDevices.Controls.Add(this.ComboMic);
            this.gbAudioDevices.Name = "gbAudioDevices";
            this.gbAudioDevices.TabStop = false;
            // 
            // ComboPb
            // 
            this.ComboPb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPb.FormattingEnabled = true;
            resources.ApplyResources(this.ComboPb, "ComboPb");
            this.ComboPb.Name = "ComboPb";
            this.ComboPb.SelectedIndexChanged += new System.EventHandler(this.ComboPb_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblPlayback2
            // 
            resources.ApplyResources(this.lblPlayback2, "lblPlayback2");
            this.lblPlayback2.Name = "lblPlayback2";
            // 
            // lblPlayback1
            // 
            resources.ApplyResources(this.lblPlayback1, "lblPlayback1");
            this.lblPlayback1.Name = "lblPlayback1";
            // 
            // lblLoopback
            // 
            resources.ApplyResources(this.lblLoopback, "lblLoopback");
            this.lblLoopback.Name = "lblLoopback";
            // 
            // btnReloadDevices
            // 
            resources.ApplyResources(this.btnReloadDevices, "btnReloadDevices");
            this.btnReloadDevices.Name = "btnReloadDevices";
            this.btnReloadDevices.UseVisualStyleBackColor = true;
            // 
            // ComboVC
            // 
            this.ComboVC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboVC.FormattingEnabled = true;
            resources.ApplyResources(this.ComboVC, "ComboVC");
            this.ComboVC.Name = "ComboVC";
            this.ComboVC.SelectedIndexChanged += new System.EventHandler(this.ComboVC_SelectedIndexChanged);
            // 
            // ComboMic
            // 
            this.ComboMic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMic.FormattingEnabled = true;
            resources.ApplyResources(this.ComboMic, "ComboMic");
            this.ComboMic.Name = "ComboMic";
            this.ComboMic.SelectedIndexChanged += new System.EventHandler(this.ComboMic_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.LabelRow);
            this.groupBox1.Controls.Add(this.RemoveRow);
            this.groupBox1.Controls.Add(this.AddRow);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // LabelRow
            // 
            resources.ApplyResources(this.LabelRow, "LabelRow");
            this.LabelRow.Name = "LabelRow";
            // 
            // RemoveRow
            // 
            resources.ApplyResources(this.RemoveRow, "RemoveRow");
            this.RemoveRow.Name = "RemoveRow";
            this.RemoveRow.UseVisualStyleBackColor = true;
            this.RemoveRow.Click += new System.EventHandler(this.RemoveRow_Click);
            // 
            // AddRow
            // 
            resources.ApplyResources(this.AddRow, "AddRow");
            this.AddRow.Name = "AddRow";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.LabelCol);
            this.groupBox2.Controls.Add(this.AddCol);
            this.groupBox2.Controls.Add(this.RemoveCol);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // LabelCol
            // 
            resources.ApplyResources(this.LabelCol, "LabelCol");
            this.LabelCol.Name = "LabelCol";
            // 
            // AddCol
            // 
            resources.ApplyResources(this.AddCol, "AddCol");
            this.AddCol.Name = "AddCol";
            this.AddCol.UseVisualStyleBackColor = true;
            this.AddCol.Click += new System.EventHandler(this.AddCol_Click);
            // 
            // RemoveCol
            // 
            resources.ApplyResources(this.RemoveCol, "RemoveCol");
            this.RemoveCol.Name = "RemoveCol";
            this.RemoveCol.UseVisualStyleBackColor = true;
            this.RemoveCol.Click += new System.EventHandler(this.RemoveCol_Click);
            // 
            // gbSoundboard
            // 
            resources.ApplyResources(this.gbSoundboard, "gbSoundboard");
            this.gbSoundboard.Controls.Add(this.vsSoundVolume);
            this.gbSoundboard.Controls.Add(this.nSoundVolume);
            this.gbSoundboard.Controls.Add(this.cbEnableLoopback);
            this.gbSoundboard.Name = "gbSoundboard";
            this.gbSoundboard.TabStop = false;
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
            this.cbEnableLoopback.Name = "cbEnableLoopback";
            this.cbEnableLoopback.UseVisualStyleBackColor = true;
            this.cbEnableLoopback.CheckedChanged += new System.EventHandler(this.cbEnableLoopback_CheckedChanged);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.DeleteProfile);
            this.groupBox3.Controls.Add(this.LabelidProfile);
            this.groupBox3.Controls.Add(this.SaveProfile);
            this.groupBox3.Controls.Add(this.LoadProfile);
            this.groupBox3.Controls.Add(this.ComboProfile);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // DeleteProfile
            // 
            resources.ApplyResources(this.DeleteProfile, "DeleteProfile");
            this.DeleteProfile.Name = "DeleteProfile";
            this.DeleteProfile.UseVisualStyleBackColor = true;
            this.DeleteProfile.Click += new System.EventHandler(this.DeleteProfile_Click);
            // 
            // LabelidProfile
            // 
            resources.ApplyResources(this.LabelidProfile, "LabelidProfile");
            this.LabelidProfile.Name = "LabelidProfile";
            // 
            // SaveProfile
            // 
            resources.ApplyResources(this.SaveProfile, "SaveProfile");
            this.SaveProfile.Name = "SaveProfile";
            this.SaveProfile.UseVisualStyleBackColor = true;
            this.SaveProfile.Click += new System.EventHandler(this.SaveProfile_Click);
            // 
            // LoadProfile
            // 
            resources.ApplyResources(this.LoadProfile, "LoadProfile");
            this.LoadProfile.Name = "LoadProfile";
            this.LoadProfile.UseVisualStyleBackColor = true;
            this.LoadProfile.Click += new System.EventHandler(this.LoadProfile_Click);
            // 
            // ComboProfile
            // 
            this.ComboProfile.FormattingEnabled = true;
            resources.ApplyResources(this.ComboProfile, "ComboProfile");
            this.ComboProfile.Name = "ComboProfile";
            this.ComboProfile.SelectedIndexChanged += new System.EventHandler(this.ComboProfile_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbSoundboard);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAudioDevices);
            this.Controls.Add(this.TableLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbAudioDevices.ResumeLayout(false);
            this.gbAudioDevices.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbSoundboard.ResumeLayout(false);
            this.gbSoundboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSoundVolume)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private System.Windows.Forms.GroupBox gbAudioDevices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlayback2;
        private System.Windows.Forms.Label lblPlayback1;
        private System.Windows.Forms.Label lblLoopback;
        private System.Windows.Forms.Button btnReloadDevices;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LabelRow;
        private System.Windows.Forms.Button RemoveRow;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Label LabelCol;
        private System.Windows.Forms.Button AddCol;
        private System.Windows.Forms.Button RemoveCol;
        private System.Windows.Forms.GroupBox gbSoundboard;
        public System.Windows.Forms.CheckBox cbEnableLoopback;
        public System.Windows.Forms.ComboBox ComboVC;
        public System.Windows.Forms.ComboBox ComboMic;
        public System.Windows.Forms.ComboBox ComboPb;
        public NAudio.Gui.VolumeSlider vsSoundVolume;
        public System.Windows.Forms.NumericUpDown nSoundVolume;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveProfile;
        private System.Windows.Forms.Button LoadProfile;
        private System.Windows.Forms.ComboBox ComboProfile;
        private System.Windows.Forms.Label LabelidProfile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteProfile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

