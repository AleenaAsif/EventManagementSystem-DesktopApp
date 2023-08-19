namespace EventManagementSystem
{
    partial class Signup
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            textPhone = new TextBox();
            textEmail = new TextBox();
            createAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.unnamed__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(220, 100);
            label1.Name = "label1";
            label1.Padding = new Padding(2);
            label1.Size = new Size(144, 25);
            label1.TabIndex = 1;
            label1.Text = "Create Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(219, 156);
            label2.Name = "label2";
            label2.Padding = new Padding(2);
            label2.Size = new Size(139, 25);
            label2.TabIndex = 2;
            label2.Text = "Create Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(220, 215);
            label3.Name = "label3";
            label3.Padding = new Padding(2);
            label3.Size = new Size(138, 25);
            label3.TabIndex = 3;
            label3.Text = "Enter Phone No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(219, 266);
            label4.Name = "label4";
            label4.Padding = new Padding(2);
            label4.Size = new Size(165, 25);
            label4.TabIndex = 4;
            label4.Text = "Enter Email Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(363, 31);
            label5.Name = "label5";
            label5.Padding = new Padding(4);
            label5.Size = new Size(111, 40);
            label5.TabIndex = 5;
            label5.Text = "Sign Up";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(453, 102);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(151, 23);
            textUsername.TabIndex = 6;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(453, 158);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(151, 23);
            textPassword.TabIndex = 7;
            textPassword.TabStop = false;
            textPassword.UseSystemPasswordChar = true;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(453, 217);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(151, 23);
            textPhone.TabIndex = 8;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(453, 268);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(184, 23);
            textEmail.TabIndex = 9;
            // 
            // createAccount
            // 
            createAccount.BackColor = Color.DarkSalmon;
            createAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            createAccount.Location = new Point(326, 328);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(183, 46);
            createAccount.TabIndex = 10;
            createAccount.Text = "Create Account";
            createAccount.UseVisualStyleBackColor = false;
            createAccount.Click += button1_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 423);
            Controls.Add(createAccount);
            Controls.Add(textEmail);
            Controls.Add(textPhone);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Signup";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textUsername;
        private TextBox textPassword;
        private TextBox textPhone;
        private TextBox textEmail;
        private Button createAccount;
    }
}