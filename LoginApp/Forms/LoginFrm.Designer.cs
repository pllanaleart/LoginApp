namespace LoginApp.Forms
{
    partial class LoginFrm
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
            groupLogin = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            lblForgotPass = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            groupLogin.SuspendLayout();
            SuspendLayout();
            // 
            // groupLogin
            // 
            groupLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupLogin.Controls.Add(label5);
            groupLogin.Controls.Add(label4);
            groupLogin.Controls.Add(lblForgotPass);
            groupLogin.Controls.Add(txtPassword);
            groupLogin.Controls.Add(label2);
            groupLogin.Controls.Add(txtUsername);
            groupLogin.Controls.Add(label1);
            groupLogin.Controls.Add(btnLogin);
            groupLogin.Location = new Point(32, 16);
            groupLogin.Name = "groupLogin";
            groupLogin.Size = new Size(423, 249);
            groupLogin.TabIndex = 5;
            groupLogin.TabStop = false;
            groupLogin.Text = "Please Login";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(348, 219);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 8;
            label5.Text = "Register";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(204, 219);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 7;
            label4.Text = "Not registered yet?";
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.Cursor = Cursors.Hand;
            lblForgotPass.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblForgotPass.Location = new Point(120, 118);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(125, 20);
            lblForgotPass.TabIndex = 6;
            lblForgotPass.Text = "Forgot Password?";
            lblForgotPass.Click += lblForgotPass_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(226, 27);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 95);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(226, 27);
            txtUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 37);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            label1.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(165, 155);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(127, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(489, 279);
            Controls.Add(groupLogin);
            MaximizeBox = false;
            MaximumSize = new Size(507, 326);
            MinimumSize = new Size(507, 326);
            Name = "LoginFrm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFrm";
            Load += LoginFrm_Load;
            groupLogin.ResumeLayout(false);
            groupLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupLogin;
        private Label label5;
        private Label label4;
        private Label lblForgotPass;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private Label label1;
        private Button btnLogin;
    }
}