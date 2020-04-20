namespace Wuzzuf
{
    partial class Main_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.openReports = new System.Windows.Forms.Button();
            this.jobPost_btn = new System.Windows.Forms.Button();
            this.login_register_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(110, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Wuzzuf Form";
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(42, 154);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(254, 55);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View Data on Wuzzuf";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // openReports
            // 
            this.openReports.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openReports.Location = new System.Drawing.Point(42, 249);
            this.openReports.Name = "openReports";
            this.openReports.Size = new System.Drawing.Size(254, 55);
            this.openReports.TabIndex = 3;
            this.openReports.Text = "Reports";
            this.openReports.UseVisualStyleBackColor = true;
            this.openReports.Click += new System.EventHandler(this.openReports_Click);
            // 
            // jobPost_btn
            // 
            this.jobPost_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobPost_btn.Location = new System.Drawing.Point(409, 154);
            this.jobPost_btn.Name = "jobPost_btn";
            this.jobPost_btn.Size = new System.Drawing.Size(254, 55);
            this.jobPost_btn.TabIndex = 4;
            this.jobPost_btn.Text = "Manage Job Posts";
            this.jobPost_btn.UseVisualStyleBackColor = true;
            this.jobPost_btn.Click += new System.EventHandler(this.JobPost_btn_Click);
            // 
            // login_register_btn
            // 
            this.login_register_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_register_btn.Location = new System.Drawing.Point(409, 249);
            this.login_register_btn.Name = "login_register_btn";
            this.login_register_btn.Size = new System.Drawing.Size(254, 55);
            this.login_register_btn.TabIndex = 5;
            this.login_register_btn.Text = "Register \\ Login";
            this.login_register_btn.UseVisualStyleBackColor = true;
            this.login_register_btn.Click += new System.EventHandler(this.Login_register_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(226, 341);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(254, 55);
            this.show_btn.TabIndex = 6;
            this.show_btn.Text = "Show Job Type";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.login_register_btn);
            this.Controls.Add(this.jobPost_btn);
            this.Controls.Add(this.openReports);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.label1);
            this.Name = "Main_Form";
            this.Text = "Wuzzuf Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button openReports;
        private System.Windows.Forms.Button jobPost_btn;
        private System.Windows.Forms.Button login_register_btn;
        private System.Windows.Forms.Button show_btn;
    }
}

