using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.Forms
{
    public partial class PasswordChange : Form
    {
        //public static string conString = "Data Source=DESKTOP-2FODQJ3;Initial Catalog=LoginDb;Integrated Security=True;TrustServerCertificate=True";
        private int id;
        public PasswordChange(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() == txtRePass.Text.Trim())
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConString);
                    sqlConnection.Open();
                    String passwordQuery = "UPDATE [Identity] SET password = '" + txtNewPassword.Text.Trim() + "' where id = " + id + "";
                    SqlCommand passwordCommand = new SqlCommand(passwordQuery, sqlConnection);
                    passwordCommand.CommandType = CommandType.Text;
                    passwordCommand.ExecuteNonQuery();
                    LoginFrm loginFrm = new LoginFrm();
                    loginFrm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please match password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRePass.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();
            this.Close();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void groupChange_Enter(object sender, EventArgs e)
        {

        }
    }
}
