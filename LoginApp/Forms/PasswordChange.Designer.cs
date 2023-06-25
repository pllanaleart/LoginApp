namespace LoginApp.Forms
{
    partial class PasswordChange
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
            groupChange = new GroupBox();
            btnClose = new Button();
            btnChange = new Button();
            label2 = new Label();
            label1 = new Label();
            txtRePass = new TextBox();
            txtNewPassword = new TextBox();
            groupChange.SuspendLayout();
            SuspendLayout();
            // 
            // groupChange
            // 
            groupChange.Controls.Add(btnClose);
            groupChange.Controls.Add(btnChange);
            groupChange.Controls.Add(label2);
            groupChange.Controls.Add(label1);
            groupChange.Controls.Add(txtRePass);
            groupChange.Controls.Add(txtNewPassword);
            groupChange.Location = new Point(12, 12);
            groupChange.Name = "groupChange";
            groupChange.Size = new Size(295, 255);
            groupChange.TabIndex = 0;
            groupChange.TabStop = false;
            groupChange.Text = "Change password:";
            groupChange.Enter += groupChange_Enter;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(163, 206);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(36, 206);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(94, 29);
            btnChange.TabIndex = 4;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 121);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 3;
            label2.Text = "Repeat password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 2;
            label1.Text = "New password";
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(20, 144);
            txtRePass.Name = "txtRePass";
            txtRePass.PasswordChar = '*';
            txtRePass.Size = new Size(246, 27);
            txtRePass.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(21, 68);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(245, 27);
            txtNewPassword.TabIndex = 0;
            // 
            // PasswordChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 278);
            Controls.Add(groupChange);
            MaximizeBox = false;
            MaximumSize = new Size(331, 325);
            MinimumSize = new Size(331, 325);
            Name = "PasswordChange";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PasswordChange";
            Load += PasswordChange_Load;
            groupChange.ResumeLayout(false);
            groupChange.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupChange;
        private Button btnClose;
        private Button btnChange;
        private Label label2;
        private Label label1;
        private TextBox txtRePass;
        private TextBox txtNewPassword;
    }
}