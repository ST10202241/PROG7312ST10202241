using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class ServiceRequestStatementForm : Form
    {
        private ServiceRequestGraph requestGraph;
        private ServiceRequestBST requestTree = new ServiceRequestBST();
        private PriorityQueue<ServiceRequest, int> priorityQueue = new PriorityQueue<ServiceRequest, int>();
        private ResourceManager resourceManager;

        public ServiceRequestStatementForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(Form1).Assembly);
            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("ServiceRequestStatementTitle");
            button1.Text = resourceManager.GetString("BackToMainMenuBtn");
        }

        public void ChangeLanguage(string cultureName)
        {
            try
            {
                CultureInfo culture = new CultureInfo(cultureName);
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
                ApplyLocalization();
            }
            catch (CultureNotFoundException ex)
            {
                MessageBox.Show($"Error changing language: {ex.Message}");
            }
        }

        private void backToMainMenuBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating back: {ex.Message}");
            }
        }

        private void ServiceRequestStatementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtRequestId.Text, out int requestId))
                {
                    var request = requestTree.Search(requestId);
                    if (request != null)
                    {
                        lblStatus.Text = $"Request ID: {request.RequestId}, Status: {request.Status}, Priority: {request.Priority}";
                    }
                    else
                    {
                        MessageBox.Show("Service request not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Request ID (numeric).");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search: {ex.Message}");
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateNewRequestInputs(out int newRequestId, out int newPriority))
                {
                    var newRequest = new ServiceRequest
                    {
                        RequestId = newRequestId,
                        Status = txtNewStatus.Text.Trim(),
                        Description = txtNewDescription.Text.Trim(),
                        Priority = newPriority
                    };

                    requestTree.Insert(newRequest);
                    priorityQueue.Enqueue(newRequest, newRequest.Priority);

                    MessageBox.Show("Service request added successfully!");
                    ClearNewRequestInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the request: {ex.Message}");
            }
        }

        private bool ValidateNewRequestInputs(out int requestId, out int priority)
        {
            requestId = 0;
            priority = 0;

            if (!int.TryParse(txtNewRequestId.Text.Trim(), out requestId))
            {
                MessageBox.Show("Please enter a valid numeric Request ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNewStatus.Text))
            {
                MessageBox.Show("Status cannot be empty.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNewDescription.Text))
            {
                MessageBox.Show("Description cannot be empty.");
                return false;
            }

            if (!int.TryParse(txtNewPriority.Text.Trim(), out priority) || priority < 1 || priority > 5)
            {
                MessageBox.Show("Please enter a valid priority (1 to 5).");
                return false;
            }

            return true;
        }

        private void ClearNewRequestInputs()
        {
            txtNewRequestId.Clear();
            txtNewStatus.Clear();
            txtNewDescription.Clear();
            txtNewPriority.Clear();
        }

        private void btnOpenGraphForm_Click(object sender, EventArgs e)
        {
            var graphForm = new ServiceRequestGraphForm(requestGraph); // Pass the graph instance
            graphForm.Show();
        }
    }
}
