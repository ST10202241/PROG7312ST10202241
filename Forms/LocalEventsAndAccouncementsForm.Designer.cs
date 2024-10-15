namespace PROG7312ST10202241
{
    partial class LocalEventsAndAccouncementsForm
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
            this.backToMainMenuBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBoxRecommendations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backToMainMenuBtn
            // 
            this.backToMainMenuBtn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.backToMainMenuBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backToMainMenuBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainMenuBtn.Location = new System.Drawing.Point(0, 417);
            this.backToMainMenuBtn.Name = "backToMainMenuBtn";
            this.backToMainMenuBtn.Size = new System.Drawing.Size(800, 33);
            this.backToMainMenuBtn.TabIndex = 1;
            this.backToMainMenuBtn.Text = "Back To Main Menu";
            this.backToMainMenuBtn.UseVisualStyleBackColor = false;
            this.backToMainMenuBtn.Click += new System.EventHandler(this.backToMainMenuBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(192, 135);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "button1";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(393, 70);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(395, 329);
            this.listBoxEvents.TabIndex = 3;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(266, 207);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategories.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(505, 44);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // listBoxRecommendations
            // 
            this.listBoxRecommendations.FormattingEnabled = true;
            this.listBoxRecommendations.Location = new System.Drawing.Point(36, 188);
            this.listBoxRecommendations.Name = "listBoxRecommendations";
            this.listBoxRecommendations.Size = new System.Drawing.Size(195, 173);
            this.listBoxRecommendations.TabIndex = 6;
            // 
            // LocalEventsAndAccouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxRecommendations);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.backToMainMenuBtn);
            this.Name = "LocalEventsAndAccouncementsForm";
            this.Text = "Local Events And Accouncements";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LocalEventsAndAccouncementsForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backToMainMenuBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBoxRecommendations;
    }
}