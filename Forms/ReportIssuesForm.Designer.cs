﻿namespace PROG7312ST10202241
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewReportsFormBtn = new System.Windows.Forms.Button();
            this.attachedFilesListBox = new System.Windows.Forms.ListBox();
            this.RemoveFileBtn = new System.Windows.Forms.Button();
            this.previewPictureBox = new System.Windows.Forms.PictureBox();
            this.previewPanel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).BeginInit();
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
            this.AttachMediaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttachMediaBtn.Location = new System.Drawing.Point(259, 227);
            this.AttachMediaBtn.Name = "AttachMediaBtn";
            this.AttachMediaBtn.Size = new System.Drawing.Size(169, 23);
            this.AttachMediaBtn.TabIndex = 2;
            this.AttachMediaBtn.Text = "Attach Media";
            this.AttachMediaBtn.UseVisualStyleBackColor = true;
            this.AttachMediaBtn.Click += new System.EventHandler(this.AttachMediaBtn_Click_1);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubmitBtn.Location = new System.Drawing.Point(259, 283);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 50);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationLbl.Location = new System.Drawing.Point(84, 56);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(169, 56);
            this.locationLbl.TabIndex = 4;
            this.locationLbl.Text = "location:";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLbl.Location = new System.Drawing.Point(84, 112);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(169, 56);
            this.CategoryLbl.TabIndex = 5;
            this.CategoryLbl.Text = "Category:";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLbl.Location = new System.Drawing.Point(84, 168);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(169, 56);
            this.descriptionLbl.TabIndex = 6;
            this.descriptionLbl.Text = "Description";
            // 
            // locationTxt
            // 
            this.locationTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationTxt.Location = new System.Drawing.Point(259, 59);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(169, 20);
            this.locationTxt.TabIndex = 7;
            this.locationTxt.TextChanged += new System.EventHandler(this.locationTxt_TextChanged_1);
            // 
            // DescriptionRTxt
            // 
            this.DescriptionRTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionRTxt.Location = new System.Drawing.Point(259, 171);
            this.DescriptionRTxt.Name = "DescriptionRTxt";
            this.DescriptionRTxt.Size = new System.Drawing.Size(169, 50);
            this.DescriptionRTxt.TabIndex = 8;
            this.DescriptionRTxt.Text = "";
            this.DescriptionRTxt.TextChanged += new System.EventHandler(this.DescriptionRTxt_TextChanged_1);
            // 
            // CategoryLBox
            // 
            this.CategoryLBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoryLBox.FormattingEnabled = true;
            this.CategoryLBox.Location = new System.Drawing.Point(259, 115);
            this.CategoryLBox.Name = "CategoryLBox";
            this.CategoryLBox.Size = new System.Drawing.Size(169, 50);
            this.CategoryLBox.TabIndex = 9;
            this.CategoryLBox.SelectedIndexChanged += new System.EventHandler(this.CategoryLBox_SelectedIndexChanged_1);
            // 
            // backlbl
            // 
            this.backlbl.AutoSize = true;
            this.backlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backlbl.Location = new System.Drawing.Point(3, 0);
            this.backlbl.Name = "backlbl";
            this.backlbl.Size = new System.Drawing.Size(18, 19);
            this.backlbl.TabIndex = 10;
            this.backlbl.Text = "<";
            this.backlbl.Click += new System.EventHandler(this.backlbl_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 23);
            this.progressBar.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.19473F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.99313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.99313F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.81902F));
            this.tableLayoutPanel1.Controls.Add(this.backlbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.locationLbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SubmitBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.DescriptionRTxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.AttachMediaBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.CategoryLBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLbl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.locationTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ViewReportsFormBtn, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.attachedFilesListBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.RemoveFileBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.previewPictureBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.previewPanel, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 395);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // ViewReportsFormBtn
            // 
            this.ViewReportsFormBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ViewReportsFormBtn.Location = new System.Drawing.Point(84, 339);
            this.ViewReportsFormBtn.Name = "ViewReportsFormBtn";
            this.ViewReportsFormBtn.Size = new System.Drawing.Size(100, 53);
            this.ViewReportsFormBtn.TabIndex = 11;
            this.ViewReportsFormBtn.Text = "View Reports";
            this.ViewReportsFormBtn.UseVisualStyleBackColor = true;
            this.ViewReportsFormBtn.Click += new System.EventHandler(this.ViewReportsFormBtn_Click);
            // 
            // attachedFilesListBox
            // 
            this.attachedFilesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attachedFilesListBox.FormattingEnabled = true;
            this.attachedFilesListBox.Location = new System.Drawing.Point(434, 171);
            this.attachedFilesListBox.Name = "attachedFilesListBox";
            this.attachedFilesListBox.Size = new System.Drawing.Size(363, 50);
            this.attachedFilesListBox.TabIndex = 12;
            this.attachedFilesListBox.SelectedIndexChanged += new System.EventHandler(this.attachedFilesListBox_SelectedIndexChanged);
            // 
            // RemoveFileBtn
            // 
            this.RemoveFileBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RemoveFileBtn.Location = new System.Drawing.Point(609, 227);
            this.RemoveFileBtn.Name = "RemoveFileBtn";
            this.RemoveFileBtn.Size = new System.Drawing.Size(188, 50);
            this.RemoveFileBtn.TabIndex = 13;
            this.RemoveFileBtn.Text = "Remove Files";
            this.RemoveFileBtn.UseVisualStyleBackColor = true;
            this.RemoveFileBtn.Click += new System.EventHandler(this.RemoveFileBtn_Click);
            // 
            // previewPictureBox
            // 
            this.previewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewPictureBox.Location = new System.Drawing.Point(434, 115);
            this.previewPictureBox.Name = "previewPictureBox";
            this.previewPictureBox.Size = new System.Drawing.Size(363, 50);
            this.previewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewPictureBox.TabIndex = 14;
            this.previewPictureBox.TabStop = false;
            // 
            // previewPanel
            // 
            this.previewPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previewPanel.AutoSize = true;
            this.previewPanel.Location = new System.Drawing.Point(579, 99);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(72, 13);
            this.previewPanel.TabIndex = 15;
            this.previewPanel.Text = "Peview Panel";
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.closeBtn);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportIssuesForm_FormClosed);
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewPictureBox)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ViewReportsFormBtn;
        private System.Windows.Forms.ListBox attachedFilesListBox;
        private System.Windows.Forms.Button RemoveFileBtn;
        private System.Windows.Forms.PictureBox previewPictureBox;
        private System.Windows.Forms.Label previewPanel;
    }
}