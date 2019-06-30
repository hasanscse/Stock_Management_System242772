namespace WindowsFormsApp
{
    partial class SearchItemSummaryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyItem = new System.Windows.Forms.ComboBox();
            this.CategoryName = new System.Windows.Forms.ComboBox();
            this.SearchItem = new System.Windows.Forms.Button();
            this.SearchdataGridView = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.SearchdataGridView);
            this.groupBox1.Controls.Add(this.SearchItem);
            this.groupBox1.Controls.Add(this.CategoryName);
            this.groupBox1.Controls.Add(this.CompanyItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Item Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // CompanyItem
            // 
            this.CompanyItem.FormattingEnabled = true;
            this.CompanyItem.Location = new System.Drawing.Point(164, 41);
            this.CompanyItem.Name = "CompanyItem";
            this.CompanyItem.Size = new System.Drawing.Size(121, 21);
            this.CompanyItem.TabIndex = 2;
            // 
            // CategoryName
            // 
            this.CategoryName.FormattingEnabled = true;
            this.CategoryName.Location = new System.Drawing.Point(164, 85);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(121, 21);
            this.CategoryName.TabIndex = 3;
            // 
            // SearchItem
            // 
            this.SearchItem.Location = new System.Drawing.Point(210, 122);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Size = new System.Drawing.Size(75, 23);
            this.SearchItem.TabIndex = 4;
            this.SearchItem.Text = "Search";
            this.SearchItem.UseVisualStyleBackColor = true;
            // 
            // SearchdataGridView
            // 
            this.SearchdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchdataGridView.Location = new System.Drawing.Point(51, 173);
            this.SearchdataGridView.Name = "SearchdataGridView";
            this.SearchdataGridView.Size = new System.Drawing.Size(520, 154);
            this.SearchdataGridView.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(24, 343);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SearchItemSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchItemSummaryForm";
            this.Text = "SearchItemSummary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchItem;
        private System.Windows.Forms.ComboBox CategoryName;
        private System.Windows.Forms.ComboBox CompanyItem;
        private System.Windows.Forms.DataGridView SearchdataGridView;
        private System.Windows.Forms.Button Back;
    }
}