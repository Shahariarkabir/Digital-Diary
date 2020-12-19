using DIgital_Diary.BusinessLayer;
using DIgital_Diary.DesignInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIgital_Diary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Username or password can not be empty");
            }
            else
            {
                UserService userService = new UserService();
                bool result = userService.LoginValidation(UserNameTextBox.Text, PasswordTextBox.Text);
                if (result)
                {
                    Dashboard dashBoard = new Dashboard();
                    dashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or password");
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();


                }
            }


        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            {
                RegistrationForm registerUser = new RegistrationForm();
                registerUser.Show();
                this.Hide();

            }

        }
    }
}
