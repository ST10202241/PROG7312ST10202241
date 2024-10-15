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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchWithAll = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.listBoxFrequentSearchRecommendations = new System.Windows.Forms.ListBox();
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
            this.searchBtn.Location = new System.Drawing.Point(205, 20);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(98, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search By Name";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
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
            this.comboBoxCategories.Location = new System.Drawing.Point(99, 70);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCategories.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(60, 124);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // listBoxRecommendations
            // 
            this.listBoxRecommendations.FormattingEnabled = true;
            this.listBoxRecommendations.Location = new System.Drawing.Point(15, 188);
            this.listBoxRecommendations.Name = "listBoxRecommendations";
            this.listBoxRecommendations.Size = new System.Drawing.Size(195, 173);
            this.listBoxRecommendations.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(99, 22);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(266, 120);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(97, 23);
            this.btnSearchByDate.TabIndex = 8;
            this.btnSearchByDate.Text = "Search by Date";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(205, 68);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(111, 23);
            this.btnSearchByCategory.TabIndex = 9;
            this.btnSearchByCategory.Text = "Search By Category";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearchByCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name of Event:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date:";
            // 
            // btnSearchWithAll
            // 
            this.btnSearchWithAll.Location = new System.Drawing.Point(84, 159);
            this.btnSearchWithAll.Name = "btnSearchWithAll";
            this.btnSearchWithAll.Size = new System.Drawing.Size(163, 23);
            this.btnSearchWithAll.TabIndex = 13;
            this.btnSearchWithAll.Text = "Search With All";
            this.btnSearchWithAll.UseVisualStyleBackColor = true;
            this.btnSearchWithAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(275, 159);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // listBoxFrequentSearchRecommendations
            // 
            this.listBoxFrequentSearchRecommendations.FormattingEnabled = true;
            this.listBoxFrequentSearchRecommendations.Location = new System.Drawing.Point(230, 188);
            this.listBoxFrequentSearchRecommendations.Name = "listBoxFrequentSearchRecommendations";
            this.listBoxFrequentSearchRecommendations.Size = new System.Drawing.Size(145, 173);
            this.listBoxFrequentSearchRecommendations.TabIndex = 15;
            // 
            // LocalEventsAndAccouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFrequentSearchRecommendations);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.btnSearchWithAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchByCategory);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.searchTextBox);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backToMainMenuBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListBox listBoxRecommendations;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchWithAll;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ListBox listBoxFrequentSearchRecommendations;
    }
}