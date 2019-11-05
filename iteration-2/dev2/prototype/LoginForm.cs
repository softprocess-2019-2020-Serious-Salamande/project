using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
               if (string.IsNullOrEmpty(userNameTB.Text))
            {
                MessageBox.Show("User name field is empty");
            }
               else if (string.IsNullOrEmpty(passwordTB.Text))
            {
                MessageBox.Show("Password field is empty");
            }
            else
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Hide();
                this.Close();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void userNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
