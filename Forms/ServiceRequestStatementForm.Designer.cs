namespace PROG7312ST10202241
{
    partial class ServiceRequestStatementForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRequestId = new System.Windows.Forms.TextBox();
            this.txtNewRequestId = new System.Windows.Forms.TextBox();
            this.txtNewStatus = new System.Windows.Forms.TextBox();
            this.txtNewDescription = new System.Windows.Forms.TextBox();
            this.txtNewPriority = new System.Windows.Forms.TextBox();
            this.requestID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.AddNewServiceRequestLbl = new System.Windows.Forms.Label();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.lblNewRequestId = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.lblNewDescription = new System.Windows.Forms.Label();
            this.lblNewPriority = new System.Windows.Forms.Label();
            this.lblRequestID = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back To Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.backToMainMenuBtn_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 328);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(388, 84);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "lblStatus";
            // 
            // txtRequestId
            // 
            this.txtRequestId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestId.Location = new System.Drawing.Point(132, 3);
            this.txtRequestId.Name = "txtRequestId";
            this.txtRequestId.Size = new System.Drawing.Size(123, 20);
            this.txtRequestId.TabIndex = 4;
            // 
            // txtNewRequestId
            // 
            this.txtNewRequestId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewRequestId.Location = new System.Drawing.Point(197, 3);
            this.txtNewRequestId.Name = "txtNewRequestId";
            this.txtNewRequestId.Size = new System.Drawing.Size(188, 20);
            this.txtNewRequestId.TabIndex = 5;
            // 
            // txtNewStatus
            // 
            this.txtNewStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewStatus.Location = new System.Drawing.Point(197, 83);
            this.txtNewStatus.Name = "txtNewStatus";
            this.txtNewStatus.Size = new System.Drawing.Size(188, 20);
            this.txtNewStatus.TabIndex = 6;
            // 
            // txtNewDescription
            // 
            this.txtNewDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewDescription.Location = new System.Drawing.Point(197, 163);
            this.txtNewDescription.Name = "txtNewDescription";
            this.txtNewDescription.Size = new System.Drawing.Size(188, 20);
            this.txtNewDescription.TabIndex = 7;
            // 
            // txtNewPriority
            // 
            this.txtNewPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPriority.Location = new System.Drawing.Point(197, 243);
            this.txtNewPriority.Name = "txtNewPriority";
            this.txtNewPriority.Size = new System.Drawing.Size(188, 20);
            this.txtNewPriority.TabIndex = 8;
            // 
            // requestID
            // 
            this.requestID.AutoSize = true;
            this.requestID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestID.Location = new System.Drawing.Point(3, 0);
            this.requestID.Name = "requestID";
            this.requestID.Size = new System.Drawing.Size(123, 158);
            this.requestID.TabIndex = 9;
            this.requestID.Text = "Request ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(261, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 152);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AddNewServiceRequestLbl
            // 
            this.AddNewServiceRequestLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AddNewServiceRequestLbl.AutoSize = true;
            this.AddNewServiceRequestLbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewServiceRequestLbl.Location = new System.Drawing.Point(113, 0);
            this.AddNewServiceRequestLbl.Name = "AddNewServiceRequestLbl";
            this.AddNewServiceRequestLbl.Size = new System.Drawing.Size(167, 41);
            this.AddNewServiceRequestLbl.TabIndex = 11;
            this.AddNewServiceRequestLbl.Text = "Add New Service Request";
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddRequest.Location = new System.Drawing.Point(3, 373);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(388, 36);
            this.btnAddRequest.TabIndex = 12;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // lblNewRequestId
            // 
            this.lblNewRequestId.AutoSize = true;
            this.lblNewRequestId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewRequestId.Location = new System.Drawing.Point(3, 0);
            this.lblNewRequestId.Name = "lblNewRequestId";
            this.lblNewRequestId.Size = new System.Drawing.Size(188, 80);
            this.lblNewRequestId.TabIndex = 13;
            this.lblNewRequestId.Text = "New Request ID:";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewStatus.Location = new System.Drawing.Point(3, 80);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(188, 80);
            this.lblNewStatus.TabIndex = 14;
            this.lblNewStatus.Text = "New Status:";
            // 
            // lblNewDescription
            // 
            this.lblNewDescription.AutoSize = true;
            this.lblNewDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewDescription.Location = new System.Drawing.Point(3, 160);
            this.lblNewDescription.Name = "lblNewDescription";
            this.lblNewDescription.Size = new System.Drawing.Size(188, 80);
            this.lblNewDescription.TabIndex = 15;
            this.lblNewDescription.Text = "New Description:";
            // 
            // lblNewPriority
            // 
            this.lblNewPriority.AutoSize = true;
            this.lblNewPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewPriority.Location = new System.Drawing.Point(3, 240);
            this.lblNewPriority.Name = "lblNewPriority";
            this.lblNewPriority.Size = new System.Drawing.Size(188, 83);
            this.lblNewPriority.TabIndex = 16;
            this.lblNewPriority.Text = "New Priority:";
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRequestID.Location = new System.Drawing.Point(100, 0);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(91, 158);
            this.lblRequestID.TabIndex = 17;
            this.lblRequestID.Text = "Request ID:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Location = new System.Drawing.Point(197, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(91, 158);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "Current Status:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriority.Location = new System.Drawing.Point(294, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(91, 158);
            this.lblPriority.TabIndex = 19;
            this.lblPriority.Text = "Priority:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLbl.Location = new System.Drawing.Point(3, 0);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(91, 158);
            this.statusLbl.TabIndex = 20;
            this.statusLbl.Text = "Status:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.requestID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRequestId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 158);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.statusLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRequestID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPriority, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelStatus, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 167);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(388, 158);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblNewRequestId, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNewRequestId, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNewStatus, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtNewDescription, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNewPriority, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtNewPriority, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblNewDescription, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNewStatus, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 44);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 323);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.AddNewServiceRequestLbl, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddRequest, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(394, 412);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblStatus, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(394, 412);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(800, 418);
            this.tableLayoutPanel6.TabIndex = 26;
            // 
            // ServiceRequestStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ServiceRequestStatementForm";
            this.Text = "Service Request Statement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceRequestStatementForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRequestId;
        private System.Windows.Forms.TextBox txtNewRequestId;
        private System.Windows.Forms.TextBox txtNewStatus;
        private System.Windows.Forms.TextBox txtNewDescription;
        private System.Windows.Forms.TextBox txtNewPriority;
        private System.Windows.Forms.Label requestID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label AddNewServiceRequestLbl;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Label lblNewRequestId;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.Label lblNewDescription;
        private System.Windows.Forms.Label lblNewPriority;
        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}