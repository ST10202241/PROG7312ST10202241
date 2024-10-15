namespace PROG7312ST10202241.Forms
{
    partial class Form1
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
            this.LocalEventsAndAnnouncementsPBox = new System.Windows.Forms.PictureBox();
            this.ReportIssuesPBox = new System.Windows.Forms.PictureBox();
            this.ServiceRequestStatusPBox = new System.Windows.Forms.PictureBox();
            this.ReportIssuesLbl = new System.Windows.Forms.Label();
            this.LocalEventsAndAnnouncementsLbl = new System.Windows.Forms.Label();
            this.ServiceRequestStatusLbl = new System.Windows.Forms.Label();
            this.languageCBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LocalEventsAndAnnouncementsPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportIssuesPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceRequestStatusPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LocalEventsAndAnnouncementsPBox
            // 
            this.LocalEventsAndAnnouncementsPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LocalEventsAndAnnouncementsPBox.Image = global::PROG7312ST10202241.Properties.Resources.AnnouncementImage;
            this.LocalEventsAndAnnouncementsPBox.InitialImage = global::PROG7312ST10202241.Properties.Resources.AnnouncementImage;
            this.LocalEventsAndAnnouncementsPBox.Location = new System.Drawing.Point(319, 140);
            this.LocalEventsAndAnnouncementsPBox.Name = "LocalEventsAndAnnouncementsPBox";
            this.LocalEventsAndAnnouncementsPBox.Size = new System.Drawing.Size(150, 150);
            this.LocalEventsAndAnnouncementsPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LocalEventsAndAnnouncementsPBox.TabIndex = 0;
            this.LocalEventsAndAnnouncementsPBox.TabStop = false;
            this.LocalEventsAndAnnouncementsPBox.Click += new System.EventHandler(this.LocalEventsAndAnnouncementsPBox_Click_1);
            // 
            // ReportIssuesPBox
            // 
            this.ReportIssuesPBox.Image = global::PROG7312ST10202241.Properties.Resources.ReportImages;
            this.ReportIssuesPBox.Location = new System.Drawing.Point(95, 140);
            this.ReportIssuesPBox.Name = "ReportIssuesPBox";
            this.ReportIssuesPBox.Size = new System.Drawing.Size(150, 150);
            this.ReportIssuesPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReportIssuesPBox.TabIndex = 1;
            this.ReportIssuesPBox.TabStop = false;
            this.ReportIssuesPBox.Click += new System.EventHandler(this.ReportIssuesPBox_Click_1);
            // 
            // ServiceRequestStatusPBox
            // 
            this.ServiceRequestStatusPBox.Image = global::PROG7312ST10202241.Properties.Resources.ServiceRequestImage;
            this.ServiceRequestStatusPBox.Location = new System.Drawing.Point(555, 140);
            this.ServiceRequestStatusPBox.Name = "ServiceRequestStatusPBox";
            this.ServiceRequestStatusPBox.Size = new System.Drawing.Size(150, 150);
            this.ServiceRequestStatusPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServiceRequestStatusPBox.TabIndex = 2;
            this.ServiceRequestStatusPBox.TabStop = false;
            this.ServiceRequestStatusPBox.Click += new System.EventHandler(this.ServiceRequestStatusPBox_Click_1);
            // 
            // ReportIssuesLbl
            // 
            this.ReportIssuesLbl.AutoSize = true;
            this.ReportIssuesLbl.Location = new System.Drawing.Point(141, 331);
            this.ReportIssuesLbl.Name = "ReportIssuesLbl";
            this.ReportIssuesLbl.Size = new System.Drawing.Size(72, 13);
            this.ReportIssuesLbl.TabIndex = 3;
            this.ReportIssuesLbl.Text = "Report Issues";
            this.ReportIssuesLbl.Click += new System.EventHandler(this.ReportIssuesLbl_Click_1);
            // 
            // LocalEventsAndAnnouncementsLbl
            // 
            this.LocalEventsAndAnnouncementsLbl.AutoSize = true;
            this.LocalEventsAndAnnouncementsLbl.Location = new System.Drawing.Point(316, 330);
            this.LocalEventsAndAnnouncementsLbl.Name = "LocalEventsAndAnnouncementsLbl";
            this.LocalEventsAndAnnouncementsLbl.Size = new System.Drawing.Size(171, 13);
            this.LocalEventsAndAnnouncementsLbl.TabIndex = 4;
            this.LocalEventsAndAnnouncementsLbl.Text = "Local Events And Announcements";
            this.LocalEventsAndAnnouncementsLbl.Click += new System.EventHandler(this.LocalEventsAndAnnouncementsLbl_Click_1);
            // 
            // ServiceRequestStatusLbl
            // 
            this.ServiceRequestStatusLbl.AutoSize = true;
            this.ServiceRequestStatusLbl.Location = new System.Drawing.Point(552, 330);
            this.ServiceRequestStatusLbl.Name = "ServiceRequestStatusLbl";
            this.ServiceRequestStatusLbl.Size = new System.Drawing.Size(119, 13);
            this.ServiceRequestStatusLbl.TabIndex = 5;
            this.ServiceRequestStatusLbl.Text = "Service Request Status";
            this.ServiceRequestStatusLbl.Click += new System.EventHandler(this.ServiceRequestStatusLbl_Click_1);
            // 
            // languageCBox
            // 
            this.languageCBox.FormattingEnabled = true;
            this.languageCBox.Location = new System.Drawing.Point(129, 28);
            this.languageCBox.Name = "languageCBox";
            this.languageCBox.Size = new System.Drawing.Size(121, 21);
            this.languageCBox.TabIndex = 6;
            this.languageCBox.SelectedIndexChanged += new System.EventHandler(this.languageCBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.languageCBox);
            this.Controls.Add(this.ServiceRequestStatusLbl);
            this.Controls.Add(this.LocalEventsAndAnnouncementsLbl);
            this.Controls.Add(this.ReportIssuesLbl);
            this.Controls.Add(this.ServiceRequestStatusPBox);
            this.Controls.Add(this.ReportIssuesPBox);
            this.Controls.Add(this.LocalEventsAndAnnouncementsPBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.LocalEventsAndAnnouncementsPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportIssuesPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceRequestStatusPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LocalEventsAndAnnouncementsPBox;
        private System.Windows.Forms.PictureBox ReportIssuesPBox;
        private System.Windows.Forms.PictureBox ServiceRequestStatusPBox;
        private System.Windows.Forms.Label ReportIssuesLbl;
        private System.Windows.Forms.Label LocalEventsAndAnnouncementsLbl;
        private System.Windows.Forms.Label ServiceRequestStatusLbl;
        private System.Windows.Forms.ComboBox languageCBox;
    }
}