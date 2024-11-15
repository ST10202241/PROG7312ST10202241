using PROG7312ST10202241.Forms;
using PROG7312ST10202241.Models;
using System;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace PROG7312ST10202241
{
    public partial class ServiceRequestStatementForm : Form
    {
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
            CultureInfo culture = new CultureInfo(cultureName);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            ApplyLocalization();
        }

        private void backToMainMenuBtn_Click(object sender, EventArgs e)
        {
            ServiceRequestStatementForm formy = new ServiceRequestStatementForm();
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
            formy.Close();
        }

        private void ServiceRequestStatementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                MessageBox.Show("Please enter a valid Request ID.");
            }
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            var newRequest = new ServiceRequest
            {
                RequestId = int.Parse(txtNewRequestId.Text),
                Status = txtNewStatus.Text,
                Description = txtNewDescription.Text,
                Priority = int.Parse(txtNewPriority.Text)
            };

            // Insert into BST and Priority Queue
            requestTree.Insert(newRequest); // Assuming Insert is a valid method for your BST
            priorityQueue.Enqueue(newRequest, newRequest.Priority);

            MessageBox.Show("Service request added successfully!");
        }
    }
}