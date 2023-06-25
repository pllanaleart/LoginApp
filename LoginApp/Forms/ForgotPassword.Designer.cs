namespace LoginApp.Forms
{
    partial class ForgotPassword
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
            groupBox1 = new GroupBox();
            btnClose = new Button();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnContinue = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(btnContinue);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reset Password";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(141, 105);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(93, 35);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(88, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Enter email ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 60);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 27);
            txtEmail.TabIndex = 1;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(26, 105);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(94, 29);
            btnContinue.TabIndex = 0;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 163);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(308, 210);
            MinimumSize = new Size(308, 210);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotPassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnContinue;
        private Button btnClose;
    }
}