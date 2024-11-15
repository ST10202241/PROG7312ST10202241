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
            this.lblStatus.Location = new System.Drawing.Point(87, 151);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "lblStatus";
            // 
            // txtRequestId
            // 
            this.txtRequestId.Location = new System.Drawing.Point(90, 36);
            this.txtRequestId.Name = "txtRequestId";
            this.txtRequestId.Size = new System.Drawing.Size(100, 20);
            this.txtRequestId.TabIndex = 4;
            // 
            // txtNewRequestId
            // 
            this.txtNewRequestId.Location = new System.Drawing.Point(594, 105);
            this.txtNewRequestId.Name = "txtNewRequestId";
            this.txtNewRequestId.Size = new System.Drawing.Size(100, 20);
            this.txtNewRequestId.TabIndex = 5;
            // 
            // txtNewStatus
            // 
            this.txtNewStatus.Location = new System.Drawing.Point(595, 148);
            this.txtNewStatus.Name = "txtNewStatus";
            this.txtNewStatus.Size = new System.Drawing.Size(100, 20);
            this.txtNewStatus.TabIndex = 6;
            // 
            // txtNewDescription
            // 
            this.txtNewDescription.Location = new System.Drawing.Point(595, 202);
            this.txtNewDescription.Name = "txtNewDescription";
            this.txtNewDescription.Size = new System.Drawing.Size(100, 20);
            this.txtNewDescription.TabIndex = 7;
            // 
            // txtNewPriority
            // 
            this.txtNewPriority.Location = new System.Drawing.Point(595, 265);
            this.txtNewPriority.Name = "txtNewPriority";
            this.txtNewPriority.Size = new System.Drawing.Size(100, 20);
            this.txtNewPriority.TabIndex = 8;
            // 
            // requestID
            // 
            this.requestID.AutoSize = true;
            this.requestID.Location = new System.Drawing.Point(20, 39);
            this.requestID.Name = "requestID";
            this.requestID.Size = new System.Drawing.Size(64, 13);
            this.requestID.TabIndex = 9;
            this.requestID.Text = "Request ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(212, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // AddNewServiceRequestLbl
            // 
            this.AddNewServiceRequestLbl.AutoSize = true;
            this.AddNewServiceRequestLbl.Location = new System.Drawing.Point(544, 45);
            this.AddNewServiceRequestLbl.Name = "AddNewServiceRequestLbl";
            this.AddNewServiceRequestLbl.Size = new System.Drawing.Size(133, 13);
            this.AddNewServiceRequestLbl.TabIndex = 11;
            this.AddNewServiceRequestLbl.Text = "Add New Service Request";
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(547, 328);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(101, 23);
            this.btnAddRequest.TabIndex = 12;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            // 
            // lblNewRequestId
            // 
            this.lblNewRequestId.AutoSize = true;
            this.lblNewRequestId.Location = new System.Drawing.Point(463, 105);
            this.lblNewRequestId.Name = "lblNewRequestId";
            this.lblNewRequestId.Size = new System.Drawing.Size(89, 13);
            this.lblNewRequestId.TabIndex = 13;
            this.lblNewRequestId.Text = "New Request ID:";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(463, 151);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(65, 13);
            this.lblNewStatus.TabIndex = 14;
            this.lblNewStatus.Text = "New Status:";
            // 
            // lblNewDescription
            // 
            this.lblNewDescription.AutoSize = true;
            this.lblNewDescription.Location = new System.Drawing.Point(464, 209);
            this.lblNewDescription.Name = "lblNewDescription";
            this.lblNewDescription.Size = new System.Drawing.Size(88, 13);
            this.lblNewDescription.TabIndex = 15;
            this.lblNewDescription.Text = "New Description:";
            // 
            // lblNewPriority
            // 
            this.lblNewPriority.AutoSize = true;
            this.lblNewPriority.Location = new System.Drawing.Point(464, 268);
            this.lblNewPriority.Name = "lblNewPriority";
            this.lblNewPriority.Size = new System.Drawing.Size(66, 13);
            this.lblNewPriority.TabIndex = 16;
            this.lblNewPriority.Text = "New Priority:";
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Location = new System.Drawing.Point(87, 108);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(64, 13);
            this.lblRequestID.TabIndex = 17;
            this.lblRequestID.Text = "Request ID:";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(172, 108);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(77, 13);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "Current Status:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(275, 108);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 19;
            this.lblPriority.Text = "Priority:";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(20, 108);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(40, 13);
            this.statusLbl.TabIndex = 20;
            this.statusLbl.Text = "Status:";
            // 
            // ServiceRequestStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.lblRequestID);
            this.Controls.Add(this.lblNewPriority);
            this.Controls.Add(this.lblNewDescription);
            this.Controls.Add(this.lblNewStatus);
            this.Controls.Add(this.lblNewRequestId);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.AddNewServiceRequestLbl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.requestID);
            this.Controls.Add(this.txtNewPriority);
            this.Controls.Add(this.txtNewDescription);
            this.Controls.Add(this.txtNewStatus);
            this.Controls.Add(this.txtNewRequestId);
            this.Controls.Add(this.txtRequestId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ServiceRequestStatementForm";
            this.Text = "Service Request Statement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceRequestStatementForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}