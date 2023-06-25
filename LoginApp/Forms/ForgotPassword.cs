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
using System.Net;
using System.Net.Mail;
using LoginApp.Entities;

namespace LoginApp.Forms
{
    public partial class ForgotPassword : Form
    {
       // public static string conString = "Data Source=DESKTOP-2FODQJ3;Initial Catalog=LoginDb;Integrated Security=True;TrustServerCertificate=True";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConString);
            String emailQuery = "Select id from [Identity] where email = '" + txtEmail.Text.Trim() + "'";
            SqlCommand emailCheckCommand = new SqlCommand(emailQuery, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = emailCheckCommand.ExecuteReader();
            IdentityEntity identityEntity = new IdentityEntity();
            while (reader.Read())
            {
                identityEntity.Id = (int)reader["id"];
            }
            sqlConnection.Close();
            if (identityEntity.Id > 0)
            {
                Random random = new Random();
                int randomCode = random.Next(100000, 999999);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("login.applicationn@gmail.com", "izpjxmusbzkfojsg");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("login.applicationn@gmail.com");
                mail.To.Add(txtEmail.Text.Trim());
                mail.Subject = "Reset Password";
                mail.Body = "Te reset code is " + randomCode + " ";
                try
                {
                    smtpClient.Send(mail);
                    ForgotCode code = new ForgotCode(randomCode, identityEntity.Id);
                    code.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to send email. Error: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("This email address is not registerd!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
