using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312ST10202241.Forms
{
    public partial class ViewFilesForm : Form
    {
        private List<string> attachedFiles;

        public ViewFilesForm(List<string> files)
        {
            InitializeComponent();
            attachedFiles = files;

            PopulateFilesList();
        }

        private void PopulateFilesList()
        {
            filesListBox.Items.Clear(); // Ensure the list box is empty before populating
            foreach (var file in attachedFiles)
            {
                filesListBox.Items.Add(Path.GetFileName(file)); // Add file name only
            }
        }

        private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filesListBox.SelectedItem != null)
            {
                string selectedFile = filesListBox.SelectedItem.ToString();
                string filePath = attachedFiles.FirstOrDefault(path => Path.GetFileName(path) == selectedFile);

                if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                {
                    try
                    {
                        // Open the file using the default program
                        System.Diagnostics.Process.Start(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Could not open the file: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
        }
    }
}