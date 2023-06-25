using LoginApp.Entities;
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
    public partial class Invoice : Form
    {
        List<ProductEntity> products;
        IdentityEntity identityEntity;
        public Invoice(List<ProductEntity> products, IdentityEntity identity)
        {
            InitializeComponent();
            this.identityEntity = identity;
            this.products = products;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            float total = 0;
            foreach (ProductEntity product in products)
            {
                total += product.qmimi;
                dataGridView1.Rows.Add(product.emri, product.qmimi);
            }
            lblPrice.Text = total.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(identityEntity);
            dashboard.Show();
            this.Hide();

        }
    }
}
