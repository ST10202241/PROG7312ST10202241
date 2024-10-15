using PROG7312ST10202241.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.IO;

namespace PROG7312ST10202241
{
    public partial class NewReportIssuesForm : Form
    {
        private List<string> attachedFiles = new List<string>();
        private const int MaxFiles = 5;  // Max file limit
        private bool locationEntered = false;
        private bool categorySelected = false;
        private bool descriptionEntered = false;
        private bool mediaAttached = false;
        private const int TotalSteps = 4;
        private int currentStep = 0;
        private List<IssueReport> reportedIssues = new List<IssueReport>();
        private ResourceManager resourceManager;

        public NewReportIssuesForm()
        {
            InitializeComponent();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(Form1).Assembly);
            ApplyLocalization();
            SetupDragAndDrop();
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
        }

        private void SetupDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += Form_DragEnter;
            this.DragDrop += Form_DragDrop;
        }

        private void Form_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (attachedFiles.Count >= MaxFiles)
                {
                    string FileLimitMessage = resourceManager.GetString("FileLimitReached");
                    MessageBox.Show(FileLimitMessage);
                    return;
                }
                attachedFiles.Add(file);
                AttachedFilesListBox.Items.Add(Path.GetFileName(file));
            }

            if (!mediaAttached)
            {
                mediaAttached = true;
                currentStep += 1;
                UpdateProgress();
            }
        }

        private void AttachMediaBtn_Click_1(object sender, EventArgs e)
        {
            string AttachImageOrDocumentMessage = resourceManager.GetString("AttachImageOrDocument");
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = AttachImageOrDocumentMessage,
                Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|PDF Files (*.pdf)|*.pdf|All files (*.*)|*.*",
                Multiselect = true  // Allow multiple file selection
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    if (attachedFiles.Count >= MaxFiles)
                    {
                        string FileLimitMessage = resourceManager.GetString("FileLimitReached");
                        MessageBox.Show(FileLimitMessage);
                        return;
                    }
                    attachedFiles.Add(file);
                    AttachedFilesListBox.Items.Add(Path.GetFileName(file));
                }

                if (!mediaAttached)
                {
                    mediaAttached = true;
                    currentStep += 1;
                    UpdateProgress();
                }
            }
        }

        private void RemoveFileBtn_Click(object sender, EventArgs e)
        {
            if (AttachedFilesListBox.SelectedItem != null)
            {
                string selectedFile = AttachedFilesListBox.SelectedItem.ToString();
                attachedFiles.RemoveAll(file => Path.GetFileName(file) == selectedFile);
                AttachedFilesListBox.Items.Remove(AttachedFilesListBox.SelectedItem);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string location = locationTxt.Text;
            string category = CategoryLBox.SelectedItem?.ToString();
            string description = DescriptionRTxt.Text;

            if (string.IsNullOrEmpty(location))
            {
                string PleaseEnterALocationMessage = resourceManager.GetString("PleaseEnterALocation");
                MessageBox.Show(PleaseEnterALocationMessage);
                return;
            }
            if (string.IsNullOrEmpty(category))
            {
                string PleaseEnterACategoryMessage = resourceManager.GetString("PleaseEnterACategory");
                MessageBox.Show(PleaseEnterACategoryMessage);
                return;
            }
            if (string.IsNullOrEmpty(description))
            {
                string PleaseEnterADescriptionMessage = resourceManager.GetString("PleaseEnterADescription");
                MessageBox.Show(PleaseEnterADescriptionMessage);
                return;
            }

            //IssueReport newIssue = new IssueReport(location, category, description, attachedFiles);
           // reportedIssues.Add(newIssue);

            string IssueReportedSuccessfullyMessage = resourceManager.GetString("IssueReportedSuccessfully");
            MessageBox.Show(IssueReportedSuccessfullyMessage);

            ClearForm();
            ResetProgress();
        }

        private void ClearForm()
        {
            locationTxt.Clear();
            CategoryLBox.ClearSelected();
            DescriptionRTxt.Clear();
            attachedFiles.Clear();
            AttachedFilesListBox.Items.Clear();
        }

        private void ResetProgress()
        {
            currentStep = 0;
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            progressBar.Value = currentStep;
            progressBar.Refresh();
        }

        private void locationTxt_TextChanged(object sender, EventArgs e)
        {
            if (!locationEntered)
            {
                locationEntered = true;
                currentStep += 1;
                UpdateProgress();
            }
        }

        private void CategoryLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!categorySelected)
            {
                categorySelected = true;
                currentStep += 1;
                UpdateProgress();
            }
        }

        private void DescriptionRTxt_TextChanged(object sender, EventArgs e)
        {
            if (!descriptionEntered)
            {
                descriptionEntered = true;
                currentStep += 1;
                UpdateProgress();
            }
        }

        private void ViewReportsFormBtn_Click(object sender, EventArgs e)
        {
            ViewReportsForm viewReportsForm = new ViewReportsForm(reportedIssues);
            viewReportsForm.Show();
        }
    }
}