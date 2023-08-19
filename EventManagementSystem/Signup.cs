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
    public partial class Signup : Form
    {
        private SqlConnection con;
        public Signup()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=ALEENA;Initial Catalog=EventManagement;Integrated Security=True");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string Email = textEmail.Text;

            if (EmailExists(Email))
            {
                MessageBox.Show("This email already exists.");
                con.Close();
                return;
            }

            SqlCommand cmd = new SqlCommand("insert into Users values( @Username, @Password, @Phone, @Email)", con);

            cmd.Parameters.AddWithValue("@Username", textUsername.Text);
            cmd.Parameters.AddWithValue("@Password", textPassword.Text);
            cmd.Parameters.AddWithValue("@Phone", textPhone.Text);
            cmd.Parameters.AddWithValue("@Email", textEmail.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            actionPage obj = new actionPage();
            obj.Show();
            this.Hide();

        }
        private bool EmailExists(string Email)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @Email", con);
            command.Parameters.AddWithValue("@Email", Email);
            int count = (int)command.ExecuteScalar();

            return count > 0;

        }

    }


}





//private void textBox4_TextChanged(object sender, EventArgs e)
//{

//}

//private void label5_Click(object sender, EventArgs e)
//{

//}

//private void label2_Click(object sender, EventArgs e)
//{

//}

//private void textBox2_TextChanged(object sender, EventArgs e)
//{

//}

//private void label4_Click(object sender, EventArgs e)
//{

//}
