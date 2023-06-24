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
        public static string conString = "Data Source=DESKTOP-2FODQJ3;Initial Catalog=LoginDb;Integrated Security=True;TrustServerCertificate=True";

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(conString);
                String query = " Insert into[Identity](emri, mbiemri, nrTelefonit, email, ditelindja, gjinia, password, adresa) VALUES('" + txtEmri.Text.Trim() + "', '" + txtMbiemri.Text.Trim() + "', '" + txtTelefoni.Text.Trim() + "', '" + txtEmail.Text.Trim() + "'," +
                    " '" + datePicDitlindja.Text.Trim() + "', '" + cmbGjinia.Text.Trim() + "', '" + txtPassword.Text.Trim() + "', '" + txtAdresa.Text.Trim() + "')";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                command.CommandType = CommandType.Text;
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                LoginFrm loginFrm = new LoginFrm();
                loginFrm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
