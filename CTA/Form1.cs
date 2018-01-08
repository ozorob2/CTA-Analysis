using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
// N-tier C# and SQL program to analyze CTA Ridership data.
//
// Omar Zorob
// U. of Illinois, Chicago
// CS341, Fall 2017
// Project #08
//

namespace CTA
{

  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //
      // setup GUI:
      //
      this.lstStations.Items.Add("");
      this.lstStations.Items.Add("[ Use File>>Load to display L stations... ]");
      this.lstStations.Items.Add("");

      this.lstStations.ClearSelected();

      toolStripStatusLabel1.Text = string.Format("Number of stations:  0");

      // 
      // open-close connect to get SQL Server started:
      //
      try
      {
        string filename = this.txtDatabaseFilename.Text;
        BusinessTier.Business bizTier;
                    
        bizTier = new BusinessTier.Business(filename);
        bizTier.TestConnection();
      }
      catch
      {
        //
        // ignore any exception that occurs, goal is just to startup
        //
      }
    }


    //
    // File>>Exit:
    //
    private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.Close();
    }


    //
    // File>>Load Stations:
    //
    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      //
      // clear the UI of any current results:
      //
      ClearStationUI(true /*clear stations*/);

	  try
	  {

		//
		// now load the stations from the database:
		//
		string filename = this.txtDatabaseFilename.Text;
		BusinessTier.Business bizTier;

		bizTier = new BusinessTier.Business(filename);

		var CTAStations = bizTier.GetStations();

		foreach (var station in CTAStations)
		{
			this.lstStations.Items.Add(station.Name);
		}

		toolStripStatusLabel1.Text = string.Format("Number of stations:  {0:#,##0}", CTAStations.Count());
	  }
	  catch(Exception ex)
	  {
		string msg = string.Format("Error: '{0}'.", ex.Message);
		MessageBox.Show(msg);
	  }
	}


	//
	// User has clicked on a station for more info:
	//
	private void lstStations_SelectedIndexChanged(object sender, EventArgs e)
    {
	  string filename = this.txtDatabaseFilename.Text;
	  // sometimes this event fires, but nothing is selected...
	  if (this.lstStations.SelectedIndex < 0)   // so return now in this case:
        return; 
      
      //
      // clear GUI in case this fails:
      //
      ClearStationUI();

      //
      // now display info about selected station:
      //
      string stationName = this.lstStations.Text;
      stationName = stationName.Replace("'", "''");

      try
      {
		BusinessTier.Business bizTier = new BusinessTier.Business(filename);

		int stationID = bizTier.getStationIDByName(stationName);
		long totalOverall = bizTier.GetCompleteRidership();
		long stationTotal = bizTier.GetRidershipForStation(stationName);
		double stationAvg = bizTier.GetAvgRidership(stationName);

        double percentage = ((double)stationTotal) / totalOverall * 100.0;

        this.txtTotalRidership.Text = stationTotal.ToString("#,##0");
        this.txtAvgDailyRidership.Text = string.Format("{0:#,##0}/day", stationAvg);
        this.txtPercentRidership.Text = string.Format("{0:0.00}%", percentage);
		this.txtStationID.Text = stationID.ToString();

		var ridershipByDay = bizTier.RidershipByDay(stationName);
		this.txtSaturdayRidership.Text = ridershipByDay[0].ToString("#,##0");
		this.txtSundayHolidayRidership.Text = ridershipByDay[1].ToString("#,##0");
		this.txtWeekdayRidership.Text = ridershipByDay[2].ToString("#,##0");

		var stops = bizTier.GetStops(stationID);

		foreach (var stop in stops)
		{
			this.lstStops.Items.Add(stop.Name);
		}
	  }

      catch (Exception ex)
      {
		string msg = string.Format("Error: '{0}'.", ex.Message);
        MessageBox.Show(msg);
      }
    }

    private void ClearStationUI(bool clearStatations = false)
    {
      ClearStopUI();

      this.txtTotalRidership.Clear();
      this.txtTotalRidership.Refresh();

      this.txtAvgDailyRidership.Clear();
      this.txtAvgDailyRidership.Refresh();

      this.txtPercentRidership.Clear();
      this.txtPercentRidership.Refresh();

      this.txtStationID.Clear();
      this.txtStationID.Refresh();

      this.txtWeekdayRidership.Clear();
      this.txtWeekdayRidership.Refresh();
      this.txtSaturdayRidership.Clear();
      this.txtSaturdayRidership.Refresh();
      this.txtSundayHolidayRidership.Clear();
      this.txtSundayHolidayRidership.Refresh();

      this.lstStops.Items.Clear();
      this.lstStops.Refresh();

      if (clearStatations)
      {
        this.lstStations.Items.Clear();
        this.lstStations.Refresh();
      }
    }


    //
    // user has clicked on a stop for more info:
    //
    private void lstStops_SelectedIndexChanged(object sender, EventArgs e)
    {
	  string filename = this.txtDatabaseFilename.Text;

	  // sometimes this event fires, but nothing is selected...
	  if (this.lstStops.SelectedIndex < 0)   // so return now in this case:
		return; 

      //
      // clear GUI in case this fails:
      //
      ClearStopUI();

      //
      // now display info about this stop:
      //
      string stopName = this.lstStops.Text;
      stopName = stopName.Replace("'", "''");

	  try
	  {
		BusinessTier.Business bizTier = new BusinessTier.Business(filename);
		//
		// Let's get some info about the stop:
		//
		// NOTE: we want to use station id, not stop name,
	    // because stop name is not unique.  Example: the
	    // stop "Damen (Loop-bound)".s
	    //

	    var stopInfo = bizTier.getStopInfo(stopName, Convert.ToInt32(this.txtStationID.Text));


        // handicap accessible?
        bool accessible = stopInfo.ADA;

        if (accessible)
          this.txtAccessible.Text = "Yes";
        else
          this.txtAccessible.Text = "No";

        // direction of travel:
        this.txtDirection.Text = stopInfo.Direction;

		// lat/long position:
		this.txtLocation.Text = string.Format("({0:00.0000}, {1:00.0000})",
		  stopInfo.Latitude,
		  stopInfo.Longitude);

		// display colors:
		var colors = bizTier.GetColors(stopInfo.ID);

		foreach (var color in colors)
		{
			this.lstLines.Items.Add(color);
		}

	  }
      catch (Exception ex)
      {
        string msg = string.Format("Error: '{0}'.", ex.Message);
        MessageBox.Show(msg);
      }
    }

    private void ClearStopUI()
    {
      this.txtAccessible.Clear();
      this.txtAccessible.Refresh();

      this.txtDirection.Clear();
      this.txtDirection.Refresh();

      this.txtLocation.Clear();
      this.txtLocation.Refresh();

      this.lstLines.Items.Clear();
      this.lstLines.Refresh();
    }


    //
    // Top-10 stations in terms of ridership:
    //
    private void top10StationsByRidershipToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //
      // clear the UI of any current results:
      //
      ClearStationUI(true /*clear stations*/);

	  try
	  {
		string filename = this.txtDatabaseFilename.Text;
		BusinessTier.Business bizTier;

		bizTier = new BusinessTier.Business(filename);
		var CTAStations = bizTier.GetTopStations(10);

		foreach (var station in CTAStations)
		{
			this.lstStations.Items.Add(station.Name);
		}

		toolStripStatusLabel1.Text = string.Format("Number of stations:  {0:#,##0}", CTAStations.Count());
	  }
	  catch(Exception ex)
	  {
		string msg = string.Format("Error: '{0}'.", ex.Message);
		MessageBox.Show(msg);
	  }

	}

	private void updateADAButton_Click(object sender, EventArgs e)
	{
	  try
	  {
		if (this.lstStops.SelectedIndex < 0)   // no stop selected:
			return;

		string filename = this.txtDatabaseFilename.Text;
		BusinessTier.Business bizTier;

		bizTier = new BusinessTier.Business(filename);

		string stopName = this.lstStops.Text;
		stopName = stopName.Replace("'", "''");

		int stopID = bizTier.getStopID(stopName, Convert.ToInt32(this.txtStationID.Text));

		int updateValue;
		if (this.txtAccessible.Text == "Yes")
			updateValue = 0;
		else if (this.txtAccessible.Text == "No")
			updateValue = 1;
		else // something weird happened here
			return;

		int updated = bizTier.updateADA(updateValue, stopID);

		if (updated == 0)
		{
			string msg = string.Format("Value not Updated. Try Again?");
			MessageBox.Show(msg);
		}
		else if (this.txtAccessible.Text == "Yes")
			this.txtAccessible.Text = "No";
		else if (this.txtAccessible.Text == "No")
			this.txtAccessible.Text = "Yes";
	  }
	  catch(Exception ex)
	  {
		string msg = string.Format("Error: '{0}'.", ex.Message);
		MessageBox.Show(msg);
	  }
	}

	private void findSimilarStations_Click(object sender, EventArgs e)
	{
	  //
   	  // clear the UI of any current results:
	  //
	  ClearStationUI(true /*clear stations*/);
	  string filename = this.txtDatabaseFilename.Text;

	  try
	  {
		BusinessTier.Business bizTier;

		bizTier = new BusinessTier.Business(filename);
		var CTAStations = bizTier.GetSimilarStations(this.similarStation.Text);

		foreach (var station in CTAStations)
		{
	      this.lstStations.Items.Add(station.Name);
		}

		toolStripStatusLabel1.Text = string.Format("Number of stations:  {0:#,##0}", CTAStations.Count());
	  }
	  catch(Exception ex)
	  {
		string msg = string.Format("Error: '{0}'.", ex.Message);
		MessageBox.Show(msg);
	  }
	}
  }//class
}//namespace
