
namespace Symply_SoundBoard_MK
{
    partial class ModfiyTextButton
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModfiyTextButton));
            this.TxtLabelButton = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtLabelButton
            // 
            this.TxtLabelButton.Location = new System.Drawing.Point(13, 13);
            this.TxtLabelButton.Name = "TxtLabelButton";
            this.TxtLabelButton.Size = new System.Drawing.Size(254, 20);
            this.TxtLabelButton.TabIndex = 0;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 39);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(255, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // ModfiyTextButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 74);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtLabelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModfiyTextButton";
            this.Text = "ModfiyTextButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLabelButton;
        private System.Windows.Forms.Button BtnOK;
    }
}