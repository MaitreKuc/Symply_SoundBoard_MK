using System.Windows.Forms;
using Symply_SoundBoard_MK.SQL;

namespace Symply_SoundBoard_MK
{
    class GenerateTableLayout
    {
        public int idprofile;
        private string PathSound;
        SQLClass sql = new SQLClass();
        public void Generate(int columnCount, int rowCount, TableLayoutPanel layout,MainForm fm)
        {
            layout.SuspendLayout();

            layout.Controls.Clear();

            layout.ColumnStyles.Clear();
            layout.RowStyles.Clear();

            layout.ColumnCount = columnCount;
            layout.RowCount = rowCount;
            var percent = 100f / (float)(columnCount * rowCount);
            for (int x = 0; x < columnCount; x++)
            {
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percent));

                for (int y = 0; y < rowCount; y++)
                {
                    if (x == 0)
                    {
                        layout.RowStyles.Add(new RowStyle(SizeType.Percent, percent));
                    }

                    Button cmd = new Button();
                    cmd.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
                    cmd.Name = string.Format("{0}_{1}", x, y);
                    //cmd.Text = string.Format("Button " + (x + y));
                    cmd.Text = sql.LabelSQL(idprofile, cmd.Name);
                    cmd.MouseDown += (s, e) => { ReadButton(s, (MouseEventArgs)e, cmd.Name, fm,cmd); };
                    layout.Controls.Add(cmd, x, y);
                }
            }
            layout.ResumeLayout();
        }

        private void ReadButton(object s, MouseEventArgs e, string bt,MainForm fm,Button button)
        {
            if (e.Button == MouseButtons.Right)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Audio Files| *.wav; *.aac; *.wma; *.mp3; *.WAV; *.AAC; *.WMA; *.MP3";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    sql.WriteSQLSound(idprofile, file.FileName, bt, file.FileName);
                    button.Text = sql.LabelSQL(idprofile, button.Name);
                }
            }
            else if(e.Button == MouseButtons.Middle)
            {
                ModfiyTextButton modfiy = new ModfiyTextButton();
                var result = modfiy.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if(modfiy.ReturnTxt!="")
                    {
                        sql.UpdateLabelButton(idprofile, bt, modfiy.ReturnTxt);
                        button.Text = sql.LabelSQL(idprofile, button.Name);
                    }                    
                }
            }
            else
            {
                PathSound = sql.ReadSQLSound(idprofile, bt);
                if(PathSound !="") fm.playSound(PathSound, 1);
            }
        }
    }
}
