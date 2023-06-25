using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.Forms
{
    public partial class ForgotCode : Form
    {
        private int randomCode;
        private int id;
        public ForgotCode(int code,int id)
        {
            InitializeComponent();
            randomCode = code;
            this.id = id;   
        }

        private void ForgotCode_Load(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (randomCode == int.Parse(txtCode.Text.Trim())) {
                PasswordChange passwordChange = new PasswordChange(id);
                passwordChange.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Code does not match!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
