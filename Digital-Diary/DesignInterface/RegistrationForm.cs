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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Digital_Diary"].ConnectionString);
            connection.Open();
            
            string sql = "INSERT INTO Create_User (Username,FullName,Password,Email,DateOfBirth,Gender) VALUES('" + RegUserName.Text + "','" + RegFullName.Text + "','"+RegPassword.Text + "','" + RegEmail.Text + "','" + RegDateOfBirthDate.Text + "','" + GenderButton.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            connection.Close();

                if (result > 0)
            {
                MessageBox.Show("User added successfully.");
                RegFullName.Text = RegUserName.Text = RegEmail.Text = RegPassword.Text = RegConfirmPassword.Text = GenderButton.Text= RegDateOfBirthDate.Text = string.Empty;
                 ;
                Login home = new Login();
                home.Show();
                this.Hide();

            }
            else
            {


                MessageBox.Show("Error in user adding.");



            }
        }

        private void RegConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            {
                
            }

        }

        private void RegConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            {
                if (this.RegConfirmPassword.Text != this.RegPassword.Text)
                {
                    this.errorProvider1.SetError(this.RegConfirmPassword, "Password and Confirm must be the same");
                    e.Cancel = true;
                    RegPassword.Clear();
                    RegConfirmPassword.Clear();
                }
                else
                {
                    this.errorProvider1.SetError(this.RegConfirmPassword, "");
                }
            }
        }
    }
}
