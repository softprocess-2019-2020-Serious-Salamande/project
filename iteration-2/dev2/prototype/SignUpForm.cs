using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prototype
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            countryTB.Text = "";
            userNameTB.Text = "";
            passwordTB.Text = "";
            rePasswordTB.Text = "";
        }

        private void signUpB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTB.Text))
            {
                MessageBox.Show("First Name field is empty");
            }
            else if (string.IsNullOrEmpty(lastNameTB.Text))
            {
                MessageBox.Show("Last Name field is empty");
            }
            else if (string.IsNullOrEmpty(countryTB.Text))
            {
                MessageBox.Show("Country field is empty");
            }
            else if (string.IsNullOrEmpty(userNameTB.Text))
            {
                MessageBox.Show("User Name field is empty");
            }
            else if (string.IsNullOrEmpty(passwordTB.Text))
            {
                MessageBox.Show("Password field is empty");
            }
            else if (string.IsNullOrEmpty(rePasswordTB.Text))
            {
                MessageBox.Show("Re-Password field is empty");
            }
            else if (rePasswordTB.Text!=passwordTB.Text)
            {
                MessageBox.Show("Re-Password and password are different!");
            }
            else
            {
                firstNameTB.Text = "";
                lastNameTB.Text = "";
                countryTB.Text = "";
                userNameTB.Text = "";
                passwordTB.Text = "";
                rePasswordTB.Text = "";
                MessageBox.Show("You have successfully registered!");

                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Hide();
                this.Close();

            }
        }
    }
}
