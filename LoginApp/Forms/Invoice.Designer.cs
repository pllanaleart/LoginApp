namespace LoginApp.Forms
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            label1 = new Label();
            lblPrice = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product, Price });
            dataGridView1.Location = new Point(14, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(304, 367);
            dataGridView1.TabIndex = 0;
            // 
            // Product
            // 
            Product.HeaderText = "Emri";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Qmimi";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 392);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 1;
            label1.Text = "Price";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(289, 400);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(0, 20);
            lblPrice.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(383, 391);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 437);
            Controls.Add(btnBack);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MaximumSize = new Size(552, 484);
            MinimumSize = new Size(552, 484);
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            Load += Invoice_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private Label label1;
        private Label lblPrice;
        private Button btnBack;
    }
}