using LoginApp.Entities;
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
    public partial class Dashboard : Form
    {
       // public static string conString = "Data Source=DESKTOP-2FODQJ3;Initial Catalog=LoginDb;Integrated Security=True;TrustServerCertificate=True";
        private IdentityEntity identityEntity;
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(IdentityEntity identityEntity)
        {
            InitializeComponent();
            this.identityEntity = identityEntity;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome {identityEntity.Emri}";
            txtEmri.Text = identityEntity.Emri;
            txtMbiemri.Text = identityEntity.Mbiemri;
            txtEmail.Text = identityEntity.Email;
            txtTelefoni.Text = identityEntity.NrTelefonit;
            datePicDitlindja.Value = identityEntity.Ditlindja;
            txtAdresa.Text = identityEntity.Adresa;
            cmbGjinia.Text = identityEntity.Gjinia;
            SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConString);
            String query = " Select emri from [products]";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            command.CommandType = CommandType.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string productName = reader.GetString(0);
                listBoxProducts.Items.Add(productName);
            }
            sqlConnection.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConString);
                String query = " UPDATE [Identity] Set emri = '" + txtEmri.Text.Trim() + "',  mbiemri = '" + txtMbiemri.Text.Trim() + "', nrTelefonit = '" + txtTelefoni.Text.Trim() + "'," +
                    " email = '" + txtEmail.Text.Trim() + "', ditelindja = '" + datePicDitlindja.Text.Trim() + "', gjinia = '" + cmbGjinia.Text.Trim() + "',  adresa = '" + txtAdresa.Text.Trim() + "'" +
                    "Where id = " + identityEntity.Id + "";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Succesfully updated profile", "Profile update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text.Trim() != identityEntity.Password)
            {

                MessageBox.Show("You must write the old password correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPass.Focus();

            }
            else if (txtNewPass.Text.Trim() != txtRePass.Text.Trim())
            {
                MessageBox.Show("Must match Passwords!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRePass.Focus();
            }
            else
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConString);
                    String query = " UPDATE [Identity] Set password = '" + txtNewPass.Text.Trim() + "' Where id = " + identityEntity.Id + "";
                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Succesfully updated password", "Password update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex != -1)
            {
                string selectedProduct = listBoxProducts.SelectedItem.ToString();
                listShopingCart.Items.Add(selectedProduct);
            }
        }

        private void tabProducts_Click(object sender, EventArgs e)
        {

        }

        private void listShopingCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listShopingCart.SelectedIndex != -1)
            {
                listShopingCart.Items.RemoveAt(listShopingCart.SelectedIndex);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            List<ProductEntity> products = new List<ProductEntity>();
            foreach(var product in listShopingCart.Items)
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.ConString);
                String query = "Select * from [products] where emri ='" + product + "'";
                SqlCommand cmd = new SqlCommand(query, sql);
                sql.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    ProductEntity productEntity = new ProductEntity();
                    productEntity.Id = reader.GetInt32("id");
                    productEntity.emri = (string)reader["emri"];
                    productEntity.qmimi = Convert.ToSingle(reader["qmimi"]);
                    products.Add(productEntity);
                }
              
            }
            Invoice invoice = new Invoice(products,identityEntity);
            invoice.Show();
            this.Hide();
        }
    }
}
