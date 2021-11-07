using System.Windows.Forms;

namespace Symply_SoundBoard_MK
{
    public partial class ModfiyTextButton : Form
    {
        public string ReturnTxt { get; set; }
        public ModfiyTextButton()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, System.EventArgs e)
        {
            this.ReturnTxt = TxtLabelButton.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
