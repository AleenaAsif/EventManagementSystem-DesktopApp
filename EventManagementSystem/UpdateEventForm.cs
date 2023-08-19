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
    public partial class UpdateEventForm : Form
    {
        private string connectionString = "Data Source=ALEENA;Initial Catalog=EventManagement;Integrated Security=True";
        public UpdateEventForm()
        {
            InitializeComponent();
            DisableFields();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string eventId = idupdate.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Events WHERE EventId = @EventId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventId", eventId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        nameupdate.Text = reader["EventName"].ToString();
                        categoryupdate.Text = reader["EventCategory"].ToString();
                        organizerupdate.Text = reader["Organizer"].ToString();
                        locationupdate.Text = reader["Location"].ToString();
                        timeupdate.Text = reader["Time"].ToString();
                        eventstatusupdate.Text = reader["EventStatus"].ToString();

                        EnableFields();
                    }
                    else
                    {
                        MessageBox.Show("Event not found!");
                        ClearFields();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            idupdate.Text = "";
            nameupdate.Text = "";
            categoryupdate.Text = "";
            organizerupdate.Text = "";
            locationupdate.Text = "";
            timeupdate.Text = "";
            eventstatusupdate.Text = "";
        }



        private void updateEventButton_Click(object sender, EventArgs e)
        {
            string eventId = idupdate.Text;
            string eventName = nameupdate.Text;
            string eventCategory = categoryupdate.Text;
            string organizer = organizerupdate.Text;
            string location = locationupdate.Text;
            string time = timeupdate.Text;
            string eventStatus = eventstatusupdate.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Events SET EventName = @EventName, EventCategory = @EventCategory, Organizer = @Organizer, Location = @Location, Time = @Time, EventStatus = @EventStatus WHERE EventId = @EventId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EventId", eventId);
                    command.Parameters.AddWithValue("@EventName", eventName);
                    command.Parameters.AddWithValue("@EventCategory", eventCategory);
                    command.Parameters.AddWithValue("@Organizer", organizer);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@Time", time);
                    command.Parameters.AddWithValue("@EventStatus", eventStatus);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Event updated successfully!");
                        ClearFields();
                        DisableFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update event!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void EnableFields()
        {
            nameupdate.Enabled = true;
            categoryupdate.Enabled = true;
            organizerupdate.Enabled = true;
            locationupdate.Enabled = true;
            timeupdate.Enabled = true;
            eventstatusupdate.Enabled = true;
            updateEventButton.Enabled = true;
        }

        private void DisableFields()
        {
            nameupdate.Enabled = false;
            categoryupdate.Enabled = false;
            organizerupdate.Enabled = false;
            locationupdate.Enabled = false;
            timeupdate.Enabled = false;
            eventstatusupdate.Enabled = false;
            updateEventButton.Enabled = false;
        }
    }

}

