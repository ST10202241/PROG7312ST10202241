namespace PROG7312ST10202241
{
    partial class ServiceRequestGraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestGraphForm));
            this.dataGridViewRequests = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchRequestId = new System.Windows.Forms.TextBox();
            this.txtRootNode = new System.Windows.Forms.TextBox();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.lblRootNode = new System.Windows.Forms.Label();
            this.lblSearchRequestId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            this.dataGridViewRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequests.Location = new System.Drawing.Point(262, 58);
            this.dataGridViewRequests.Name = "dataGridViewRequests";
            this.dataGridViewRequests.Size = new System.Drawing.Size(660, 351);
            this.dataGridViewRequests.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(92, 375);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchRequestId
            // 
            this.txtSearchRequestId.Location = new System.Drawing.Point(131, 285);
            this.txtSearchRequestId.Name = "txtSearchRequestId";
            this.txtSearchRequestId.Size = new System.Drawing.Size(100, 22);
            this.txtSearchRequestId.TabIndex = 4;
            // 
            // txtRootNode
            // 
            this.txtRootNode.Location = new System.Drawing.Point(131, 215);
            this.txtRootNode.Name = "txtRootNode";
            this.txtRootNode.Size = new System.Drawing.Size(100, 22);
            this.txtRootNode.TabIndex = 5;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(131, 119);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(100, 22);
            this.txtSearchId.TabIndex = 6;
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Location = new System.Drawing.Point(53, 119);
            this.lblSearchId.Name = "lblSearchId";
            this.lblSearchId.Size = new System.Drawing.Size(56, 14);
            this.lblSearchId.TabIndex = 7;
            this.lblSearchId.Text = "Search Id";
            // 
            // lblRootNode
            // 
            this.lblRootNode.AutoSize = true;
            this.lblRootNode.Location = new System.Drawing.Point(46, 215);
            this.lblRootNode.Name = "lblRootNode";
            this.lblRootNode.Size = new System.Drawing.Size(63, 14);
            this.lblRootNode.TabIndex = 8;
            this.lblRootNode.Text = "Root Node";
            // 
            // lblSearchRequestId
            // 
            this.lblSearchRequestId.AutoSize = true;
            this.lblSearchRequestId.Location = new System.Drawing.Point(7, 288);
            this.lblSearchRequestId.Name = "lblSearchRequestId";
            this.lblSearchRequestId.Size = new System.Drawing.Size(102, 14);
            this.lblSearchRequestId.TabIndex = 9;
            this.lblSearchRequestId.Text = "Search Request Id";
            // 
            // ServiceRequestGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312ST10202241.Properties.Resources.capetownimage;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.lblSearchRequestId);
            this.Controls.Add(this.lblRootNode);
            this.Controls.Add(this.lblSearchId);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.txtRootNode);
            this.Controls.Add(this.txtSearchRequestId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewRequests);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ServiceRequestGraphForm";
            this.Text = "ServiceRequestGraphForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceRequestGraphForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRequests;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchRequestId;
        private System.Windows.Forms.TextBox txtRootNode;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.Label lblRootNode;
        private System.Windows.Forms.Label lblSearchRequestId;
    }
}