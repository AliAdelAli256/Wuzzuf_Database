namespace Wuzzuf
{
    partial class ViewData
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
            this.tableName = new System.Windows.Forms.ComboBox();
            this.Tables_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnName = new System.Windows.Forms.ComboBox();
            this.conditionValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.rowsSelected = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rowsSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // tableName
            // 
            this.tableName.FormattingEnabled = true;
            this.tableName.Location = new System.Drawing.Point(75, 27);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(121, 21);
            this.tableName.TabIndex = 0;
            this.tableName.SelectedIndexChanged += new System.EventHandler(this.Tables_SelectedIndexChanged);
            // 
            // Tables_Label
            // 
            this.Tables_Label.AutoSize = true;
            this.Tables_Label.Location = new System.Drawing.Point(30, 30);
            this.Tables_Label.Name = "Tables_Label";
            this.Tables_Label.Size = new System.Drawing.Size(39, 13);
            this.Tables_Label.TabIndex = 2;
            this.Tables_Label.Text = "Tables";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Column";
            // 
            // columnName
            // 
            this.columnName.FormattingEnabled = true;
            this.columnName.Location = new System.Drawing.Point(277, 27);
            this.columnName.Name = "columnName";
            this.columnName.Size = new System.Drawing.Size(121, 21);
            this.columnName.TabIndex = 3;
            // 
            // conditionValue
            // 
            this.conditionValue.Location = new System.Drawing.Point(479, 28);
            this.conditionValue.Name = "conditionValue";
            this.conditionValue.Size = new System.Drawing.Size(100, 20);
            this.conditionValue.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Value";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(629, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "search";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // rowsSelected
            // 
            this.rowsSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowsSelected.Location = new System.Drawing.Point(12, 71);
            this.rowsSelected.Name = "rowsSelected";
            this.rowsSelected.Size = new System.Drawing.Size(776, 367);
            this.rowsSelected.TabIndex = 8;
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rowsSelected);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conditionValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnName);
            this.Controls.Add(this.Tables_Label);
            this.Controls.Add(this.tableName);
            this.Name = "ViewData";
            this.Text = "ViewData";
            this.Load += new System.EventHandler(this.ViewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rowsSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tableName;
        private System.Windows.Forms.Label Tables_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox columnName;
        private System.Windows.Forms.TextBox conditionValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView rowsSelected;
    }
}