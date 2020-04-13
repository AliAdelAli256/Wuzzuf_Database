namespace Wuzzuf
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Load_Information = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.USERINFO = new System.Windows.Forms.RadioButton();
            this.save_btn = new System.Windows.Forms.Button();
            this.companiesCheckBox = new System.Windows.Forms.CheckBox();
            this.applicantsCheckBox = new System.Windows.Forms.CheckBox();
            this.RecruitersChechkbox = new System.Windows.Forms.CheckBox();
            this.AdminsChechkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 256);
            this.dataGridView1.TabIndex = 3;
            // 
            // Load_Information
            // 
            this.Load_Information.Location = new System.Drawing.Point(360, 137);
            this.Load_Information.Name = "Load_Information";
            this.Load_Information.Size = new System.Drawing.Size(118, 29);
            this.Load_Information.TabIndex = 4;
            this.Load_Information.Text = "Load Information";
            this.Load_Information.UseVisualStyleBackColor = true;
            this.Load_Information.Click += new System.EventHandler(this.Load_Information_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdminsChechkbox);
            this.groupBox1.Controls.Add(this.RecruitersChechkbox);
            this.groupBox1.Controls.Add(this.applicantsCheckBox);
            this.groupBox1.Controls.Add(this.companiesCheckBox);
            this.groupBox1.Controls.Add(this.USERINFO);
            this.groupBox1.Location = new System.Drawing.Point(297, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 119);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // USERINFO
            // 
            this.USERINFO.AutoSize = true;
            this.USERINFO.Location = new System.Drawing.Point(7, 19);
            this.USERINFO.Name = "USERINFO";
            this.USERINFO.Size = new System.Drawing.Size(80, 17);
            this.USERINFO.TabIndex = 3;
            this.USERINFO.TabStop = true;
            this.USERINFO.Text = "USERINFO";
            this.USERINFO.UseVisualStyleBackColor = true;
            this.USERINFO.CheckedChanged += new System.EventHandler(this.USERINFO_CheckedChanged);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(664, 137);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(93, 29);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save changes";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // companiesCheckBox
            // 
            this.companiesCheckBox.AutoSize = true;
            this.companiesCheckBox.Enabled = false;
            this.companiesCheckBox.Location = new System.Drawing.Point(39, 42);
            this.companiesCheckBox.Name = "companiesCheckBox";
            this.companiesCheckBox.Size = new System.Drawing.Size(78, 17);
            this.companiesCheckBox.TabIndex = 7;
            this.companiesCheckBox.Text = "Companies";
            this.companiesCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.companiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // applicantsCheckBox
            // 
            this.applicantsCheckBox.AutoSize = true;
            this.applicantsCheckBox.Enabled = false;
            this.applicantsCheckBox.Location = new System.Drawing.Point(39, 65);
            this.applicantsCheckBox.Name = "applicantsCheckBox";
            this.applicantsCheckBox.Size = new System.Drawing.Size(75, 17);
            this.applicantsCheckBox.TabIndex = 8;
            this.applicantsCheckBox.Text = "Applicants";
            this.applicantsCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.applicantsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RecruitersChechkbox
            // 
            this.RecruitersChechkbox.AutoSize = true;
            this.RecruitersChechkbox.Enabled = false;
            this.RecruitersChechkbox.Location = new System.Drawing.Point(139, 42);
            this.RecruitersChechkbox.Name = "RecruitersChechkbox";
            this.RecruitersChechkbox.Size = new System.Drawing.Size(74, 17);
            this.RecruitersChechkbox.TabIndex = 9;
            this.RecruitersChechkbox.Text = "Recruiters";
            this.RecruitersChechkbox.UseVisualStyleBackColor = true;
            // 
            // AdminsChechkbox
            // 
            this.AdminsChechkbox.AutoSize = true;
            this.AdminsChechkbox.Enabled = false;
            this.AdminsChechkbox.Location = new System.Drawing.Point(139, 65);
            this.AdminsChechkbox.Name = "AdminsChechkbox";
            this.AdminsChechkbox.Size = new System.Drawing.Size(60, 17);
            this.AdminsChechkbox.TabIndex = 10;
            this.AdminsChechkbox.Text = "Admins";
            this.AdminsChechkbox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Load_Information);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Load_Information;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.RadioButton USERINFO;
        private System.Windows.Forms.CheckBox applicantsCheckBox;
        private System.Windows.Forms.CheckBox companiesCheckBox;
        private System.Windows.Forms.CheckBox AdminsChechkbox;
        private System.Windows.Forms.CheckBox RecruitersChechkbox;
    }
}