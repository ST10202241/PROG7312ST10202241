using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312ST10202241.Forms
{
    public partial class EmployeeLoginForm : Form
    {
        private const string EmployeeUsername = "admin"; // Example username
        private const string EmployeePassword = "password123"; // Example password

        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate employee credentials
            if (txtUsername.Text == EmployeeUsername && txtPassword.Text == EmployeePassword)
            {
                MessageBox.Show("Login successful!", "Success");

                // Navigate to ServiceRequestGraphForm
                ServiceRequestGraphForm graphForm = new ServiceRequestGraphForm();
                graphForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Return to main menu or close
            Form1 mainMenu = new Form1();
            mainMenu.Show();
            this.Close();
        }

        private void EmployeeLoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}