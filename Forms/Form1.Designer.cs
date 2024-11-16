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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LocalEventsAndAnnouncementsPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportIssuesPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceRequestStatusPBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalEventsAndAnnouncementsPBox
            // 
            this.LocalEventsAndAnnouncementsPBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LocalEventsAndAnnouncementsPBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalEventsAndAnnouncementsPBox.Image = global::PROG7312ST10202241.Properties.Resources.AnnouncementImage;
            this.LocalEventsAndAnnouncementsPBox.InitialImage = global::PROG7312ST10202241.Properties.Resources.AnnouncementImage;
            this.LocalEventsAndAnnouncementsPBox.Location = new System.Drawing.Point(315, 164);
            this.LocalEventsAndAnnouncementsPBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LocalEventsAndAnnouncementsPBox.Name = "LocalEventsAndAnnouncementsPBox";
            this.LocalEventsAndAnnouncementsPBox.Size = new System.Drawing.Size(303, 155);
            this.LocalEventsAndAnnouncementsPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LocalEventsAndAnnouncementsPBox.TabIndex = 0;
            this.LocalEventsAndAnnouncementsPBox.TabStop = false;
            this.LocalEventsAndAnnouncementsPBox.Click += new System.EventHandler(this.LocalEventsAndAnnouncementsPBox_Click_1);
            // 
            // ReportIssuesPBox
            // 
            this.ReportIssuesPBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportIssuesPBox.Image = global::PROG7312ST10202241.Properties.Resources.ReportImages;
            this.ReportIssuesPBox.Location = new System.Drawing.Point(4, 164);
            this.ReportIssuesPBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReportIssuesPBox.Name = "ReportIssuesPBox";
            this.ReportIssuesPBox.Size = new System.Drawing.Size(303, 155);
            this.ReportIssuesPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReportIssuesPBox.TabIndex = 1;
            this.ReportIssuesPBox.TabStop = false;
            this.ReportIssuesPBox.Click += new System.EventHandler(this.ReportIssuesPBox_Click_1);
            // 
            // ServiceRequestStatusPBox
            // 
            this.ServiceRequestStatusPBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceRequestStatusPBox.Image = global::PROG7312ST10202241.Properties.Resources.ServiceRequestImage;
            this.ServiceRequestStatusPBox.Location = new System.Drawing.Point(626, 164);
            this.ServiceRequestStatusPBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServiceRequestStatusPBox.Name = "ServiceRequestStatusPBox";
            this.ServiceRequestStatusPBox.Size = new System.Drawing.Size(304, 155);
            this.ServiceRequestStatusPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServiceRequestStatusPBox.TabIndex = 2;
            this.ServiceRequestStatusPBox.TabStop = false;
            this.ServiceRequestStatusPBox.Click += new System.EventHandler(this.ServiceRequestStatusPBox_Click_1);
            // 
            // ReportIssuesLbl
            // 
            this.ReportIssuesLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReportIssuesLbl.AutoSize = true;
            this.ReportIssuesLbl.Location = new System.Drawing.Point(115, 322);
            this.ReportIssuesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReportIssuesLbl.Name = "ReportIssuesLbl";
            this.ReportIssuesLbl.Size = new System.Drawing.Size(81, 14);
            this.ReportIssuesLbl.TabIndex = 3;
            this.ReportIssuesLbl.Text = "Report Issues";
            this.ReportIssuesLbl.Click += new System.EventHandler(this.ReportIssuesLbl_Click_1);
            // 
            // LocalEventsAndAnnouncementsLbl
            // 
            this.LocalEventsAndAnnouncementsLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LocalEventsAndAnnouncementsLbl.AutoSize = true;
            this.LocalEventsAndAnnouncementsLbl.Location = new System.Drawing.Point(371, 322);
            this.LocalEventsAndAnnouncementsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocalEventsAndAnnouncementsLbl.Name = "LocalEventsAndAnnouncementsLbl";
            this.LocalEventsAndAnnouncementsLbl.Size = new System.Drawing.Size(190, 14);
            this.LocalEventsAndAnnouncementsLbl.TabIndex = 4;
            this.LocalEventsAndAnnouncementsLbl.Text = "Local Events And Announcements";
            this.LocalEventsAndAnnouncementsLbl.Click += new System.EventHandler(this.LocalEventsAndAnnouncementsLbl_Click_1);
            // 
            // ServiceRequestStatusLbl
            // 
            this.ServiceRequestStatusLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServiceRequestStatusLbl.AutoSize = true;
            this.ServiceRequestStatusLbl.Location = new System.Drawing.Point(713, 322);
            this.ServiceRequestStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServiceRequestStatusLbl.Name = "ServiceRequestStatusLbl";
            this.ServiceRequestStatusLbl.Size = new System.Drawing.Size(129, 14);
            this.ServiceRequestStatusLbl.TabIndex = 5;
            this.ServiceRequestStatusLbl.Text = "Service Request Status";
            this.ServiceRequestStatusLbl.Click += new System.EventHandler(this.ServiceRequestStatusLbl_Click_1);
            // 
            // languageCBox
            // 
            this.languageCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageCBox.FormattingEnabled = true;
            this.languageCBox.Location = new System.Drawing.Point(315, 3);
            this.languageCBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.languageCBox.Name = "languageCBox";
            this.languageCBox.Size = new System.Drawing.Size(303, 22);
            this.languageCBox.TabIndex = 6;
            this.languageCBox.SelectedIndexChanged += new System.EventHandler(this.languageCBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.ServiceRequestStatusPBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LocalEventsAndAnnouncementsPBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ServiceRequestStatusLbl, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReportIssuesPBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LocalEventsAndAnnouncementsLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReportIssuesLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.languageCBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 485);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            ((System.ComponentModel.ISupportInitialize)(this.LocalEventsAndAnnouncementsPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportIssuesPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceRequestStatusPBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LocalEventsAndAnnouncementsPBox;
        private System.Windows.Forms.PictureBox ReportIssuesPBox;
        private System.Windows.Forms.PictureBox ServiceRequestStatusPBox;
        private System.Windows.Forms.Label ReportIssuesLbl;
        private System.Windows.Forms.Label LocalEventsAndAnnouncementsLbl;
        private System.Windows.Forms.Label ServiceRequestStatusLbl;
        private System.Windows.Forms.ComboBox languageCBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}