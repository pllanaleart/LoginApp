namespace LoginApp.Forms
{
    partial class Register
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
            btnRegister = new Button();
            txtEmri = new TextBox();
            txtMbiemri = new TextBox();
            txtTelefoni = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtAdresa = new TextBox();
            txtRePass = new TextBox();
            lblEmri = new Label();
            lblMbiemri = new Label();
            lblTelefoni = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblRePass = new Label();
            lblAdresa = new Label();
            datePicDitlindja = new DateTimePicker();
            lblDitlindja = new Label();
            cmbGjinia = new ComboBox();
            groupBoxRegister = new GroupBox();
            btnClose = new Button();
            lblGjinia = new Label();
            groupBoxRegister.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(411, 319);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(159, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEmri
            // 
            txtEmri.Location = new Point(39, 56);
            txtEmri.Name = "txtEmri";
            txtEmri.Size = new Size(219, 27);
            txtEmri.TabIndex = 1;
            // 
            // txtMbiemri
            // 
            txtMbiemri.Location = new Point(39, 121);
            txtMbiemri.Name = "txtMbiemri";
            txtMbiemri.Size = new Size(219, 27);
            txtMbiemri.TabIndex = 2;
            // 
            // txtTelefoni
            // 
            txtTelefoni.Location = new Point(39, 182);
            txtTelefoni.Name = "txtTelefoni";
            txtTelefoni.Size = new Size(219, 27);
            txtTelefoni.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(39, 242);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(39, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(377, 121);
            txtAdresa.Multiline = true;
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(217, 84);
            txtAdresa.TabIndex = 6;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(39, 367);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(219, 27);
            txtRePass.TabIndex = 6;
            // 
            // lblEmri
            // 
            lblEmri.AutoSize = true;
            lblEmri.Location = new Point(39, 33);
            lblEmri.Name = "lblEmri";
            lblEmri.Size = new Size(39, 20);
            lblEmri.TabIndex = 7;
            lblEmri.Text = "Emri";
            lblEmri.Click += label1_Click;
            // 
            // lblMbiemri
            // 
            lblMbiemri.AutoSize = true;
            lblMbiemri.Location = new Point(39, 98);
            lblMbiemri.Name = "lblMbiemri";
            lblMbiemri.Size = new Size(65, 20);
            lblMbiemri.TabIndex = 8;
            lblMbiemri.Text = "Mbiemri";
            // 
            // lblTelefoni
            // 
            lblTelefoni.AutoSize = true;
            lblTelefoni.Location = new Point(39, 158);
            lblTelefoni.Name = "lblTelefoni";
            lblTelefoni.Size = new Size(85, 20);
            lblTelefoni.TabIndex = 9;
            lblTelefoni.Text = "Nr telefonit";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(39, 219);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(39, 277);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
            // 
            // lblRePass
            // 
            lblRePass.AutoSize = true;
            lblRePass.Location = new Point(39, 344);
            lblRePass.Name = "lblRePass";
            lblRePass.Size = new Size(123, 20);
            lblRePass.TabIndex = 12;
            lblRePass.Text = "Repeat password";
            // 
            // lblAdresa
            // 
            lblAdresa.AutoSize = true;
            lblAdresa.Location = new Point(377, 98);
            lblAdresa.Name = "lblAdresa";
            lblAdresa.Size = new Size(55, 20);
            lblAdresa.TabIndex = 13;
            lblAdresa.Text = "Adresa";
            // 
            // datePicDitlindja
            // 
            datePicDitlindja.Format = DateTimePickerFormat.Short;
            datePicDitlindja.Location = new Point(377, 56);
            datePicDitlindja.Name = "datePicDitlindja";
            datePicDitlindja.Size = new Size(152, 27);
            datePicDitlindja.TabIndex = 14;
            // 
            // lblDitlindja
            // 
            lblDitlindja.AutoSize = true;
            lblDitlindja.Location = new Point(377, 33);
            lblDitlindja.Name = "lblDitlindja";
            lblDitlindja.Size = new Size(74, 20);
            lblDitlindja.TabIndex = 15;
            lblDitlindja.Text = "Ditelindja";
            // 
            // cmbGjinia
            // 
            cmbGjinia.FormattingEnabled = true;
            cmbGjinia.Items.AddRange(new object[] { "M", "F" });
            cmbGjinia.Location = new Point(378, 241);
            cmbGjinia.Name = "cmbGjinia";
            cmbGjinia.Size = new Size(151, 28);
            cmbGjinia.TabIndex = 16;
            // 
            // groupBoxRegister
            // 
            groupBoxRegister.Controls.Add(btnClose);
            groupBoxRegister.Controls.Add(lblGjinia);
            groupBoxRegister.Controls.Add(txtEmri);
            groupBoxRegister.Controls.Add(btnRegister);
            groupBoxRegister.Controls.Add(datePicDitlindja);
            groupBoxRegister.Controls.Add(lblDitlindja);
            groupBoxRegister.Controls.Add(cmbGjinia);
            groupBoxRegister.Controls.Add(txtMbiemri);
            groupBoxRegister.Controls.Add(txtTelefoni);
            groupBoxRegister.Controls.Add(txtEmail);
            groupBoxRegister.Controls.Add(lblAdresa);
            groupBoxRegister.Controls.Add(txtPassword);
            groupBoxRegister.Controls.Add(txtAdresa);
            groupBoxRegister.Controls.Add(lblRePass);
            groupBoxRegister.Controls.Add(txtRePass);
            groupBoxRegister.Controls.Add(lblPassword);
            groupBoxRegister.Controls.Add(lblEmri);
            groupBoxRegister.Controls.Add(lblEmail);
            groupBoxRegister.Controls.Add(lblMbiemri);
            groupBoxRegister.Controls.Add(lblTelefoni);
            groupBoxRegister.Location = new Point(-6, 4);
            groupBoxRegister.Name = "groupBoxRegister";
            groupBoxRegister.Size = new Size(658, 420);
            groupBoxRegister.TabIndex = 17;
            groupBoxRegister.TabStop = false;
            groupBoxRegister.Text = "Register:";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderColor = Color.Black;
            btnClose.Location = new Point(427, 367);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(125, 27);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblGjinia
            // 
            lblGjinia.AutoSize = true;
            lblGjinia.Location = new Point(378, 218);
            lblGjinia.Name = "lblGjinia";
            lblGjinia.Size = new Size(47, 20);
            lblGjinia.TabIndex = 17;
            lblGjinia.Text = "Gjinia";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 428);
            Controls.Add(groupBoxRegister);
            MaximizeBox = false;
            MaximumSize = new Size(677, 475);
            MinimumSize = new Size(677, 475);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            groupBoxRegister.ResumeLayout(false);
            groupBoxRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private TextBox txtEmri;
        private TextBox txtMbiemri;
        private TextBox txtTelefoni;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtAdresa;
        private TextBox txtRePass;
        private Label lblEmri;
        private Label lblMbiemri;
        private Label lblTelefoni;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblRePass;
        private Label lblAdresa;
        private DateTimePicker datePicDitlindja;
        private Label lblDitlindja;
        private ComboBox cmbGjinia;
        private GroupBox groupBoxRegister;
        private Label lblGjinia;
        private Button btnClose;
    }
}