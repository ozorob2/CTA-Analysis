namespace CTA
{
  partial class Form1
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.top10StationsByRidershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateADAButton = new System.Windows.Forms.ToolStripMenuItem();
			this.findSimilarStations = new System.Windows.Forms.ToolStripMenuItem();
			this.similarStation = new System.Windows.Forms.ToolStripTextBox();
			this.lstStations = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTotalRidership = new System.Windows.Forms.TextBox();
			this.txtAvgDailyRidership = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lstStops = new System.Windows.Forms.ListBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAccessible = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDirection = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLocation = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lstLines = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtWeekdayRidership = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSaturdayRidership = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSundayHolidayRidership = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPercentRidership = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtDatabaseFilename = new System.Windows.Forms.TextBox();
			this.txtStationID = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.top10ToolStripMenuItem,
            this.updateADAButton,
            this.findSimilarStations,
            this.similarStation});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1071, 31);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem1});
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 27);
			this.exitToolStripMenuItem.Text = "&File";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 26);
			this.toolStripMenuItem2.Text = "&Load stations";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 6);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(172, 26);
			this.exitToolStripMenuItem1.Text = "E&xit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
			// 
			// top10ToolStripMenuItem
			// 
			this.top10ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top10StationsByRidershipToolStripMenuItem});
			this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
			this.top10ToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
			this.top10ToolStripMenuItem.Text = "Top-10";
			// 
			// top10StationsByRidershipToolStripMenuItem
			// 
			this.top10StationsByRidershipToolStripMenuItem.Name = "top10StationsByRidershipToolStripMenuItem";
			this.top10StationsByRidershipToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
			this.top10StationsByRidershipToolStripMenuItem.Text = "Top 10 Stations by Ridership";
			this.top10StationsByRidershipToolStripMenuItem.Click += new System.EventHandler(this.top10StationsByRidershipToolStripMenuItem_Click);
			// 
			// updateADAButton
			// 
			this.updateADAButton.Name = "updateADAButton";
			this.updateADAButton.Size = new System.Drawing.Size(105, 27);
			this.updateADAButton.Text = "Update ADA";
			this.updateADAButton.Click += new System.EventHandler(this.updateADAButton_Click);
			// 
			// findSimilarStations
			// 
			this.findSimilarStations.Name = "findSimilarStations";
			this.findSimilarStations.Size = new System.Drawing.Size(49, 27);
			this.findSimilarStations.Text = "Find";
			this.findSimilarStations.Click += new System.EventHandler(this.findSimilarStations_Click);
			// 
			// similarStation
			// 
			this.similarStation.Name = "similarStation";
			this.similarStation.Size = new System.Drawing.Size(100, 27);
			// 
			// lstStations
			// 
			this.lstStations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstStations.FormattingEnabled = true;
			this.lstStations.HorizontalScrollbar = true;
			this.lstStations.ItemHeight = 25;
			this.lstStations.Location = new System.Drawing.Point(12, 40);
			this.lstStations.Name = "lstStations";
			this.lstStations.ScrollAlwaysVisible = true;
			this.lstStations.Size = new System.Drawing.Size(331, 404);
			this.lstStations.TabIndex = 1;
			this.lstStations.SelectedIndexChanged += new System.EventHandler(this.lstStations_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(378, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Total Ridership:";
			// 
			// txtTotalRidership
			// 
			this.txtTotalRidership.Location = new System.Drawing.Point(525, 51);
			this.txtTotalRidership.Name = "txtTotalRidership";
			this.txtTotalRidership.ReadOnly = true;
			this.txtTotalRidership.Size = new System.Drawing.Size(159, 34);
			this.txtTotalRidership.TabIndex = 3;
			// 
			// txtAvgDailyRidership
			// 
			this.txtAvgDailyRidership.Location = new System.Drawing.Point(525, 91);
			this.txtAvgDailyRidership.Name = "txtAvgDailyRidership";
			this.txtAvgDailyRidership.ReadOnly = true;
			this.txtAvgDailyRidership.Size = new System.Drawing.Size(159, 34);
			this.txtAvgDailyRidership.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(378, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(169, 29);
			this.label2.TabIndex = 4;
			this.label2.Text = "Avg Ridership:";
			// 
			// lstStops
			// 
			this.lstStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstStops.FormattingEnabled = true;
			this.lstStops.HorizontalScrollbar = true;
			this.lstStops.ItemHeight = 25;
			this.lstStops.Location = new System.Drawing.Point(382, 220);
			this.lstStops.Name = "lstStops";
			this.lstStops.ScrollAlwaysVisible = true;
			this.lstStops.Size = new System.Drawing.Size(302, 204);
			this.lstStops.TabIndex = 6;
			this.lstStops.SelectedIndexChanged += new System.EventHandler(this.lstStops_SelectedIndexChanged);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 509);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1071, 25);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(382, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 29);
			this.label3.TabIndex = 8;
			this.label3.Text = "Stops at this station:";
			// 
			// txtAccessible
			// 
			this.txtAccessible.Location = new System.Drawing.Point(937, 210);
			this.txtAccessible.Name = "txtAccessible";
			this.txtAccessible.ReadOnly = true;
			this.txtAccessible.Size = new System.Drawing.Size(77, 34);
			this.txtAccessible.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(736, 213);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(248, 29);
			this.label4.TabIndex = 9;
			this.label4.Text = "Handicap accessible?";
			// 
			// txtDirection
			// 
			this.txtDirection.Location = new System.Drawing.Point(937, 246);
			this.txtDirection.Name = "txtDirection";
			this.txtDirection.ReadOnly = true;
			this.txtDirection.Size = new System.Drawing.Size(77, 34);
			this.txtDirection.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(736, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(205, 29);
			this.label5.TabIndex = 11;
			this.label5.Text = "Direction of travel:";
			// 
			// txtLocation
			// 
			this.txtLocation.Location = new System.Drawing.Point(740, 307);
			this.txtLocation.Name = "txtLocation";
			this.txtLocation.ReadOnly = true;
			this.txtLocation.Size = new System.Drawing.Size(274, 34);
			this.txtLocation.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(736, 281);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 29);
			this.label6.TabIndex = 13;
			this.label6.Text = "Location:";
			// 
			// lstLines
			// 
			this.lstLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstLines.FormattingEnabled = true;
			this.lstLines.ItemHeight = 25;
			this.lstLines.Location = new System.Drawing.Point(740, 375);
			this.lstLines.Name = "lstLines";
			this.lstLines.Size = new System.Drawing.Size(274, 104);
			this.lstLines.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(736, 348);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 29);
			this.label7.TabIndex = 16;
			this.label7.Text = "Lines:";
			// 
			// txtWeekdayRidership
			// 
			this.txtWeekdayRidership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWeekdayRidership.Location = new System.Drawing.Point(852, 80);
			this.txtWeekdayRidership.Name = "txtWeekdayRidership";
			this.txtWeekdayRidership.ReadOnly = true;
			this.txtWeekdayRidership.Size = new System.Drawing.Size(132, 30);
			this.txtWeekdayRidership.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(736, 85);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 25);
			this.label8.TabIndex = 17;
			this.label8.Text = "Weekday:";
			// 
			// txtSaturdayRidership
			// 
			this.txtSaturdayRidership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSaturdayRidership.Location = new System.Drawing.Point(852, 110);
			this.txtSaturdayRidership.Name = "txtSaturdayRidership";
			this.txtSaturdayRidership.ReadOnly = true;
			this.txtSaturdayRidership.Size = new System.Drawing.Size(132, 30);
			this.txtSaturdayRidership.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(736, 115);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(97, 25);
			this.label9.TabIndex = 19;
			this.label9.Text = "Saturday:";
			// 
			// txtSundayHolidayRidership
			// 
			this.txtSundayHolidayRidership.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSundayHolidayRidership.Location = new System.Drawing.Point(852, 140);
			this.txtSundayHolidayRidership.Name = "txtSundayHolidayRidership";
			this.txtSundayHolidayRidership.ReadOnly = true;
			this.txtSundayHolidayRidership.Size = new System.Drawing.Size(132, 30);
			this.txtSundayHolidayRidership.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(736, 145);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(125, 25);
			this.label10.TabIndex = 21;
			this.label10.Text = "Sun/Holiday:";
			// 
			// txtPercentRidership
			// 
			this.txtPercentRidership.Location = new System.Drawing.Point(525, 131);
			this.txtPercentRidership.Name = "txtPercentRidership";
			this.txtPercentRidership.ReadOnly = true;
			this.txtPercentRidership.Size = new System.Drawing.Size(159, 34);
			this.txtPercentRidership.TabIndex = 24;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(378, 136);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(151, 29);
			this.label11.TabIndex = 23;
			this.label11.Text = "% Ridership:";
			// 
			// txtDatabaseFilename
			// 
			this.txtDatabaseFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDatabaseFilename.Location = new System.Drawing.Point(12, 464);
			this.txtDatabaseFilename.Name = "txtDatabaseFilename";
			this.txtDatabaseFilename.Size = new System.Drawing.Size(672, 30);
			this.txtDatabaseFilename.TabIndex = 25;
			this.txtDatabaseFilename.Text = "|DataDirectory|\\CTA.mdf";
			// 
			// txtStationID
			// 
			this.txtStationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStationID.Location = new System.Drawing.Point(852, 49);
			this.txtStationID.Name = "txtStationID";
			this.txtStationID.ReadOnly = true;
			this.txtStationID.Size = new System.Drawing.Size(132, 30);
			this.txtStationID.TabIndex = 27;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(736, 54);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(103, 25);
			this.label12.TabIndex = 26;
			this.label12.Text = "Station ID:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Khaki;
			this.ClientSize = new System.Drawing.Size(1071, 534);
			this.Controls.Add(this.txtStationID);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtDatabaseFilename);
			this.Controls.Add(this.txtPercentRidership);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtSundayHolidayRidership);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtSaturdayRidership);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtWeekdayRidership);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lstLines);
			this.Controls.Add(this.txtLocation);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDirection);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtAccessible);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.lstStops);
			this.Controls.Add(this.txtAvgDailyRidership);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTotalRidership);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstStations);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "CTA Ridership Analysis";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    private System.Windows.Forms.ListBox lstStations;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtTotalRidership;
    private System.Windows.Forms.TextBox txtAvgDailyRidership;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ListBox lstStops;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtAccessible;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtDirection;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtLocation;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox lstLines;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtWeekdayRidership;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtSaturdayRidership;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtSundayHolidayRidership;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
    private System.Windows.Forms.TextBox txtPercentRidership;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ToolStripMenuItem top10StationsByRidershipToolStripMenuItem;
    private System.Windows.Forms.TextBox txtDatabaseFilename;
    private System.Windows.Forms.TextBox txtStationID;
    private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ToolStripMenuItem updateADAButton;
		private System.Windows.Forms.ToolStripMenuItem findSimilarStations;
		private System.Windows.Forms.ToolStripTextBox similarStation;
	}
}

