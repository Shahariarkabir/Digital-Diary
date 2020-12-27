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
using DIgital_Diary.DesignInterface;
using FontAwesome.Sharp;

namespace DIgital_Diary
{
    public partial class Dashboard : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Dashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Digital_Diary"].ConnectionString);
        
        
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
               DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;


            }
        }
       private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
   
           
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
       
        }
        //Events
        //Reset

        private void btnAllNote_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

            CreateNote CreateNewNote = new CreateNote();
            CreateNewNote.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            About Aboutpage = new About();
            Aboutpage.Show();
            this.Hide();
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            Login LoginPage = new Login();
            LoginPage.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:MM:ss tt");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dIgital_DiaryDataSet2.New_Event' table. You can move, or remove it, as needed.
            this.new_EventTableAdapter.Fill(this.dIgital_DiaryDataSet2.New_Event);

        }

        private void PostNewEvent_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DataGridViewMain.Rows[e.RowIndex];
                    UpdateEventID.Text = row.Cells[0].Value.ToString();
                    UpdateEventTitle.Text = row.Cells[2].Value.ToString();
                    UpdateEventDescription.Text = row.Cells[3].Value.ToString();
                    UpdateMarkAsComboBox.Text = row.Cells[4].Value.ToString();
                    ModifyEventDate.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        private void UpdateNewEvent_Click(object sender, EventArgs e)
        {

           try
           {
                connection.Open();
   
               string sql = "UPDATE New_Event SET EventTitle=@EventTitle,EventDescription=@EventDescription,EventType=@EventType,ModifyDate=@ModifyDate where EventID= '" + UpdateEventID.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);

               command.Parameters.AddWithValue("@EventTitle", UpdateEventTitle.Text);
               command.Parameters.AddWithValue("@EventDescription", UpdateEventDescription.Text);
               command.Parameters.AddWithValue("@EventType", UpdateMarkAsComboBox.Text);
               command.Parameters.AddWithValue("@ModifyDate", ModifyEventDate.Text);
               command.ExecuteNonQuery();
                           connection.Close();
                           MessageBox.Show("Update Successfully","Updated",MessageBoxButtons.OK,MessageBoxIcon.Information);

                   GetValue();
                       } 
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }

       private void GetValue()
       {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                string sql = "Select * From New_Event";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader rdr = command.ExecuteReader();
                dt.Load(rdr);
                connection.Close();
                DataGridViewMain.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Deleted_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
              
                 string sql = "Delete from New_Event where EventID = '" + UpdateEventID.Text+"'";
                
                 SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Delete Successfully", "Deleted",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetValue();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                string sql = "Select * From New_Event where EventTitle Like'%"+Searchbox.Text+ "%'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                connection.Close();
                DataGridViewMain.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}


//or EventType Like '%" + Searchbox.Text + "%' or EventDescription Like '%" + Searchbox.Text + "%'


