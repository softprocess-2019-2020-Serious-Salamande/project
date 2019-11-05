using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prototype
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void saveB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTB.Text))
            {
                MessageBox.Show("First Name field is empty");
            }
            else if (string.IsNullOrEmpty(middleNameTB.Text))
            {
                MessageBox.Show("Middle Name field is empty");
            }
            else if (string.IsNullOrEmpty(lastNameTB.Text))
            {
                MessageBox.Show("Last Name field is empty");
            }
            else if (string.IsNullOrEmpty(countryTB.Text))
            {
                MessageBox.Show("Country field is empty");
            }
            else if (string.IsNullOrEmpty(universityTB.Text))
            {
                MessageBox.Show("University field is empty");
            }
            else if (string.IsNullOrEmpty(facultyNumberTB.Text))
            {
                MessageBox.Show("Faculty Number field is empty");
            }
            else
            {
                firstNameTB.Text = "";
                middleNameTB.Text = "";
                lastNameTB.Text = "";
                countryTB.Text = "";
                universityTB.Text = "";
                facultyNumberTB.Text = "";
                MessageBox.Show("The student is added successfully");
            }
        }

        private void cancelB_Click(object sender, EventArgs e)
        {

            firstNameTB.Text = "";
            middleNameTB.Text = "";
            lastNameTB.Text = "";
            countryTB.Text = "";
            universityTB.Text = "";
            facultyNumberTB.Text = "";
        }
    }
}
