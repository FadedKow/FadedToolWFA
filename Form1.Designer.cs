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
            this.cpuSwitch = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.41679F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.58321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.Controls.Add(this.versionSelectList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.spoofButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.creatorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.whatThisDoesLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.whatIsThisLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpuSwitch, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.88733F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.11267F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // versionSelectList
            // 
            this.versionSelectList.BackColor = System.Drawing.Color.DimGray;
            this.versionSelectList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionSelectList.ForeColor = System.Drawing.Color.Silver;
            this.versionSelectList.FormattingEnabled = true;
            this.versionSelectList.Items.AddRange(new object[] {
            "1.16.40",
            "1.16.100",
            "1.16.201",
            "1.16.210",
            "1.16.221",
            "1.17.0",
            "1.17.2",
            "1.17.10/1.17.11",
            "1.17.40",
            "1.17.41",
            "1.18.0",
            "1.18.2",
            "1.18.10.4",
            "1.18.12.1",
            "1.18.31"});
            this.versionSelectList.Location = new System.Drawing.Point(332, 2);
            this.versionSelectList.Margin = new System.Windows.Forms.Padding(2);
            this.versionSelectList.Name = "versionSelectList";
            this.versionSelectList.Size = new System.Drawing.Size(163, 162);
            this.versionSelectList.TabIndex = 0;
            this.versionSelectList.SelectedIndexChanged += new System.EventHandler(this.versionSelectList_SelectedIndexChanged);
            // 
            // spoofButton
            // 
            this.spoofButton.BackColor = System.Drawing.Color.DimGray;
            this.spoofButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.spoofButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spoofButton.Location = new System.Drawing.Point(332, 348);
            this.spoofButton.Margin = new System.Windows.Forms.Padding(2);
            this.spoofButton.Name = "spoofButton";
            this.spoofButton.Size = new System.Drawing.Size(163, 43);
            this.spoofButton.TabIndex = 1;
            this.spoofButton.Text = "Spoof";
            this.spoofButton.UseVisualStyleBackColor = false;
            this.spoofButton.Click += new System.EventHandler(this.spoofButton_Click);
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.creatorLabel.Location = new System.Drawing.Point(2, 437);
            this.creatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(326, 13);
            this.creatorLabel.TabIndex = 2;
            this.creatorLabel.Text = "Created by Founder#8300";
            // 
            // whatThisDoesLabel
            // 
            this.whatThisDoesLabel.AutoSize = true;
            this.whatThisDoesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.whatThisDoesLabel.Location = new System.Drawing.Point(2, 0);
            this.whatThisDoesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whatThisDoesLabel.Name = "whatThisDoesLabel";
            this.whatThisDoesLabel.Size = new System.Drawing.Size(326, 91);
            this.whatThisDoesLabel.TabIndex = 3;
            this.whatThisDoesLabel.Text = resources.GetString("whatThisDoesLabel.Text");
            // 
            // whatIsThisLabel
            // 
            this.whatIsThisLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.whatIsThisLabel, 3);
            this.whatIsThisLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.whatIsThisLabel.Location = new System.Drawing.Point(2, 166);
            this.whatIsThisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whatIsThisLabel.Name = "whatIsThisLabel";
            this.whatIsThisLabel.Size = new System.Drawing.Size(796, 143);
            this.whatIsThisLabel.TabIndex = 4;
            this.whatIsThisLabel.Text = resources.GetString("whatIsThisLabel.Text");
            // 
            // cpuSwitch
            // 
            this.cpuSwitch.AutoSize = true;
            this.cpuSwitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpuSwitch.Location = new System.Drawing.Point(500, 3);
            this.cpuSwitch.Name = "cpuSwitch";
            this.cpuSwitch.Size = new System.Drawing.Size(297, 17);
            this.cpuSwitch.TabIndex = 5;
            this.cpuSwitch.Text = "x86 MC - 1.18.2 DID ONLY";
            this.cpuSwitch.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.CheckBox cpuSwitch;
    }
}

