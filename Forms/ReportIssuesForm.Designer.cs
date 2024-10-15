namespace PROG7312ST10202241
{
    partial class ReportIssuesForm
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.AttachMediaBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.locationLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.DescriptionRTxt = new System.Windows.Forms.RichTextBox();
            this.CategoryLBox = new System.Windows.Forms.ListBox();
            this.backlbl = new System.Windows.Forms.Label();
            this.ViewReportsFormBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(0, 418);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(800, 32);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Back To Main Menu";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // AttachMediaBtn
            // 
            this.AttachMediaBtn.Location = new System.Drawing.Point(334, 250);
            this.AttachMediaBtn.Name = "AttachMediaBtn";
            this.AttachMediaBtn.Size = new System.Drawing.Size(110, 23);
            this.AttachMediaBtn.TabIndex = 2;
            this.AttachMediaBtn.Text = "Attach Media";
            this.AttachMediaBtn.UseVisualStyleBackColor = true;
            this.AttachMediaBtn.Click += new System.EventHandler(this.AttachMediaBtn_Click_1);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(352, 381);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(281, 95);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(47, 13);
            this.locationLbl.TabIndex = 4;
            this.locationLbl.Text = "location:";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(281, 120);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(52, 13);
            this.CategoryLbl.TabIndex = 5;
            this.CategoryLbl.Text = "Category:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(281, 195);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.descriptionLbl.TabIndex = 6;
            this.descriptionLbl.Text = "Description";
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(396, 87);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(100, 20);
            this.locationTxt.TabIndex = 7;
            this.locationTxt.TextChanged += new System.EventHandler(this.locationTxt_TextChanged_1);
            // 
            // DescriptionRTxt
            // 
            this.DescriptionRTxt.Location = new System.Drawing.Point(396, 195);
            this.DescriptionRTxt.Name = "DescriptionRTxt";
            this.DescriptionRTxt.Size = new System.Drawing.Size(237, 49);
            this.DescriptionRTxt.TabIndex = 8;
            this.DescriptionRTxt.Text = "";
            this.DescriptionRTxt.TextChanged += new System.EventHandler(this.DescriptionRTxt_TextChanged_1);
            // 
            // CategoryLBox
            // 
            this.CategoryLBox.FormattingEnabled = true;
            this.CategoryLBox.Location = new System.Drawing.Point(396, 114);
            this.CategoryLBox.Name = "CategoryLBox";
            this.CategoryLBox.Size = new System.Drawing.Size(100, 69);
            this.CategoryLBox.TabIndex = 9;
            this.CategoryLBox.SelectedIndexChanged += new System.EventHandler(this.CategoryLBox_SelectedIndexChanged_1);
            // 
            // backlbl
            // 
            this.backlbl.AutoSize = true;
            this.backlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlbl.Location = new System.Drawing.Point(12, 26);
            this.backlbl.Name = "backlbl";
            this.backlbl.Size = new System.Drawing.Size(18, 19);
            this.backlbl.TabIndex = 10;
            this.backlbl.Text = "<";
            this.backlbl.Click += new System.EventHandler(this.backlbl_Click);
            // 
            // ViewReportsFormBtn
            // 
            this.ViewReportsFormBtn.Location = new System.Drawing.Point(176, 389);
            this.ViewReportsFormBtn.Name = "ViewReportsFormBtn";
            this.ViewReportsFormBtn.Size = new System.Drawing.Size(100, 23);
            this.ViewReportsFormBtn.TabIndex = 11;
            this.ViewReportsFormBtn.Text = "View Reports";
            this.ViewReportsFormBtn.UseVisualStyleBackColor = true;
            this.ViewReportsFormBtn.Click += new System.EventHandler(this.ViewReportsFormBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 23);
            this.progressBar.TabIndex = 12;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ViewReportsFormBtn);
            this.Controls.Add(this.backlbl);
            this.Controls.Add(this.CategoryLBox);
            this.Controls.Add(this.DescriptionRTxt);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.AttachMediaBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportIssuesForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button AttachMediaBtn;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.RichTextBox DescriptionRTxt;
        private System.Windows.Forms.ListBox CategoryLBox;
        private System.Windows.Forms.Label backlbl;
        private System.Windows.Forms.Button ViewReportsFormBtn;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}