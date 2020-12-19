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

namespace DIgital_Diary.DesignInterface
{
    public partial class CreateNote : Form
    {
        public CreateNote()
        {
            InitializeComponent();
        }

        private void PostNewEvent_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Digital_Diary"].ConnectionString);
            connection.Open();
            string sql = "INSERT INTO New_Events(EventTitle,EventDescription,EventType,EventDate) VALUES('" + EventTitle.Text + "','" + EventDescription.Text + "','" + MarkAsComboBox.Text + "'," + EventDate.Text + ")";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();
            if (result > 0)
            {
                MessageBox.Show("Event Added successfully.");
                EventTitle.Text = EventDescription.Text = MarkAsComboBox.Text = string.Empty;


            }
            else
            {


                MessageBox.Show("Something Error!.");



            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            EventDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void EventDate_Click(object sender, EventArgs e)
        {

        }
    }
}
