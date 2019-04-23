namespace WebBrowser.UI
{
    partial class HistoryManagerUI
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.historyItemBox = new System.Windows.Forms.GroupBox();
            this.navigateButton = new System.Windows.Forms.Button();
            this.deleteHistoryItem = new System.Windows.Forms.Button();
            this.historyItem = new System.Windows.Forms.Label();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.historyItemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(482, 744);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 26);
            this.textBox1.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(578, 115);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(145, 36);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // historyItemBox
            // 
            this.historyItemBox.Controls.Add(this.navigateButton);
            this.historyItemBox.Controls.Add(this.deleteHistoryItem);
            this.historyItemBox.Controls.Add(this.historyItem);
            this.historyItemBox.Location = new System.Drawing.Point(514, 219);
            this.historyItemBox.Name = "historyItemBox";
            this.historyItemBox.Size = new System.Drawing.Size(264, 186);
            this.historyItemBox.TabIndex = 3;
            this.historyItemBox.TabStop = false;
            this.historyItemBox.Text = "Selection";
            // 
            // navigateButton
            // 
            this.navigateButton.Location = new System.Drawing.Point(6, 136);
            this.navigateButton.Name = "navigateButton";
            this.navigateButton.Size = new System.Drawing.Size(118, 44);
            this.navigateButton.TabIndex = 2;
            this.navigateButton.Text = "Go";
            this.navigateButton.UseVisualStyleBackColor = true;
            // 
            // deleteHistoryItem
            // 
            this.deleteHistoryItem.Location = new System.Drawing.Point(140, 136);
            this.deleteHistoryItem.Name = "deleteHistoryItem";
            this.deleteHistoryItem.Size = new System.Drawing.Size(118, 44);
            this.deleteHistoryItem.TabIndex = 1;
            this.deleteHistoryItem.Text = "Delete";
            this.deleteHistoryItem.UseVisualStyleBackColor = true;
            // 
            // historyItem
            // 
            this.historyItem.AutoSize = true;
            this.historyItem.Location = new System.Drawing.Point(83, 53);
            this.historyItem.Name = "historyItem";
            this.historyItem.Size = new System.Drawing.Size(87, 20);
            this.historyItem.TabIndex = 0;
            this.historyItem.Text = "histroyItem";
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Location = new System.Drawing.Point(514, 431);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(264, 39);
            this.clearHistoryButton.TabIndex = 4;
            this.clearHistoryButton.Text = "Clear History";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // HistoryManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 780);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.historyItemBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "HistoryManagerUI";
            this.Text = "HistoryManagerUI";
            this.Load += new System.EventHandler(this.HistoryManagerUI_Load);
            this.historyItemBox.ResumeLayout(false);
            this.historyItemBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox historyItemBox;
        private System.Windows.Forms.Button deleteHistoryItem;
        private System.Windows.Forms.Label historyItem;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.Button navigateButton;
    }
}