namespace LoginApp.Forms
{
    partial class ForgotCode
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
            btnContinue = new Button();
            groupBox1 = new GroupBox();
            lblSpam = new Label();
            label1 = new Label();
            txtCode = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(112, 131);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(94, 29);
            btnContinue.TabIndex = 0;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSpam);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(btnContinue);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 179);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Code";
            // 
            // lblSpam
            // 
            lblSpam.AutoSize = true;
            lblSpam.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblSpam.Location = new Point(56, 93);
            lblSpam.Name = "lblSpam";
            lblSpam.Size = new Size(202, 15);
            lblSpam.TabIndex = 3;
            lblSpam.Text = "Please also check spam in your email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 40);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 2;
            label1.Text = "Enter Code from email";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(45, 63);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(232, 27);
            txtCode.TabIndex = 1;
            // 
            // ForgotCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 199);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(360, 246);
            MinimumSize = new Size(360, 246);
            Name = "ForgotCode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgotCode";
            Load += ForgotCode_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnContinue;
        private GroupBox groupBox1;
        private Label lblSpam;
        private Label label1;
        private TextBox txtCode;
    }
}