using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Login : Form
    {

        private string connectionString = "Data Source=ALEENA;Initial Catalog=EventManagement;Integrated Security=True";

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string password = txtpassword.Text;

            if (userExists(Username))
            {
                if (VerifyPassword(Username, password))
                {

                    actionPage obj = new actionPage();
                    obj.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect password!");
                }
            }
            else
            {
                MessageBox.Show("user doesn't exist!");
            }

        }

        private bool userExists(string Username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private bool VerifyPassword(string Username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND password = @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@password", password);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtpassword = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            
            txtUsername.Location = new Point(437, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(162, 23);
            txtUsername.TabIndex = 0;
           
            txtpassword.Location = new Point(437, 202);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(162, 23);
            txtpassword.TabIndex = 1;
            txtpassword.UseSystemPasswordChar = true;
           
            button1.BackColor = Color.DarkSalmon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(363, 266);
            button1.Name = "button1";
            button1.Size = new Size(123, 55);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
          
            pictureBox1.Image = Properties.Resources.unnamed__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(3);
            pictureBox1.Size = new Size(797, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
          
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(268, 140);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(137, 27);
            label1.TabIndex = 4;
            label1.Text = "Enter Username";
           
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(268, 200);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(132, 27);
            label2.TabIndex = 5;
            label2.Text = "Enter Password";
           
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(799, 446);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtpassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "Login";
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
