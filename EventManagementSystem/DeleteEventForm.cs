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
    public partial class DeleteEventForm : Form
    {
        private string connectionString = "Data Source=ALEENA;Initial Catalog=EventManagement;Integrated Security=True";

        public DeleteEventForm()
        {
            InitializeComponent();
        }

        private void DeleteEventForm_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            string eventId = delEventId.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Events WHERE EventId = @EventId";


                    SqlCommand command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@EventId", eventId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Event deleted successfully!");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete event!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ClearFields()
        {
            delEventId.Text = "";
        }
    }
}
