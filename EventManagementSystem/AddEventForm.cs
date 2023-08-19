//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace EventManagementSystem
//{
//    public partial class AddEventForm : Form
//    {
//        private string connectionString = "Data Source=ALEENA;Initial Catalog=EventManagement;Integrated Security=True";
//        public AddEventForm()
//        {
//            InitializeComponent();


//        }

//        private void AddEventForm_Load(object sender, EventArgs e)
//        {

//        }
//        private void btnAddEvent_Click(object sender, EventArgs e)
//        {
//            string eventId = eventid.Text;
//            string eventName = eventname.Text;
//            string eventCategory = eventcategory.Text;
//            string Organizer = organizer.Text;
//            string Location = location.Text;
//            string Time = time.Text;
//            string EventStatus = eventstatus.Text;

//            try
//            {
//                using (SqlConnection connection = new SqlConnection(connectionString))
//                {
//                    connection.Open();

//                    // Insert the event details into the Events table
//                    string insertEventQuery = "INSERT INTO Events (EventId, EventName, EventCategory, Organizer, Location, Time, EventStatus) " +
//                                              "VALUES (@EventId, @EventName, @EventCategory, @Organizer, @Location, @Time, @EventStatus)";
//                    SqlCommand insertEventCommand = new SqlCommand(insertEventQuery, connection);
//                    insertEventCommand.Parameters.AddWithValue("@EventId", eventId);
//                    insertEventCommand.Parameters.AddWithValue("@EventName", eventName);
//                    insertEventCommand.Parameters.AddWithValue("@EventCategory", eventCategory);
//                    insertEventCommand.Parameters.AddWithValue("@Organizer", Organizer);
//                    insertEventCommand.Parameters.AddWithValue("@Location", Location);
//                    insertEventCommand.Parameters.AddWithValue("@Time", Time);
//                    insertEventCommand.Parameters.AddWithValue("@EventStatus", EventStatus);

//                    int rowsAffected = insertEventCommand.ExecuteNonQuery();

//                    if (rowsAffected > 0)
//                    {

//                        string attendeesText = AttendeesNames.Text;
//                        string[] attendees = attendeesText.Split(',');

//                        foreach (string attendee in attendees)
//                        {
//                            string insertAttendeeQuery = "INSERT INTO AttendeesLists (EventId, AttendeeName) VALUES (@EventId, @AttendeeName)";
//                            SqlCommand insertAttendeeCommand = new SqlCommand(insertAttendeeQuery, connection);
//                            insertAttendeeCommand.Parameters.AddWithValue("@EventId", eventId);
//                            insertAttendeeCommand.Parameters.AddWithValue("@AttendeeName", attendee.Trim());
//                            insertAttendeeCommand.ExecuteNonQuery();
//                        }

//                        MessageBox.Show("Event and attendees added successfully!");
//                        ClearFields();
//                    }
//                    else
//                    {
//                        MessageBox.Show("Failed to add event!");
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex.Message);
//            }
//        }





//        private void ClearFields()
//        {
//            eventid.Text = "";
//            eventname.Text = "";
//            eventcategory.Text = "";
//            organizer.Text = "";
//            location.Text = "";
//            time.Text = "";
//            eventstatus.Text = "";
//        }
//    }

//}


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
    public partial class AddEventForm : Form
    {
        private string connectionString = "Data Source=ALEENA;Initial Catalog=EventManagement;Integrated Security=True";
        public AddEventForm()
        {
            InitializeComponent();


        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string eventId = eventid.Text;
            string eventName = eventname.Text;
            string eventCategory = eventcategory.Text;
            string Organizer = organizer.Text;
            string Location = location.Text;
            string Time = time.Text;
            string EventStatus = eventstatus.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert the event details into the Events table
                    string insertEventQuery = "INSERT INTO Events (EventId, EventName, EventCategory, Organizer, Location, Time, EventStatus) " +
                                              "VALUES (@EventId, @EventName, @EventCategory, @Organizer, @Location, @Time, @EventStatus)";
                    SqlCommand insertEventCommand = new SqlCommand(insertEventQuery, connection);
                    insertEventCommand.Parameters.AddWithValue("@EventId", eventId);
                    insertEventCommand.Parameters.AddWithValue("@EventName", eventName);
                    insertEventCommand.Parameters.AddWithValue("@EventCategory", eventCategory);
                    insertEventCommand.Parameters.AddWithValue("@Organizer", Organizer);
                    insertEventCommand.Parameters.AddWithValue("@Location", Location);
                    insertEventCommand.Parameters.AddWithValue("@Time", Time);
                    insertEventCommand.Parameters.AddWithValue("@EventStatus", EventStatus);

                    int rowsAffected = insertEventCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        string[] attendees = AttendeesNames.Text.Split(',');

                        foreach (string attendee in attendees)
                        {
                            string insertAttendeeQuery = "INSERT INTO AttendeesLists (EventId, AttendeeName) VALUES (@EventId, @AttendeeName)";
                            SqlCommand insertAttendeeCommand = new SqlCommand(insertAttendeeQuery, connection);
                            insertAttendeeCommand.Parameters.AddWithValue("@EventId", eventId);
                            insertAttendeeCommand.Parameters.AddWithValue("@AttendeeName", attendee.Trim());
                            insertAttendeeCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Event and attendees added successfully!");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add event!");
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
            eventid.Text = "";
            eventname.Text = "";
            eventcategory.Text = "";
            organizer.Text = "";
            location.Text = "";
            time.Text = "";
            eventstatus.Text = "";
        }
    }

}


