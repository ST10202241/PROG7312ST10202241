using PROG7312ST10202241.Forms;
using System;
using System.IO;
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

            serviceRequestTree = tree;

            foreach (var issue in ReportDataStorage.ReportedIssues)
            {
                // No need for TryParse as RequestID is already an int
                var serviceRequest = new ServiceRequest(
                    issue.RequestID,
                    issue.Location,
                    issue.Category,
                    issue.Description,
                    "Pending", // Default status
                    issue.ReportDate
                );
                serviceRequestTree.Insert(serviceRequest);
            }

            LoadServiceRequests(); // Populate DataGridView
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
                    MessageBox.Show($"Service Request with ID {id} not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Input Error");
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
                    request.Status = txtNewStatus.Text; // Update the status
                    LoadServiceRequests(); // Refresh the DataGridView to reflect the change
                    MessageBox.Show($"Status for Request ID {id} updated to '{txtNewStatus.Text}'.", "Success");
                }
                else
                {
                    MessageBox.Show($"Service Request with ID {id} not found.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Input Error");
            }
        }


        private void ServiceRequestGraphForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ServiceRequestBST tree = new ServiceRequestBST();
            ServiceRequestGraphForm formy = new ServiceRequestGraphForm(tree);
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
            formy.Close();
        }
    }
}
