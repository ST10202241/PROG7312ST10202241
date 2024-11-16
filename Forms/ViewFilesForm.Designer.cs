namespace PROG7312ST10202241.Forms
{
    partial class ViewFilesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.Selectlbl = new System.Windows.Forms.Label();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.previewPanel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 14;
            this.filesListBox.Location = new System.Drawing.Point(80, 135);
            this.filesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(249, 186);
            this.filesListBox.TabIndex = 0;
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
            // 
            // Selectlbl
            // 
            this.Selectlbl.AutoSize = true;
            this.Selectlbl.Location = new System.Drawing.Point(94, 104);
            this.Selectlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Selectlbl.Name = "Selectlbl";
            this.Selectlbl.Size = new System.Drawing.Size(111, 14);
            this.Selectlbl.TabIndex = 1;
            this.Selectlbl.Text = "Select a file to open";
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Location = new System.Drawing.Point(462, 28);
            this.previewPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(309, 264);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 2;
            this.previewPictureBox.TabStop = false;
            // 
            // previewPanel
            // 
            this.previewPanel.AutoSize = true;
            this.previewPanel.Location = new System.Drawing.Point(584, 313);
            this.previewPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(81, 14);
            this.previewPanel.TabIndex = 3;
            this.previewPanel.Text = "Preview Panel";
            // 
            // ViewFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.previewPanel);
            this.Controls.Add(this.previewPictureBox);
            this.Controls.Add(this.Selectlbl);
            this.Controls.Add(this.filesListBox);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ViewFilesForm";
            this.Text = "ViewFilesForm";
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label Selectlbl;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Label previewPanel;
    }
}