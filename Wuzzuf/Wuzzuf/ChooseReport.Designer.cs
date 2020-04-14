namespace Wuzzuf
{
    partial class ChooseReport
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
            this.JobPosts = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.AverageSalary = new System.Windows.Forms.RadioButton();
            this.showReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JobPosts
            // 
            this.JobPosts.AutoSize = true;
            this.JobPosts.Location = new System.Drawing.Point(71, 56);
            this.JobPosts.Name = "JobPosts";
            this.JobPosts.Size = new System.Drawing.Size(73, 17);
            this.JobPosts.TabIndex = 0;
            this.JobPosts.TabStop = true;
            this.JobPosts.Text = "Job posts ";
            this.JobPosts.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(71, 145);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(164, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "days left to apply in a job post";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // AverageSalary
            // 
            this.AverageSalary.AutoSize = true;
            this.AverageSalary.Location = new System.Drawing.Point(71, 99);
            this.AverageSalary.Name = "AverageSalary";
            this.AverageSalary.Size = new System.Drawing.Size(146, 17);
            this.AverageSalary.TabIndex = 2;
            this.AverageSalary.TabStop = true;
            this.AverageSalary.Text = "Average salary per career";
            this.AverageSalary.UseVisualStyleBackColor = true;
            // 
            // showReport
            // 
            this.showReport.Location = new System.Drawing.Point(81, 201);
            this.showReport.Name = "showReport";
            this.showReport.Size = new System.Drawing.Size(75, 23);
            this.showReport.TabIndex = 3;
            this.showReport.Text = "show";
            this.showReport.UseVisualStyleBackColor = true;
            this.showReport.Click += new System.EventHandler(this.showReport_Click);
            // 
            // ChooseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 236);
            this.Controls.Add(this.showReport);
            this.Controls.Add(this.AverageSalary);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.JobPosts);
            this.Name = "ChooseReport";
            this.Text = "ChooseReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton JobPosts;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton AverageSalary;
        private System.Windows.Forms.Button showReport;
    }
}