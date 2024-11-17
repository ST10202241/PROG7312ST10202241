﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    // Form to manage and display service requests
    public partial class ServiceRequestGraphForm : Form
    {
        private ServiceRequestBST serviceRequestTree;

        public ServiceRequestGraphForm(ServiceRequestBST tree)
        {
            InitializeComponent();
            this.serviceRequestTree = tree;
            LoadServiceRequests();
        }

        // Load and display service requests in a DataGridView
        private void LoadServiceRequests()
        {
            var requests = serviceRequestTree.InOrderTraversal();
            dataGridViewRequests.DataSource = requests.Select(r => new
            {
                r.RequestId,
                r.Location,
                r.Category,
                r.Description,
                r.Status,
                r.SubmittedDate
            }).ToList();
        }

        // Search for a service request by ID
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var request = serviceRequestTree.Search(id);
                if (request != null)
                {
                    MessageBox.Show($"Request ID: {request.RequestId}\nLocation: {request.Location}\nCategory: {request.Category}\nStatus: {request.Status}",
                        "Service Request Found");
                }
                else
                {
                    MessageBox.Show("Service Request not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.", "Input Error");
            }
        }

        // Update the status of a service request
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchId.Text, out int id))
            {
                var request = serviceRequestTree.Search(id);
                if (request != null)
                {
                    request.Status = txtNewStatus.Text;
                    LoadServiceRequests(); // Refresh the DataGridView
                    MessageBox.Show("Status updated successfully.", "Success");
                }
                else
                {
                    MessageBox.Show("Service Request not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.", "Input Error");
            }
        }

        private void ServiceRequestGraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
