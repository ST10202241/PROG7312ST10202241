﻿using PROG7312ST10202241.Forms;
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
            locationSuggestionsListBox.SelectedIndexChanged += locationSuggestionsBox_SelectedIndexChanged;
            locationTxt.TextChanged += locationTxt_TextChanged;
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
            closeBtn.Text = resourceManager.GetString("BackToMainMenuBtn");
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
            ComboBox locationSuggestionsBox = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Visible = false,
                Width = locationTxt.Width,
                Left = locationTxt.Left,
                Top = locationTxt.Bottom + 5 // Position it under the TextBox
            };
            this.Controls.Add(locationSuggestionsBox);

            ListBox locationSuggestionsListBox = new ListBox
            {
                Visible = false,
                Width = locationTxt.Width,
                Height = 100, // Adjust height as needed
                Left = locationTxt.Left,
                Top = locationTxt.Bottom + 5 // Position it right below the TextBox
            };
            this.Controls.Add(locationSuggestionsListBox);

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

        private List<string> attachedMediaPaths = new List<string>();
        private void AttachMediaBtn_Click_1(object sender, EventArgs e)
        {
            string AttachImageOrDocumentMessage = resourceManager.GetString("AttachImageOrDocument");

            
            // Open a file dialog for the user to select a media file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = AttachImageOrDocumentMessage;
            //openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var filePath in openFileDialog.FileNames)
                {
                    if (!attachedMediaPaths.Contains(filePath)) // Avoid duplicate attachments
                    {
                        attachedMediaPaths.Add(filePath);
                        attachedFilesListBox.Items.Add(Path.GetFileName(filePath)); // Display only the file name in the ListBox
                    }
                }

                System.Windows.Forms.MessageBox.Show("Attachments Added: " + string.Join(", ", openFileDialog.FileNames));
            }
            else
            {
                string noFileSelectedMessage = resourceManager.GetString("Nofileselected");
                System.Windows.Forms.MessageBox.Show(noFileSelectedMessage);
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
            string location = locationTxt.Text;
            string category = CategoryLBox.SelectedItem?.ToString();
            string description = DescriptionRTxt.Text;

            if (string.IsNullOrEmpty(location))
            {
                System.Windows.MessageBox.Show("Please enter a location.");
                return;
            }
            if (string.IsNullOrEmpty(category))
            {
                System.Windows.MessageBox.Show("Please enter a category.");
                return;
            }
            if (string.IsNullOrEmpty(description))
            {
                System.Windows.MessageBox.Show("Please enter a description.");
                return;
            }
            if (attachedFilesListBox.Items.Count == 0)
            {
                System.Windows.MessageBox.Show("Please attach media.");
                return;
            }

            // Generate a random unique RequestID
            Random random = new Random();
            int requestId = random.Next(1, 100000); // Larger range to reduce collisions

            // Create and add the new issue
            IssueReport newIssue = new IssueReport(location, category, description, new List<string>(attachedMediaPaths), requestId);
            ReportDataStorage.ReportedIssues.Add(newIssue);

            System.Windows.MessageBox.Show("Issue reported successfully.");
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
            attachedFilesListBox.Items.Clear(); // Clear the ListBox
            previewPictureBox.Image = null; // Clear the PictureBox
            previewPictureBox.Visible = false; // Hide the PictureBox
            previewPanel.Visible = false; // Hide the preview panel
            attachedMediaPaths.Clear(); // Clear the list of attached file paths
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

        private async void locationTxt_TextChanged(object sender, EventArgs e)
        {
            string query = locationTxt.Text;
            if (query.Length < 3) // Avoid API calls for very short inputs
            {
                locationSuggestionsListBox.Visible = false;
                return;
            }

            var suggestions = await LocationSuggestionHelper.GetLocationSuggestionsAsync(query);

            if (suggestions.Count > 0)
            {
                locationSuggestionsListBox.Items.Clear();
                foreach (var suggestion in suggestions)
                {
                    locationSuggestionsListBox.Items.Add(suggestion.DisplayName);
                }

                locationSuggestionsListBox.Visible = true;
                locationSuggestionsListBox.BringToFront();
            }
            else
            {
                locationSuggestionsListBox.Visible = false;
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

        private void RemoveFileBtn_Click(object sender, EventArgs e)
        {
            if (attachedFilesListBox.SelectedItem != null)
            {
                string selectedFile = attachedFilesListBox.SelectedItem.ToString();

                // Find and remove the full file path from the list
                string filePathToRemove = attachedMediaPaths.FirstOrDefault(path => Path.GetFileName(path) == selectedFile);
                if (filePathToRemove != null)
                {
                    attachedMediaPaths.Remove(filePathToRemove);
                    attachedFilesListBox.Items.Remove(selectedFile); // Remove from the ListBox as well
                }

                System.Windows.Forms.MessageBox.Show($"Removed: {selectedFile}");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No file selected for removal.");
            }

            // Update progress if no files are attached
            if (attachedMediaPaths.Count == 0)
            {
                mediaAttached = false;
                currentStep -= 1;
                UpdateProgress();
            }
        }

        private void attachedFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attachedFilesListBox.SelectedItem != null)
            {
                string selectedFile = attachedFilesListBox.SelectedItem.ToString();
                string filePath = attachedMediaPaths.FirstOrDefault(path => Path.GetFileName(path) == selectedFile);

                if (!string.IsNullOrEmpty(filePath))
                {
                    // Check the file type based on extension
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
                    {
                        // Display the image in the PictureBox
                        previewPictureBox.Image = Image.FromFile(filePath);
                        previewPictureBox.Visible = true;
                        previewPanel.Visible = false; // Hide other previews
                    }
                    else if (extension == ".pdf")
                    {
                        // Handle PDF Preview (use a third-party library like Adobe Reader or PDF.js)
                        previewPictureBox.Visible = false;
                        previewPanel.Visible = true;
                        previewPanel.Controls.Clear();

                        Label pdfLabel = new Label
                        {
                            Text = "PDF preview not available in this demo.",
                            AutoSize = true,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        previewPanel.Controls.Add(pdfLabel);
                    }
                    else
                    {
                        // Handle other file types (e.g., videos or unsupported formats)
                        previewPictureBox.Visible = false;
                        previewPanel.Visible = true;
                        previewPanel.Controls.Clear();

                        Label unsupportedLabel = new Label
                        {
                            Text = "Preview not available for this file type.",
                            AutoSize = true,
                            TextAlign = ContentAlignment.MiddleCenter
                        };
                        previewPanel.Controls.Add(unsupportedLabel);
                    }
                }
            }
        }
        private void locationSuggestionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (locationSuggestionsListBox.SelectedItem != null)
            {
                locationTxt.Text = locationSuggestionsListBox.SelectedItem.ToString();
                locationSuggestionsListBox.Visible = false; // Hide after selection
            }
        }
    }
}
public static class ReportDataStorage
{
    public static List<IssueReport> ReportedIssues = new List<IssueReport>();
}
