namespace WindowsFormsApp
{
    partial class StockManagementHome
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
            this.SearchItemSummary = new System.Windows.Forms.LinkLabel();
            this.CategorySetup = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchItemSummary);
            this.groupBox1.Controls.Add(this.CategorySetup);
            this.groupBox1.Location = new System.Drawing.Point(117, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Index";
            // 
            // SearchItemSummary
            // 
            this.SearchItemSummary.AutoSize = true;
            this.SearchItemSummary.Location = new System.Drawing.Point(83, 212);
            this.SearchItemSummary.Name = "SearchItemSummary";
            this.SearchItemSummary.Size = new System.Drawing.Size(144, 13);
            this.SearchItemSummary.TabIndex = 1;
            this.SearchItemSummary.TabStop = true;
            this.SearchItemSummary.Text = "Search & View Items Summary";
            this.SearchItemSummary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SearchItemSummary_LinkClicked);
            // 
            // CategorySetup
            // 
            this.CategorySetup.AutoSize = true;
            this.CategorySetup.Location = new System.Drawing.Point(83, 121);
            this.CategorySetup.Name = "CategorySetup";
            this.CategorySetup.Size = new System.Drawing.Size(80, 13);
            this.CategorySetup.TabIndex = 0;
            this.CategorySetup.TabStop = true;
            this.CategorySetup.Text = "Category Setup";
            this.CategorySetup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CategorySetup_LinkClicked);
            // 
            // StockManagementHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockManagementHome";
            this.Text = "StockManagementHome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel CategorySetup;
        private System.Windows.Forms.LinkLabel SearchItemSummary;
    }
}

