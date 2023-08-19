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
    public partial class actionPage : Form
    {
        public actionPage()
        {
            InitializeComponent();
        }
        private void viewbtn_Click(object sender, EventArgs e)
        {
            ViewEventsForm viewEventsForm = new ViewEventsForm();
            viewEventsForm.ShowDialog();
        }
        private void actionPage_Load(object sender, EventArgs e)
        {

        }



        private void addbtn_Click(object sender, EventArgs e)
        {
            AddEventForm addEventForm = new AddEventForm();
            addEventForm.ShowDialog();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            UpdateEventForm updateEventForm = new UpdateEventForm();
            updateEventForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteEventForm deleteEventForm = new DeleteEventForm();
            deleteEventForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
