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
            this.txtNewStatus = new System.Windows.Forms.TextBox();
            this.txtRootNode = new System.Windows.Forms.TextBox();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.lblRootNode = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.btnShowHeap = new System.Windows.Forms.Button();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnShowMST = new System.Windows.Forms.Button();
            this.btnGraphTraversal = new System.Windows.Forms.Button();
            this.btnSetRoot = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
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
            this.btnSearch.Location = new System.Drawing.Point(187, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtNewStatus
            // 
            this.txtNewStatus.Location = new System.Drawing.Point(81, 257);
            this.txtNewStatus.Name = "txtNewStatus";
            this.txtNewStatus.Size = new System.Drawing.Size(100, 22);
            this.txtNewStatus.TabIndex = 4;
            // 
            // txtRootNode
            // 
            this.txtRootNode.Location = new System.Drawing.Point(81, 212);
            this.txtRootNode.Name = "txtRootNode";
            this.txtRootNode.Size = new System.Drawing.Size(100, 22);
            this.txtRootNode.TabIndex = 5;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(81, 174);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(100, 22);
            this.txtSearchId.TabIndex = 6;
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Location = new System.Drawing.Point(19, 174);
            this.lblSearchId.Name = "lblSearchId";
            this.lblSearchId.Size = new System.Drawing.Size(56, 14);
            this.lblSearchId.TabIndex = 7;
            this.lblSearchId.Text = "Search Id";
            // 
            // lblRootNode
            // 
            this.lblRootNode.AutoSize = true;
            this.lblRootNode.Location = new System.Drawing.Point(12, 215);
            this.lblRootNode.Name = "lblRootNode";
            this.lblRootNode.Size = new System.Drawing.Size(63, 14);
            this.lblRootNode.TabIndex = 8;
            this.lblRootNode.Text = "Root Node";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(8, 265);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(67, 14);
            this.lblNewStatus.TabIndex = 9;
            this.lblNewStatus.Text = "New Status";
            // 
            // btnShowHeap
            // 
            this.btnShowHeap.Location = new System.Drawing.Point(153, 325);
            this.btnShowHeap.Name = "btnShowHeap";
            this.btnShowHeap.Size = new System.Drawing.Size(75, 23);
            this.btnShowHeap.TabIndex = 10;
            this.btnShowHeap.Text = "Show Heap";
            this.btnShowHeap.UseVisualStyleBackColor = true;
            this.btnShowHeap.Click += new System.EventHandler(this.btnShowHeap_Click);
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(15, 325);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(100, 23);
            this.btnShowGraph.TabIndex = 11;
            this.btnShowGraph.Text = "Show Graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(187, 247);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(75, 41);
            this.btnUpdateStatus.TabIndex = 12;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnShowMST
            // 
            this.btnShowMST.Location = new System.Drawing.Point(22, 372);
            this.btnShowMST.Name = "btnShowMST";
            this.btnShowMST.Size = new System.Drawing.Size(75, 23);
            this.btnShowMST.TabIndex = 13;
            this.btnShowMST.Text = "Show MST";
            this.btnShowMST.UseVisualStyleBackColor = true;
            this.btnShowMST.Click += new System.EventHandler(this.btnShowMST_Click);
            // 
            // btnGraphTraversal
            // 
            this.btnGraphTraversal.Location = new System.Drawing.Point(131, 372);
            this.btnGraphTraversal.Name = "btnGraphTraversal";
            this.btnGraphTraversal.Size = new System.Drawing.Size(115, 23);
            this.btnGraphTraversal.TabIndex = 14;
            this.btnGraphTraversal.Text = "Graph Traversal";
            this.btnGraphTraversal.UseVisualStyleBackColor = true;
            this.btnGraphTraversal.Click += new System.EventHandler(this.btnGraphTraversal_Click);
            // 
            // btnSetRoot
            // 
            this.btnSetRoot.Location = new System.Drawing.Point(187, 211);
            this.btnSetRoot.Name = "btnSetRoot";
            this.btnSetRoot.Size = new System.Drawing.Size(75, 23);
            this.btnSetRoot.TabIndex = 15;
            this.btnSetRoot.Text = "Set Root";
            this.btnSetRoot.UseVisualStyleBackColor = true;
            this.btnSetRoot.Click += new System.EventHandler(this.btnSetRoot_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(554, 450);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ServiceRequestGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROG7312ST10202241.Properties.Resources.capetownimage;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnSetRoot);
            this.Controls.Add(this.btnGraphTraversal);
            this.Controls.Add(this.btnShowMST);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnShowGraph);
            this.Controls.Add(this.btnShowHeap);
            this.Controls.Add(this.lblNewStatus);
            this.Controls.Add(this.lblRootNode);
            this.Controls.Add(this.lblSearchId);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.txtRootNode);
            this.Controls.Add(this.txtNewStatus);
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
        private System.Windows.Forms.TextBox txtNewStatus;
        private System.Windows.Forms.TextBox txtRootNode;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.Label lblRootNode;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.Button btnShowHeap;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnShowMST;
        private System.Windows.Forms.Button btnGraphTraversal;
        private System.Windows.Forms.Button btnSetRoot;
        private System.Windows.Forms.Button closeBtn;
    }
}