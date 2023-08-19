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

        public Login()
        {
            InitializeComponent();
        }
        private TextBox txtUsername;
        private TextBox txtpassword;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}