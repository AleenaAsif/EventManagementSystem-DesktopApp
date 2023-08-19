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
    public partial class ViewEventsForm : Form
    {
        private string connectionString = "Data Source=ALEENA;Initial Catalog=EventManagement;Integrated Security=True";
        public ViewEventsForm()
        {
            InitializeComponent();
        }

        private void ViewEventsForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void LoadEvents()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Events.*, AttendeesLists.AttendeeName " +
                                   "FROM Events LEFT JOIN AttendeesLists ON Events.EventId = AttendeesLists.EventId";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewEvents.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridViewEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
