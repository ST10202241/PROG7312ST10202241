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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.txtNewStatus = new System.Windows.Forms.TextBox();
            this.lblSearchID = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowMST = new System.Windows.Forms.Button();
            this.btnGraphTraversal = new System.Windows.Forms.Button();
            this.lstMSTDisplay = new System.Windows.Forms.ListBox();
            this.lstTraversalDisplay = new System.Windows.Forms.ListBox();
            this.txtRootNode = new System.Windows.Forms.TextBox();
            this.btnSetRoot = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.closeBtn, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.51546F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.484536F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(934, 485);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.76654F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.23346F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewRequests, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(928, 433);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.58974F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.41026F));
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateStatus, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNewStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNewStatus, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSearchID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchId, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 427);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(3, 175);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(72, 23);
            this.btnUpdateStatus.TabIndex = 6;
            this.btnUpdateStatus.Text = "refresh";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(82, 175);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(3, 0);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(66, 14);
            this.lblNewStatus.TabIndex = 9;
            this.lblNewStatus.Text = "New status";
            // 
            // txtNewStatus
            // 
            this.txtNewStatus.Location = new System.Drawing.Point(81, 3);
            this.txtNewStatus.Name = "txtNewStatus";
            this.txtNewStatus.Size = new System.Drawing.Size(94, 22);
            this.txtNewStatus.TabIndex = 7;
            // 
            // lblSearchID
            // 
            this.lblSearchID.AutoSize = true;
            this.lblSearchID.Location = new System.Drawing.Point(3, 86);
            this.lblSearchID.Name = "lblSearchID";
            this.lblSearchID.Size = new System.Drawing.Size(64, 28);
            this.lblSearchID.TabIndex = 8;
            this.lblSearchID.Text = "Search By ID";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(82, 89);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(92, 22);
            this.txtSearchId.TabIndex = 5;
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRequests.Location = new System.Drawing.Point(190, 3);
            this.dataGridViewRequests.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.Size = new System.Drawing.Size(430, 427);
            this.dataGridViewRequests.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F);
            this.closeBtn.Location = new System.Drawing.Point(4, 442);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(926, 40);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "Back To Main Menu";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.00671F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.99329F));
            this.tableLayoutPanel4.Controls.Add(this.lstMSTDisplay, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lstTraversalDisplay, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnShowMST, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnGraphTraversal, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtRootNode, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSetRoot, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(627, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(298, 427);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btnShowMST
            // 
            this.btnShowMST.Location = new System.Drawing.Point(3, 201);
            this.btnShowMST.Name = "btnShowMST";
            this.btnShowMST.Size = new System.Drawing.Size(121, 23);
            this.btnShowMST.TabIndex = 0;
            this.btnShowMST.Text = "btnShowMST";
            this.btnShowMST.UseVisualStyleBackColor = true;
            this.btnShowMST.Click += new System.EventHandler(this.btnShowMST_Click);
            // 
            // btnGraphTraversal
            // 
            this.btnGraphTraversal.Location = new System.Drawing.Point(155, 201);
            this.btnGraphTraversal.Name = "btnGraphTraversal";
            this.btnGraphTraversal.Size = new System.Drawing.Size(140, 23);
            this.btnGraphTraversal.TabIndex = 1;
            this.btnGraphTraversal.Text = "btnGraphTraversal";
            this.btnGraphTraversal.UseVisualStyleBackColor = true;
            this.btnGraphTraversal.Click += new System.EventHandler(this.btnGraphTraversal_Click);
            // 
            // lstMSTDisplay
            // 
            this.lstMSTDisplay.FormattingEnabled = true;
            this.lstMSTDisplay.ItemHeight = 14;
            this.lstMSTDisplay.Location = new System.Drawing.Point(3, 3);
            this.lstMSTDisplay.Name = "lstMSTDisplay";
            this.lstMSTDisplay.Size = new System.Drawing.Size(120, 88);
            this.lstMSTDisplay.TabIndex = 2;
            // 
            // lstTraversalDisplay
            // 
            this.lstTraversalDisplay.FormattingEnabled = true;
            this.lstTraversalDisplay.ItemHeight = 14;
            this.lstTraversalDisplay.Location = new System.Drawing.Point(155, 3);
            this.lstTraversalDisplay.Name = "lstTraversalDisplay";
            this.lstTraversalDisplay.Size = new System.Drawing.Size(120, 88);
            this.lstTraversalDisplay.TabIndex = 3;
            // 
            // txtRootNode
            // 
            this.txtRootNode.Location = new System.Drawing.Point(3, 102);
            this.txtRootNode.Name = "txtRootNode";
            this.txtRootNode.Size = new System.Drawing.Size(100, 22);
            this.txtRootNode.TabIndex = 4;
            // 
            // btnSetRoot
            // 
            this.btnSetRoot.Location = new System.Drawing.Point(155, 102);
            this.btnSetRoot.Name = "btnSetRoot";
            this.btnSetRoot.Size = new System.Drawing.Size(108, 23);
            this.btnSetRoot.TabIndex = 5;
            this.btnSetRoot.Text = "Set Root";
            this.btnSetRoot.UseVisualStyleBackColor = true;
            this.btnSetRoot.Click += new System.EventHandler(this.btnSetRoot_Click);
            // 
            // ServiceRequestStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServiceRequestStatementForm";
            this.Text = "Service Request Statement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceRequestStatementForm_FormClosed);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.TextBox txtNewStatus;
        private System.Windows.Forms.Label lblSearchID;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnShowMST;
        private System.Windows.Forms.Button btnGraphTraversal;
        private System.Windows.Forms.ListBox lstMSTDisplay;
        private System.Windows.Forms.ListBox lstTraversalDisplay;
        private System.Windows.Forms.TextBox txtRootNode;
        private System.Windows.Forms.Button btnSetRoot;
    }
}