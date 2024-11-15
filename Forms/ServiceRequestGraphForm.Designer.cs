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
            this.treeViewGraph = new System.Windows.Forms.TreeView();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.btnDisplayGraph = new System.Windows.Forms.Button();
            this.btnAddDependency = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.txtFromRequestId = new System.Windows.Forms.TextBox();
            this.txtToRequestId = new System.Windows.Forms.TextBox();
            this.txtStartRequestId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewGraph
            // 
            this.treeViewGraph.Location = new System.Drawing.Point(178, 63);
            this.treeViewGraph.Name = "treeViewGraph";
            this.treeViewGraph.Size = new System.Drawing.Size(121, 97);
            this.treeViewGraph.TabIndex = 0;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(415, 161);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(240, 150);
            this.DataGridView.TabIndex = 1;
            // 
            // btnDisplayGraph
            // 
            this.btnDisplayGraph.Location = new System.Drawing.Point(67, 316);
            this.btnDisplayGraph.Name = "btnDisplayGraph";
            this.btnDisplayGraph.Size = new System.Drawing.Size(128, 23);
            this.btnDisplayGraph.TabIndex = 2;
            this.btnDisplayGraph.Text = "Display the graph";
            this.btnDisplayGraph.UseVisualStyleBackColor = true;
            this.btnDisplayGraph.Click += new System.EventHandler(this.btnDisplayGraph_Click);
            // 
            // btnAddDependency
            // 
            this.btnAddDependency.Location = new System.Drawing.Point(223, 316);
            this.btnAddDependency.Name = "btnAddDependency";
            this.btnAddDependency.Size = new System.Drawing.Size(112, 23);
            this.btnAddDependency.TabIndex = 3;
            this.btnAddDependency.Text = "Add Dependency";
            this.btnAddDependency.UseVisualStyleBackColor = true;
            this.btnAddDependency.Click += new System.EventHandler(this.btnAddDependency_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(341, 316);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(238, 23);
            this.btnBFS.TabIndex = 4;
            this.btnBFS.Text = "Search for service request relationships";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // txtFromRequestId
            // 
            this.txtFromRequestId.Location = new System.Drawing.Point(251, 223);
            this.txtFromRequestId.Name = "txtFromRequestId";
            this.txtFromRequestId.Size = new System.Drawing.Size(100, 20);
            this.txtFromRequestId.TabIndex = 5;
            // 
            // txtToRequestId
            // 
            this.txtToRequestId.Location = new System.Drawing.Point(99, 227);
            this.txtToRequestId.Name = "txtToRequestId";
            this.txtToRequestId.Size = new System.Drawing.Size(100, 20);
            this.txtToRequestId.TabIndex = 6;
            // 
            // txtStartRequestId
            // 
            this.txtStartRequestId.Location = new System.Drawing.Point(193, 277);
            this.txtStartRequestId.Name = "txtStartRequestId";
            this.txtStartRequestId.Size = new System.Drawing.Size(100, 20);
            this.txtStartRequestId.TabIndex = 7;
            // 
            // ServiceRequestGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtStartRequestId);
            this.Controls.Add(this.txtToRequestId);
            this.Controls.Add(this.txtFromRequestId);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.btnAddDependency);
            this.Controls.Add(this.btnDisplayGraph);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.treeViewGraph);
            this.Name = "ServiceRequestGraphForm";
            this.Text = "ServiceRequestGraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewGraph;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnDisplayGraph;
        private System.Windows.Forms.Button btnAddDependency;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.TextBox txtFromRequestId;
        private System.Windows.Forms.TextBox txtToRequestId;
        private System.Windows.Forms.TextBox txtStartRequestId;
    }
}