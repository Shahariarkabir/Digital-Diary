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

            if (txtusername.Text == "kabir" && txtpassword.Text == "pass")
            {
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                txtpassword.Clear();

            }
        }
    }
}
