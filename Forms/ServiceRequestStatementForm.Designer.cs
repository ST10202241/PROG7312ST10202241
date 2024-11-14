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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRequestId = new System.Windows.Forms.TextBox();
            this.txtNewRequestId = new System.Windows.Forms.TextBox();
            this.txtNewStatus = new System.Windows.Forms.TextBox();
            this.txtNewDescription = new System.Windows.Forms.TextBox();
            this.txtNewPriority = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PROG7312ST10202241.Properties.Resources.construccy;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 418);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(251, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // txtRequestId
            // 
            this.txtRequestId.Location = new System.Drawing.Point(432, 153);
            this.txtRequestId.Name = "txtRequestId";
            this.txtRequestId.Size = new System.Drawing.Size(100, 20);
            this.txtRequestId.TabIndex = 4;
            // 
            // txtNewRequestId
            // 
            this.txtNewRequestId.Location = new System.Drawing.Point(345, 239);
            this.txtNewRequestId.Name = "txtNewRequestId";
            this.txtNewRequestId.Size = new System.Drawing.Size(100, 20);
            this.txtNewRequestId.TabIndex = 5;
            // 
            // txtNewStatus
            // 
            this.txtNewStatus.Location = new System.Drawing.Point(328, 295);
            this.txtNewStatus.Name = "txtNewStatus";
            this.txtNewStatus.Size = new System.Drawing.Size(100, 20);
            this.txtNewStatus.TabIndex = 6;
            // 
            // txtNewDescription
            // 
            this.txtNewDescription.Location = new System.Drawing.Point(560, 323);
            this.txtNewDescription.Name = "txtNewDescription";
            this.txtNewDescription.Size = new System.Drawing.Size(100, 20);
            this.txtNewDescription.TabIndex = 7;
            // 
            // txtNewPriority
            // 
            this.txtNewPriority.Location = new System.Drawing.Point(399, 365);
            this.txtNewPriority.Name = "txtNewPriority";
            this.txtNewPriority.Size = new System.Drawing.Size(100, 20);
            this.txtNewPriority.TabIndex = 8;
            // 
            // ServiceRequestStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNewPriority);
            this.Controls.Add(this.txtNewDescription);
            this.Controls.Add(this.txtNewStatus);
            this.Controls.Add(this.txtNewRequestId);
            this.Controls.Add(this.txtRequestId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ServiceRequestStatementForm";
            this.Text = "Service Request Statement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceRequestStatementForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRequestId;
        private System.Windows.Forms.TextBox txtNewRequestId;
        private System.Windows.Forms.TextBox txtNewStatus;
        private System.Windows.Forms.TextBox txtNewDescription;
        private System.Windows.Forms.TextBox txtNewPriority;
    }
}