using LoginApp.Entities;
using Microsoft.Data.SqlClient;
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
    public partial class LoginFrm : Form
    {
        
       
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.ConString);
                String query = "Select * from [Identity] where email ='" + txtUsername.Text.Trim() + "'and password='" + txtPassword.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, sql);
                sql.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();
                IdentityEntity identityEntity = new IdentityEntity();
                while (reader.Read())
                {
                    identityEntity.Id = (int)reader["id"];
                    identityEntity.Emri = (string)reader["emri"];
                    identityEntity.Mbiemri = (string)reader["mbiemri"];
                    identityEntity.Email = (string)reader["email"];
                    identityEntity.Ditlindja = (DateTime)reader["ditelindja"];
                    identityEntity.Adresa = (string)reader["adresa"];
                    identityEntity.Gjinia = (string)reader["gjinia"];
                    identityEntity.Password = (string)reader["password"];
                    identityEntity.NrTelefonit = (string)reader["nrTelefonit"];
                }
               
                if (identityEntity.Id >0)
                {
                    Dashboard dashboard = new Dashboard(identityEntity);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter Username and password correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }
    }
}
