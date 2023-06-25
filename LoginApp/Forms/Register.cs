using LoginApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginApp.Forms
{
    public partial class Register : Form
    {
      //  public static string conString = "Data Source=DESKTOP-2FODQJ3;Initial Catalog=LoginDb;Integrated Security=True;TrustServerCertificate=True";

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConString);
            String emailQuery = "Select email from [Identity] where email = '" + txtEmail.Text.Trim() + "'";
            SqlCommand emailCheckCommand = new SqlCommand(emailQuery, sqlConnection);
            sqlConnection.Open();
            emailCheckCommand.CommandType = CommandType.Text;
            SqlDataReader reader = emailCheckCommand.ExecuteReader();
            IdentityEntity identityEntity = new IdentityEntity();
            while (reader.Read())
            {
                identityEntity.Email = (string)reader["email"];
            }
            sqlConnection.Close();
            if (identityEntity.Email != null)
            {
                MessageBox.Show("This email address is alredy registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtRePass.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("You must match Passwords", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    String query = " Insert into[Identity](emri, mbiemri, nrTelefonit, email, ditelindja, gjinia, password, adresa) VALUES('" + txtEmri.Text.Trim() + "', '" + txtMbiemri.Text.Trim() + "', '" + txtTelefoni.Text.Trim() + "', '" + txtEmail.Text.Trim() + "'," +
                        " '" + datePicDitlindja.Text.Trim() + "', '" + cmbGjinia.Text.Trim() + "', '" + txtPassword.Text.Trim() + "', '" + txtAdresa.Text.Trim() + "')";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    command.CommandType = CommandType.Text;
                   command.ExecuteNonQuery();
                    sqlConnection.Close();
                    LoginFrm loginFrm = new LoginFrm();
                    loginFrm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();
            this.Close();
        }
    }
}
