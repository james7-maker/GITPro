/*Visual Languages & Programming C#
  Project

 James Mukazika
   c18132521o
   BSIT 1.2

   Analogy Choga
      c18
     BSIT         */

//October 2019




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string pass = txtPassword.Text;

            if (name == "Admin" && pass == "1234")
            {
                Login f = new Login();
                f.Show();
                MessageBox.Show("Login Successful");

            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
