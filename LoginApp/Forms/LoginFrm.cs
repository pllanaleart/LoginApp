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
        public static string conString = "Data Source=DESKTOP-2FODQJ3;Initial Catalog=LoginDb;Integrated Security=True;TrustServerCertificate=True";

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(conString);
                String query = "Select * from [Identity] where email ='" + txtUsername.Text.Trim() + "'and password='" + txtPassword.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, sql);
                sql.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                DataTable dt = new DataTable();
                if (dataTable.Rows.Count == 1)
                {
                    Dashboard dashboard = new Dashboard();
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

        }
    }
}
