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
            this.SuspendLayout();
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(70, 37);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(214, 173);
            this.filesListBox.TabIndex = 0;
            // 
            // Selectlbl
            // 
            this.Selectlbl.AutoSize = true;
            this.Selectlbl.Location = new System.Drawing.Point(486, 126);
            this.Selectlbl.Name = "Selectlbl";
            this.Selectlbl.Size = new System.Drawing.Size(101, 13);
            this.Selectlbl.TabIndex = 1;
            this.Selectlbl.Text = "Select a file to open";
            // 
            // ViewFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Selectlbl);
            this.Controls.Add(this.filesListBox);
            this.Name = "ViewFilesForm";
            this.Text = "ViewFilesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label Selectlbl;
    }
}