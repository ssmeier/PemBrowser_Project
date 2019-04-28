namespace WebBrowser.UI
{
    partial class FilteredHistory
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
            this.searchResults = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.termLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.ItemHeight = 20;
            this.searchResults.Location = new System.Drawing.Point(12, 28);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(538, 364);
            this.searchResults.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(163, 398);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(236, 58);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "OK";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(216, 4);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(130, 20);
            this.termLabel.TabIndex = 2;
            this.termLabel.Text = "Results for: Term";
            this.termLabel.Click += new System.EventHandler(this.termLabel_Click);
            // 
            // FilteredHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 468);
            this.Controls.Add(this.termLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchResults);
            this.Name = "FilteredHistory";
            this.Text = "Search History";
            this.Load += new System.EventHandler(this.FilteredHistoryBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label termLabel;
    }
}