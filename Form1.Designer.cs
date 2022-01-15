namespace FadedToolWFA
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.versionSelectList = new System.Windows.Forms.ListBox();
            this.spoofButton = new System.Windows.Forms.Button();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.whatThisDoesLabel = new System.Windows.Forms.Label();
            this.whatIsThisLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.41679F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.58321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tableLayoutPanel1.Controls.Add(this.versionSelectList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.spoofButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.creatorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.whatThisDoesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.whatIsThisLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // versionSelectList
            // 
            this.versionSelectList.BackColor = System.Drawing.Color.DimGray;
            this.versionSelectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionSelectList.ForeColor = System.Drawing.Color.Silver;
            this.versionSelectList.FormattingEnabled = true;
            this.versionSelectList.ItemHeight = 16;
            this.versionSelectList.Items.AddRange(new object[] {
            "1.18.2",
            "1.18.0",
            "1.17.41",
            "1.17.40",
            "1.17.10/1.17.11",
            "1.17.2",
            "1.17.0",
            "1.16.221",
            "1.16.210",
            "1.16.201",
            "1.16.100",
            "1.16.40"});
            this.versionSelectList.Location = new System.Drawing.Point(446, 3);
            this.versionSelectList.Name = "versionSelectList";
            this.versionSelectList.Size = new System.Drawing.Size(218, 198);
            this.versionSelectList.TabIndex = 0;
            this.versionSelectList.SelectedIndexChanged += new System.EventHandler(this.versionSelectList_SelectedIndexChanged);
            // 
            // spoofButton
            // 
            this.spoofButton.BackColor = System.Drawing.Color.DimGray;
            this.spoofButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.spoofButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spoofButton.Location = new System.Drawing.Point(446, 429);
            this.spoofButton.Name = "spoofButton";
            this.spoofButton.Size = new System.Drawing.Size(218, 53);
            this.spoofButton.TabIndex = 1;
            this.spoofButton.Text = "Spoof";
            this.spoofButton.UseVisualStyleBackColor = false;
            this.spoofButton.Click += new System.EventHandler(this.spoofButton_Click);
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.creatorLabel.Location = new System.Drawing.Point(3, 538);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(437, 16);
            this.creatorLabel.TabIndex = 2;
            this.creatorLabel.Text = "Created by Founder#8300";
            // 
            // whatThisDoesLabel
            // 
            this.whatThisDoesLabel.AutoSize = true;
            this.whatThisDoesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.whatThisDoesLabel.Location = new System.Drawing.Point(3, 0);
            this.whatThisDoesLabel.Name = "whatThisDoesLabel";
            this.whatThisDoesLabel.Size = new System.Drawing.Size(437, 96);
            this.whatThisDoesLabel.TabIndex = 3;
            this.whatThisDoesLabel.Text = "FadedTool - Simple Gui Edition\r\n\r\nHow To Use:\r\nStep 1: Select Your Minecraft Vers" +
    "ion In The List.\r\nStep 2: Press Spoof\r\nThat\'s all, you can close the app now or " +
    "keep it open for later.";
            // 
            // whatIsThisLabel
            // 
            this.whatIsThisLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.whatIsThisLabel, 3);
            this.whatIsThisLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.whatIsThisLabel.Location = new System.Drawing.Point(3, 204);
            this.whatIsThisLabel.Name = "whatIsThisLabel";
            this.whatIsThisLabel.Size = new System.Drawing.Size(1061, 176);
            this.whatIsThisLabel.TabIndex = 4;
            this.whatIsThisLabel.Text = resources.GetString("whatIsThisLabel.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FadedTool";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox versionSelectList;
        private System.Windows.Forms.Button spoofButton;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label whatThisDoesLabel;
        private System.Windows.Forms.Label whatIsThisLabel;
    }
}

