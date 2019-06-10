using System;
using System.Windows.Forms;

namespace JCIT_ODSPROLoginPage
{
    public partial class frmLoginPage : Form
    {
        string username;

        public string ResultText
        {
            get { return username;}
        }

        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            DialogResult = DialogResult.OK;
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                ButtonLogin_Click(sender, e);
            }
        }
    }
}
