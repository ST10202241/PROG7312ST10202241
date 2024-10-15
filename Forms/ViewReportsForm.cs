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
using System.Windows.Forms;

namespace PROG7312ST10202241.Forms
{
    public partial class ViewReportsForm : Form
    {
        private ResourceManager resourceManager;
        private List<IssueReport> issueReports;

        public ViewReportsForm(List<IssueReport> issueReports)
        {
            InitializeComponent();
            this.issueReports = issueReports ?? new List<IssueReport>();
            resourceManager = new ResourceManager("PROG7312ST10202241.Properties.Strings", typeof(Form1).Assembly);
            ApplyLocalization();
            PopulateDataGrid(this.issueReports);
        }

        private void ApplyLocalization()
        {
            this.Text = resourceManager.GetString("ViewReportsTitle");
        }
        public void ChangeLanguage(string cultureName)
        {
            CultureInfo culture = new CultureInfo(cultureName);
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            ApplyLocalization();
        }
        // Method to populate the DataGridView with the issue reports
        private void PopulateDataGrid(List<IssueReport> issueReports)
        {
            // Set up DataGridView columns
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Location";
            dataGridView1.Columns[1].Name = "Category";
            dataGridView1.Columns[2].Name = "Description";
            dataGridView1.Columns[3].Name = "Media";

            // Loop through the list and add rows to the DataGridView
            foreach (var report in issueReports)
            {
                string fileName = string.IsNullOrEmpty(report.MediaAttachmentPath) ? "No Attachment" : Path.GetFileName(report.MediaAttachmentPath);
                dataGridView1.Rows.Add(report.Location, report.Category, report.Description, fileName);
            }

            // Optionally, auto-resize the columns for better display
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Enable user interaction for opening files
            dataGridView1.CellClick += DataGridView1_CellClick;  // Add event handler for cell click
        }

        // Event handler for DataGridView cell click
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the Media column was clicked (index 3)
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                // Get the associated IssueReport from the list
                var selectedReport = issueReports[e.RowIndex];
                if (!string.IsNullOrEmpty(selectedReport.MediaAttachmentPath))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(selectedReport.MediaAttachmentPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not open the file: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No media attached for this report.");
                }
            }
        }
    }
}