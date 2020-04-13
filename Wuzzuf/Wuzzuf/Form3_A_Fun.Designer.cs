namespace Wuzzuf
{
    partial class Form3_A_Fun
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.showCompaniesButton = new System.Windows.Forms.Button();
            this.selectColumnComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.jobTypesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 115);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(776, 323);
            this.DataGrid.TabIndex = 0;
            // 
            // showCompaniesButton
            // 
            this.showCompaniesButton.Location = new System.Drawing.Point(640, 70);
            this.showCompaniesButton.Name = "showCompaniesButton";
            this.showCompaniesButton.Size = new System.Drawing.Size(148, 28);
            this.showCompaniesButton.TabIndex = 1;
            this.showCompaniesButton.Text = "Show Companies";
            this.showCompaniesButton.UseVisualStyleBackColor = true;
            this.showCompaniesButton.Click += new System.EventHandler(this.showCompaniesButton_Click);
            // 
            // selectColumnComboBox
            // 
            this.selectColumnComboBox.FormattingEnabled = true;
            this.selectColumnComboBox.Location = new System.Drawing.Point(488, 74);
            this.selectColumnComboBox.Name = "selectColumnComboBox";
            this.selectColumnComboBox.Size = new System.Drawing.Size(121, 24);
            this.selectColumnComboBox.TabIndex = 2;
            this.selectColumnComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectColumnComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job Type: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jobTypesComboBox
            // 
            this.jobTypesComboBox.FormattingEnabled = true;
            this.jobTypesComboBox.Location = new System.Drawing.Point(97, 15);
            this.jobTypesComboBox.Name = "jobTypesComboBox";
            this.jobTypesComboBox.Size = new System.Drawing.Size(121, 24);
            this.jobTypesComboBox.TabIndex = 6;
            // 
            // Form3_A_Fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jobTypesComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectColumnComboBox);
            this.Controls.Add(this.showCompaniesButton);
            this.Controls.Add(this.DataGrid);
            this.Name = "Form3_A_Fun";
            this.Text = "Form3_A_Fun";
            this.Load += new System.EventHandler(this.Form3_A_Fun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button showCompaniesButton;
        private System.Windows.Forms.ComboBox selectColumnComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox jobTypesComboBox;
    }
}