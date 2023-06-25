namespace LoginApp.Forms
{
    partial class Dashboard
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
            lblWelcome = new Label();
            tabControl1 = new TabControl();
            tabProducts = new TabPage();
            btnBuy = new Button();
            label5 = new Label();
            label4 = new Label();
            listShopingCart = new ListBox();
            listBoxProducts = new ListBox();
            tabPage1 = new TabPage();
            btnUpdate = new Button();
            lblGjinia = new Label();
            txtEmri = new TextBox();
            datePicDitlindja = new DateTimePicker();
            lblDitlindja = new Label();
            cmbGjinia = new ComboBox();
            txtMbiemri = new TextBox();
            txtTelefoni = new TextBox();
            txtEmail = new TextBox();
            lblAdresa = new Label();
            txtAdresa = new TextBox();
            lblEmri = new Label();
            lblEmail = new Label();
            lblMbiemri = new Label();
            lblTelefoni = new Label();
            tabPage2 = new TabPage();
            btnChange = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtRePass = new TextBox();
            txtNewPass = new TextBox();
            txtOldPass = new TextBox();
            tabControl1.SuspendLayout();
            tabProducts.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(27, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(50, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProducts);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(27, 70);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(761, 353);
            tabControl1.TabIndex = 1;
            // 
            // tabProducts
            // 
            tabProducts.Controls.Add(btnBuy);
            tabProducts.Controls.Add(label5);
            tabProducts.Controls.Add(label4);
            tabProducts.Controls.Add(listShopingCart);
            tabProducts.Controls.Add(listBoxProducts);
            tabProducts.Location = new Point(4, 29);
            tabProducts.Name = "tabProducts";
            tabProducts.Padding = new Padding(3);
            tabProducts.Size = new Size(753, 320);
            tabProducts.TabIndex = 2;
            tabProducts.Text = "Products";
            tabProducts.UseVisualStyleBackColor = true;
            tabProducts.Click += tabProducts_Click;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(616, 258);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(106, 29);
            btnBuy.TabIndex = 4;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 9);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 3;
            label5.Text = "Shopping Cart";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 12);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 2;
            label4.Text = "Products available";
            // 
            // listShopingCart
            // 
            listShopingCart.FormattingEnabled = true;
            listShopingCart.ItemHeight = 20;
            listShopingCart.Location = new Point(387, 32);
            listShopingCart.Name = "listShopingCart";
            listShopingCart.Size = new Size(191, 264);
            listShopingCart.TabIndex = 1;
            listShopingCart.SelectedIndexChanged += listShopingCart_SelectedIndexChanged;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.ItemHeight = 20;
            listBoxProducts.Location = new Point(65, 35);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(164, 264);
            listBoxProducts.TabIndex = 0;
            listBoxProducts.SelectedIndexChanged += tabProducts_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(lblGjinia);
            tabPage1.Controls.Add(txtEmri);
            tabPage1.Controls.Add(datePicDitlindja);
            tabPage1.Controls.Add(lblDitlindja);
            tabPage1.Controls.Add(cmbGjinia);
            tabPage1.Controls.Add(txtMbiemri);
            tabPage1.Controls.Add(txtTelefoni);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(lblAdresa);
            tabPage1.Controls.Add(txtAdresa);
            tabPage1.Controls.Add(lblEmri);
            tabPage1.Controls.Add(lblEmail);
            tabPage1.Controls.Add(lblMbiemri);
            tabPage1.Controls.Add(lblTelefoni);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(753, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "MyProfile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(616, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 29);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblGjinia
            // 
            lblGjinia.AutoSize = true;
            lblGjinia.Location = new Point(363, 224);
            lblGjinia.Name = "lblGjinia";
            lblGjinia.Size = new Size(47, 20);
            lblGjinia.TabIndex = 31;
            lblGjinia.Text = "Gjinia";
            // 
            // txtEmri
            // 
            txtEmri.Location = new Point(24, 62);
            txtEmri.Name = "txtEmri";
            txtEmri.Size = new Size(219, 27);
            txtEmri.TabIndex = 18;
            // 
            // datePicDitlindja
            // 
            datePicDitlindja.Format = DateTimePickerFormat.Short;
            datePicDitlindja.Location = new Point(362, 62);
            datePicDitlindja.Name = "datePicDitlindja";
            datePicDitlindja.Size = new Size(152, 27);
            datePicDitlindja.TabIndex = 28;
            // 
            // lblDitlindja
            // 
            lblDitlindja.AutoSize = true;
            lblDitlindja.Location = new Point(362, 39);
            lblDitlindja.Name = "lblDitlindja";
            lblDitlindja.Size = new Size(74, 20);
            lblDitlindja.TabIndex = 29;
            lblDitlindja.Text = "Ditelindja";
            // 
            // cmbGjinia
            // 
            cmbGjinia.FormattingEnabled = true;
            cmbGjinia.Items.AddRange(new object[] { "M", "F" });
            cmbGjinia.Location = new Point(363, 247);
            cmbGjinia.Name = "cmbGjinia";
            cmbGjinia.Size = new Size(151, 28);
            cmbGjinia.TabIndex = 30;
            // 
            // txtMbiemri
            // 
            txtMbiemri.Location = new Point(24, 127);
            txtMbiemri.Name = "txtMbiemri";
            txtMbiemri.Size = new Size(219, 27);
            txtMbiemri.TabIndex = 19;
            // 
            // txtTelefoni
            // 
            txtTelefoni.Location = new Point(24, 188);
            txtTelefoni.Name = "txtTelefoni";
            txtTelefoni.Size = new Size(219, 27);
            txtTelefoni.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(24, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 27);
            txtEmail.TabIndex = 21;
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(362, 104);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(55, 20);
            lblAdresa.TabIndex = 27;
            lblAdresa.Text = "Adresa";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(362, 127);
            txtAdresa.Multiline = true;
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(217, 84);
            txtAdresa.TabIndex = 22;
            // 
            // lblEmri
            // 
            lblEmri.AutoSize = true;
            lblEmri.Location = new Point(24, 39);
            lblEmri.Name = "lblEmri";
            lblEmri.Size = new Size(39, 20);
            lblEmri.TabIndex = 23;
            lblEmri.Text = "Emri";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(24, 225);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 26;
            lblEmail.Text = "Email";
            // 
            // lblMbiemri
            // 
            lblMbiemri.AutoSize = true;
            lblMbiemri.Location = new Point(24, 104);
            lblMbiemri.Name = "lblMbiemri";
            lblMbiemri.Size = new Size(65, 20);
            lblMbiemri.TabIndex = 24;
            lblMbiemri.Text = "Mbiemri";
            // 
            // lblTelefoni
            // 
            lblTelefoni.AutoSize = true;
            lblTelefoni.Location = new Point(24, 164);
            lblTelefoni.Name = "lblTelefoni";
            lblTelefoni.Size = new Size(85, 20);
            lblTelefoni.TabIndex = 25;
            lblTelefoni.Text = "Nr telefonit";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnChange);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtRePass);
            tabPage2.Controls.Add(txtNewPass);
            tabPage2.Controls.Add(txtOldPass);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(753, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Password Change";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(491, 264);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(192, 29);
            btnChange.TabIndex = 6;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 238);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Repeat Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 160);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "New Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 53);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 3;
            label1.Text = "Old Password";
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(54, 264);
            txtRePass.Name = "txtRePass";
            txtRePass.PasswordChar = '*';
            txtRePass.Size = new Size(309, 27);
            txtRePass.TabIndex = 2;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(53, 185);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(310, 27);
            txtNewPass.TabIndex = 1;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(54, 76);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '*';
            txtOldPass.Size = new Size(312, 27);
            txtOldPass.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(lblWelcome);
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            tabControl1.ResumeLayout(false);
            tabProducts.ResumeLayout(false);
            tabProducts.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private TabControl tabControl1;
        private TabPage tabProducts;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblGjinia;
        private TextBox txtEmri;
        private DateTimePicker datePicDitlindja;
        private Label lblDitlindja;
        private ComboBox cmbGjinia;
        private TextBox txtMbiemri;
        private TextBox txtTelefoni;
        private TextBox txtEmail;
        private Label lblAdresa;
        private TextBox txtAdresa;
        private Label lblEmri;
        private Label lblEmail;
        private Label lblMbiemri;
        private Label lblTelefoni;
        private Button btnUpdate;
        private Label label1;
        private TextBox txtRePass;
        private TextBox txtNewPass;
        private TextBox txtOldPass;
        private Button btnChange;
        private Label label3;
        private Label label2;
        private ListBox listBoxProducts;
        private Label label5;
        private Label label4;
        private ListBox listShopingCart;
        private Button btnBuy;
    }
}