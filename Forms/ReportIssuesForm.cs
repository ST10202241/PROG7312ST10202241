using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace PROG7312ST10202241
{
    public partial class ReportIssuesForm : Form
    {
        private bool locationEntered = false;
        private bool categorySelected = false;
        private bool descriptionEntered = false;
        private bool mediaAttached = false;
        private const int TotalSteps = 4;
        private int currentStep = 0;
        // List to store all the reported issues
        private List<IssueReport> reportedIssues = new List<IssueReport>();
        private string attachedMediaPath = string.Empty; // To store the path of the attached media

        private ResourceManager resourceManager;

        public ReportIssuesForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(Form1).Assembly);
            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("ReportIssuesTitle");
            SubmitBtn.Text = resourceManager.GetString("SubmitBtn");
            AttachMediaBtn.Text = resourceManager.GetString("AttachMediaBtn");
            locationLbl.Text = resourceManager.GetString("locationLbl");
            CategoryLbl.Text = resourceManager.GetString("CategoryLbl");
            descriptionLbl.Text = resourceManager.GetString("descriptionLbl");
            ViewReportsFormBtn.Text = resourceManager.GetString("ViewReportsFormBtn");
            closeBtn.Text = resourceManager.GetString("closeBtn");
            // Other controls
        }

        public void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            // Reapply localization
            ApplyLocalization();
            UpdateCategoryLBox(); // Update categories with new culture
        }

        // Form load event to populate the CategoryLBox with the specified categories
        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Initialize the progress bar
            progressBar.Maximum = TotalSteps;
            progressBar.Value = 0;
            progressBar.Step = 1;
            
            CategoryLBox.Items.Clear(); // Clear existing items

            // Retrieve localized category names from resource manager
            CategoryLBox.Items.Add(resourceManager.GetString("CategorySanitation"));
            CategoryLBox.Items.Add(resourceManager.GetString("CategoryRoads"));
            CategoryLBox.Items.Add(resourceManager.GetString("CategoryUtilities"));
            UpdateProgress();
        }
        private void UpdateProgress()
        {
            // Update progress bar value based on the current step
            progressBar.Value = currentStep;
            progressBar.Refresh();
        }
        private void ReportIssuesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            ReportIssuesForm formy = new ReportIssuesForm();
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
            formy.Close();
        }
        private void UpdateCategoryLBox()
        {
            CategoryLBox.Items.Clear();

            // Retrieve localized category names from resource manager
            CategoryLBox.Items.Add(resourceManager.GetString("CategorySanitation"));
            CategoryLBox.Items.Add(resourceManager.GetString("CategoryRoads"));
            CategoryLBox.Items.Add(resourceManager.GetString("CategoryUtilities"));
        }
        
        private void AttachMediaBtn_Click_1(object sender, EventArgs e)
        {
            string AttachImageOrDocumentMessage = resourceManager.GetString("AttachImageOrDocument");

            
            // Open a file dialog for the user to select a media file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = AttachImageOrDocumentMessage;
            //openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachedMediaPath = openFileDialog.FileName; // Store the full file path
                System.Windows.Forms.MessageBox.Show("Attachment: " + Path.GetFileName(attachedMediaPath)); // Display the file name
            }
            else
            {
                attachedMediaPath = string.Empty; // Clear if no file is selected
                string Nofileselectedmessage = resourceManager.GetString("Nofileselected");
                System.Windows.Forms.MessageBox.Show(Nofileselectedmessage);
            }
            if (!mediaAttached)
            {
                mediaAttached = true;
                currentStep += 1;
                UpdateProgress();
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // Collect the data from the form
            string location = locationTxt.Text;
            string category = CategoryLBox.SelectedItem?.ToString(); // Ensure a selection was made
            string description = DescriptionRTxt.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(location))
            {
                string PleaseEnterALocationMessage = resourceManager.GetString("PleaseEnterALocation");
                System.Windows.Forms.MessageBox.Show(PleaseEnterALocationMessage);
                return;
            }
            if (string.IsNullOrEmpty(category))
            {
                string PleaseEnterACategoryMessage = resourceManager.GetString("PleaseEnterACategory");

                System.Windows.Forms.MessageBox.Show(PleaseEnterACategoryMessage);
                return;
            }
            if (string.IsNullOrEmpty(description))
            {
                string PleaseEnterADescriptionMessage = resourceManager.GetString("PleaseEnterADescription");

                System.Windows.Forms.MessageBox.Show(PleaseEnterADescriptionMessage);
                return;
            }

            // Create a new issue report and add it to the list
            IssueReport newIssue = new IssueReport(location, category, description, attachedMediaPath);
            reportedIssues.Add(newIssue);

            // Show success message
            string IssueReportedSuccessfullyMessage = resourceManager.GetString("IssueReportedSuccessfully");

            System.Windows.Forms.MessageBox.Show(IssueReportedSuccessfullyMessage);

            // Optionally, clear the form after submission
            ClearForm();
            ResetProgress();
        }
        private void ResetProgress()
        {
            // Reset the ProgressBar
            currentStep = 0;
            UpdateProgress();
        }

        // Helper method to clear the form after submission
        private void ClearForm()
        {
            locationTxt.Clear();
            CategoryLBox.ClearSelected();
            DescriptionRTxt.Clear();
            attachedMediaPath = string.Empty;
        }

        private void backlbl_Click(object sender, EventArgs e)
        {
            ReportIssuesForm formy = new ReportIssuesForm();
            Form1 Form = new Form1();
            Form.Show();
            this.Hide();
            formy.Close();
        }

        private void ViewReportsFormBtn_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReportsForm = new ViewReportsForm(reportedIssues);
            viewReportsForm.Show();
        }

        private void locationTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!locationEntered)
            {
                locationEntered = true;
                currentStep += 1;
                UpdateProgress();
            }
        }

        private void CategoryLBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!categorySelected)
            {
                categorySelected = true;
                currentStep += 1;
                UpdateProgress();
            }
        }

        private void DescriptionRTxt_TextChanged_1(object sender, EventArgs e)
        {
            if (!descriptionEntered)
            {
                descriptionEntered = true;
                currentStep += 1;
                UpdateProgress();
            }
        }
    }
}