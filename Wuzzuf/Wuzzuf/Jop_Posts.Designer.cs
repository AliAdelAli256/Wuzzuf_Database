namespace Wuzzuf
{
    partial class Jop_Posts
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
            this.jobsDataGridView = new System.Windows.Forms.DataGridView();
            this.filterJobsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.postDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groubBox1 = new System.Windows.Forms.GroupBox();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.careerType_ComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.description_TextBox = new System.Windows.Forms.TextBox();
            this.title_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.jobType_ComboBox = new System.Windows.Forms.ComboBox();
            this.city_ComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.end_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new System.Windows.Forms.Button();
            this.years_TextBox = new System.Windows.Forms.TextBox();
            this.salary_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            this.groubBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobsDataGridView
            // 
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsDataGridView.Location = new System.Drawing.Point(19, 114);
            this.jobsDataGridView.Name = "jobsDataGridView";
            this.jobsDataGridView.RowHeadersWidth = 51;
            this.jobsDataGridView.RowTemplate.Height = 24;
            this.jobsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobsDataGridView.Size = new System.Drawing.Size(349, 306);
            this.jobsDataGridView.TabIndex = 0;
            this.jobsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobsDataGridView_CellClick);
            // 
            // filterJobsButton
            // 
            this.filterJobsButton.Location = new System.Drawing.Point(266, 41);
            this.filterJobsButton.Name = "filterJobsButton";
            this.filterJobsButton.Size = new System.Drawing.Size(102, 28);
            this.filterJobsButton.TabIndex = 1;
            this.filterJobsButton.Text = "Filter Jobs";
            this.filterJobsButton.UseVisualStyleBackColor = true;
            this.filterJobsButton.Click += new System.EventHandler(this.FilterJobsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salary";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(19, 86);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 3;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(125, 86);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(135, 22);
            this.yearsTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Years of Experiance";
            // 
            // postDateTimePicker
            // 
            this.postDateTimePicker.Location = new System.Drawing.Point(19, 41);
            this.postDateTimePicker.Name = "postDateTimePicker";
            this.postDateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.postDateTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Post Date";
            // 
            // groubBox1
            // 
            this.groubBox1.Controls.Add(this.viewAllButton);
            this.groubBox1.Controls.Add(this.postDateTimePicker);
            this.groubBox1.Controls.Add(this.jobsDataGridView);
            this.groubBox1.Controls.Add(this.label3);
            this.groubBox1.Controls.Add(this.filterJobsButton);
            this.groubBox1.Controls.Add(this.label1);
            this.groubBox1.Controls.Add(this.yearsTextBox);
            this.groubBox1.Controls.Add(this.salaryTextBox);
            this.groubBox1.Controls.Add(this.label2);
            this.groubBox1.Location = new System.Drawing.Point(12, 12);
            this.groubBox1.Name = "groubBox1";
            this.groubBox1.Size = new System.Drawing.Size(387, 426);
            this.groubBox1.TabIndex = 8;
            this.groubBox1.TabStop = false;
            this.groubBox1.Text = "View Jobs";
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(266, 80);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(102, 28);
            this.viewAllButton.TabIndex = 8;
            this.viewAllButton.Text = "View All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.ViewAllButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.careerType_ComboBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.description_TextBox);
            this.groupBox1.Controls.Add(this.title_TextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.jobType_ComboBox);
            this.groupBox1.Controls.Add(this.city_ComboBox);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.insertButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.end_DateTimePicker);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.years_TextBox);
            this.groupBox1.Controls.Add(this.salary_TextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(405, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 426);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Jobs";
            // 
            // careerType_ComboBox
            // 
            this.careerType_ComboBox.FormattingEnabled = true;
            this.careerType_ComboBox.Location = new System.Drawing.Point(138, 356);
            this.careerType_ComboBox.Name = "careerType_ComboBox";
            this.careerType_ComboBox.Size = new System.Drawing.Size(241, 24);
            this.careerType_ComboBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Career Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Job Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Description";
            // 
            // Description_TextBox
            // 
            this.description_TextBox.Location = new System.Drawing.Point(138, 174);
            this.description_TextBox.Name = "Description_TextBox";
            this.description_TextBox.Size = new System.Drawing.Size(241, 22);
            this.description_TextBox.TabIndex = 17;
            // 
            // title_TextBox
            // 
            this.title_TextBox.Location = new System.Drawing.Point(138, 130);
            this.title_TextBox.Name = "title_TextBox";
            this.title_TextBox.Size = new System.Drawing.Size(241, 22);
            this.title_TextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "City";
            // 
            // jobType_ComboBox
            // 
            this.jobType_ComboBox.FormattingEnabled = true;
            this.jobType_ComboBox.Location = new System.Drawing.Point(138, 311);
            this.jobType_ComboBox.Name = "jobType_ComboBox";
            this.jobType_ComboBox.Size = new System.Drawing.Size(241, 24);
            this.jobType_ComboBox.TabIndex = 12;
            // 
            // city_ComboBox
            // 
            this.city_ComboBox.FormattingEnabled = true;
            this.city_ComboBox.Location = new System.Drawing.Point(138, 264);
            this.city_ComboBox.Name = "city_ComboBox";
            this.city_ComboBox.Size = new System.Drawing.Size(241, 24);
            this.city_ComboBox.TabIndex = 12;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(279, 392);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 28);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete Job";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(138, 392);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(102, 28);
            this.insertButton.TabIndex = 10;
            this.insertButton.Text = "Insert Job";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "End Date";
            // 
            // end_DateTimePicker
            // 
            this.end_DateTimePicker.Location = new System.Drawing.Point(138, 41);
            this.end_DateTimePicker.Name = "end_DateTimePicker";
            this.end_DateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.end_DateTimePicker.TabIndex = 8;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(6, 392);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(102, 28);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update Job";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // years_TextBox
            // 
            this.years_TextBox.Location = new System.Drawing.Point(138, 219);
            this.years_TextBox.Name = "years_TextBox";
            this.years_TextBox.Size = new System.Drawing.Size(241, 22);
            this.years_TextBox.TabIndex = 5;
            // 
            // salary_TextBox
            // 
            this.salary_TextBox.Location = new System.Drawing.Point(138, 85);
            this.salary_TextBox.Name = "salary_TextBox";
            this.salary_TextBox.Size = new System.Drawing.Size(241, 22);
            this.salary_TextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Experiance Years";
            // 
            // Jop_Posts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groubBox1);
            this.Name = "Jop_Posts";
            this.Text = "Jop_Posts";
            this.Load += new System.EventHandler(this.Jop_Posts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            this.groubBox1.ResumeLayout(false);
            this.groubBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView jobsDataGridView;
        private System.Windows.Forms.Button filterJobsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker postDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groubBox1;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker end_DateTimePicker;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox years_TextBox;
        private System.Windows.Forms.TextBox salary_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox city_ComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox description_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox title_TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox careerType_ComboBox;
        private System.Windows.Forms.ComboBox jobType_ComboBox;
    }
}