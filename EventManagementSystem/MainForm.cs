using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class MainForm : Form
    {


        private void InitializeComponent()
        {
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            btnSignup = new Button();
            this.label3 = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
           
            btnLogin.BackColor = Color.DarkSalmon;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlText;
            btnLogin.Location = new Point(310, 131);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 64);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            
            pictureBox1.Image = Properties.Resources.unnamed__1_;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(742, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
          
            btnSignup.BackColor = Color.DarkSalmon;
            btnSignup.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.Location = new Point(310, 230);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(151, 68);
            btnSignup.TabIndex = 2;
            btnSignup.Text = "Signup";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
          
            this.label3.AutoSize = true;
            this.label3.BackColor = Color.FloralWhite;
            this.label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.label3.Location = new Point(198, 51);
            this.label3.Name = "label3";
            this.label3.Padding = new Padding(4);
            this.label3.Size = new Size(377, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = "EVENT MANAGEMENT SYSTEM";
           
            ClientSize = new Size(742, 414);
            Controls.Add(this.label3);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }



        private void btnSignup_Click(object sender, EventArgs e)
        {

            Signup signupForm = new Signup();
            signupForm.Show();
            this.Hide();
        }
    }
}
