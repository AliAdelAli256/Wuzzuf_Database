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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showCompaniesButton = new System.Windows.Forms.Button();
            this.selectColumnComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 323);
            this.dataGridView1.TabIndex = 0;
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
            // Form3_A_Fun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectColumnComboBox);
            this.Controls.Add(this.showCompaniesButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3_A_Fun";
            this.Text = "Form3_A_Fun";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showCompaniesButton;
        private System.Windows.Forms.ComboBox selectColumnComboBox;
    }
}