//
// BusinessTier:  business logic, acting as interface between UI and data store.
//

using DataAccessTier;
using System;
using System.Collections.Generic;
using System.Data;


namespace BusinessTier
{

  //
  // Business:
  //
  public class Business
  {
    //
    // Fields:
    //
    private string _DBFile;
    private DataAccessTier.Data dataTier;


    ///
    /// <summary>
    /// Constructs a new instance of the business tier.  The format
    /// of the filename should be either |DataDirectory|\filename.mdf,
    /// or a complete Windows pathname.
    /// </summary>
    /// <param name="DatabaseFilename">Name of database file</param>
    /// 
    public Business(string DatabaseFilename)
    {
      _DBFile = DatabaseFilename;

      dataTier = new DataAccessTier.Data(DatabaseFilename);
    }


    ///
    /// <summary>
    ///  Opens and closes a connection to the database, e.g. to
    ///  startup the server and make sure all is well.
    /// </summary>
    /// <returns>true if successful, false if not</returns>
    /// 
    public bool TestConnection()
    {
      return dataTier.OpenCloseConnection();
    }


    ///
    /// <summary>
    /// Returns all the CTA Stations, ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStation objects</returns>
    /// 
    public IReadOnlyList<CTAStation> GetStations()
    {
      List<CTAStation> stations = new List<CTAStation>();

      try
      {
		string sql = string.Format(@"
		SELECT Name, StationID
		FROM Stations 
		ORDER BY Name ASC;
		");


		DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

		// display stops:
		foreach (DataRow row in ds.Tables["TABLE"].Rows)
		{
			stations.Add(new CTAStation(Convert.ToInt32(row["StationID"]), row["Name"].ToString()));
		}

	  }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetStations: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return stations;
    }


    ///
    /// <summary>
    /// Returns the CTA Stops associated with a given station,
    /// ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStop objects</returns>
    ///
    public IReadOnlyList<CTAStop> GetStops(int stationID)
    {
      List<CTAStop> stops = new List<CTAStop>();

      try
      {
		string sql = string.Format(@"
		SELECT Stops.Name, StopID, Direction, ADA, Latitude, Longitude
		FROM Stops
		INNER JOIN Stations ON Stops.StationID = Stations.StationID
		WHERE Stations.StationID = {0}
		ORDER BY Stops.Name ASC;
		", stationID);


		DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

		// display stops:
		foreach (DataRow row in ds.Tables["TABLE"].Rows)
		{
			stops.Add(new CTAStop(Convert.ToInt32(row["StopID"]), row["Name"].ToString(), stationID, row["Direction"].ToString(), 
					  Convert.ToBoolean(row["ADA"]), Convert.ToDouble(row["Latitude"]), Convert.ToDouble(row["Longitude"])));
		}

	  }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetStops: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return stops;
    }


    ///
    /// <summary>
    /// Returns the top N CTA Stations by ridership, 
    /// ordered by name.
    /// </summary>
    /// <returns>Read-only list of CTAStation objects</returns>
    /// 
    public IReadOnlyList<CTAStation> GetTopStations(int N)
    {
      if (N < 1)
        throw new ArgumentException("GetTopStations: N must be positive");

      List<CTAStation> stations = new List<CTAStation>();

      try
      {
		string sql = string.Format(@"
		SELECT Top {0} Name, Stations.StationID, Sum(DailyTotal) As TotalRiders 
		FROM Riderships
		INNER JOIN Stations ON Riderships.StationID = Stations.StationID 
		GROUP BY Stations.StationID, Name
		ORDER BY TotalRiders DESC;
		", N);


		DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

		// display stops:
		foreach (DataRow row in ds.Tables["TABLE"].Rows)
		{
			stations.Add(new CTAStation(Convert.ToInt32(row["StationID"]), row["Name"].ToString()));
		}

	  }
      catch (Exception ex)
      {
        string msg = string.Format("Error in Business.GetTopStations: '{0}'", ex.Message);
        throw new ApplicationException(msg);
      }

      return stations;
    }

	///
	/// <summary>
	/// Returns the Line Colors associated with a given stopID,
	/// ordered by Color Name.
	/// </summary>
	/// <returns>Read-only list of strings</returns>
	///
	public IReadOnlyList<String> GetColors(int stopID)
	{
		List<String> colors = new List<String>();

		try
		{
			string sql = string.Format(@"
			SELECT Color
			FROM Lines
			INNER JOIN StopDetails ON Lines.LineID = StopDetails.LineID
			INNER JOIN Stops ON StopDetails.StopID = Stops.StopID
			WHERE Stops.StopID = {0}
			ORDER BY Color ASC;
			", stopID);


			DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

			// display stops:
			foreach (DataRow row in ds.Tables["TABLE"].Rows)
			{
				colors.Add(row["Color"].ToString());
			}

		}
		catch (Exception ex)
		{
		  string msg = string.Format("Error in Business.GetColors: '{0}'", ex.Message);
		  throw new ApplicationException(msg);
		}

		return colors;
	}

	///
	/// <summary>
	/// Returns the Ridership Across All Stations 
	/// </summary>
	/// <returns>a long that is the count of riders across all stations</returns>
	///
	public long GetCompleteRidership()
	{
		long totalRidership;

		try
		{
			string sql = string.Format(@"
			SELECT Sum(Convert(bigint,DailyTotal)) As TotalOverall
			FROM Riderships;
			");


			totalRidership = Convert.ToInt64(dataTier.ExecuteScalarQuery(sql));

		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.GetCompleteRidership: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}

		return totalRidership;
	}

	///
	/// <summary>
	/// Returns the CTA Ridership associated with a given station,
	/// </summary>
	/// <returns>long that represents ridership for the station</returns>
	///
	public long GetRidershipForStation(string stationName)
	{
	  long totalRidership;
	  try
	  {
		string sql = string.Format(@"
		SELECT Sum(DailyTotal) As TotalRiders, 
		Avg(DailyTotal) As AvgRiders
		FROM Riderships
		INNER JOIN Stations ON Riderships.StationID = Stations.StationID
		WHERE Name = '{0}';
		", stationName);


		totalRidership = Convert.ToInt64(dataTier.ExecuteScalarQuery(sql));

	  }
	   catch (Exception ex)
	   {
		 string msg = string.Format("Error in Business.GetRidershipForStation: '{0}'", ex.Message);
		 throw new ApplicationException(msg);
	   }

			return totalRidership;
	}

	///
	/// <summary>
	/// Returns the average riders across a station per day
	/// </summary>
	/// <returns>double of average ridership per day</returns>
	///
	public double GetAvgRidership(string stationName)
	{
		double avgRidership;
		try
		{
			string sql = string.Format(@"
			SELECT Avg(DailyTotal) As AvgRiders
			FROM Riderships
			INNER JOIN Stations ON Riderships.StationID = Stations.StationID
			WHERE Name = '{0}';
			", stationName);


			avgRidership = Convert.ToDouble(dataTier.ExecuteScalarQuery(sql));

		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.GetAvgRidership: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}

		return avgRidership;
	}

	///
	/// <summary>
	/// Returns the Ridership by day
	/// ordered by day type so days can be predicted
	/// placed in order of sat -> sun/holiday -> weekday.
	/// </summary>
	/// <returns>Read-only list of longs representing ridership by day</returns>
	///
	public IReadOnlyList<long> RidershipByDay(string stationName)
	{
		List<long> ridershipVals = new List<long>();

		try
		{
			string sql = string.Format(@"
			SELECT Riderships.StationID, TypeOfDay, Sum(DailyTotal) AS Total
			FROM Stations
			INNER JOIN Riderships
			ON Stations.StationID = Riderships.StationID
			WHERE Name = '{0}'
			GROUP BY Riderships.TypeOfDay, Riderships.StationID
			ORDER BY Riderships.TypeOfDay;
			", stationName);

			DataSet ds = new DataSet();
			ds = dataTier.ExecuteNonScalarQuery(sql);

			foreach (DataRow row in ds.Tables["TABLE"].Rows)
			{
				ridershipVals.Add(Convert.ToInt32(row["Total"]));
			}

		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.RidershipByDay: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}

		return ridershipVals;
	}

	///
	/// <summary>
	/// Returns the Station ID of a station Name.
	/// </summary>
	/// <returns>int that is stationID</returns>
	///
	public int getStationIDByName(string stationName)
	{
		object stationID = 0;

		try
		{
			string sql = string.Format(@"
			SELECT StationID
			From Stations
			Where Name = '{0}';
			", stationName);

			stationID = dataTier.ExecuteScalarQuery(sql);
		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.getStationIDByName: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}
		return Convert.ToInt32(stationID);
	}


	///
	/// <summary>
	/// Returns the CTA Stop info associated with a 
	/// given station and stop Name.
	/// </summary>
	/// <returns>CTAStop objec</returns>
	///
	public CTAStop getStopInfo(string stopName, int stationID)
	{
		CTAStop stop;
		try
		{
			string sql = string.Format(@"
			SELECT StopID, Direction, ADA, Latitude, Longitude
			FROM Stops
			WHERE Name = '{0}' AND
			StationID = {1};
			", stopName, stationID);

			DataSet ds = dataTier.ExecuteNonScalarQuery(sql);
			DataRow R = ds.Tables["TABLE"].Rows[0];

			stop = new CTAStop(Convert.ToInt32(R["StopID"]), stopName, 
			stationID, R["Direction"].ToString(), Convert.ToBoolean(R["ADA"]), Convert.ToDouble(R["Latitude"]), Convert.ToDouble(R["Longitude"]));

		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.getStopInfo: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}

		return stop;
	}

	///
	/// <summary>
	/// Returns the StopID of a station from stopName and stationID
	/// </summary>
	/// <returns>int that represents the stop ID</returns>
	///
	public int getStopID(string stopName, int stationID)
	{
		int stopID;
		try
		{
			string sql = string.Format(@"
			SELECT StopID
			FROM Stops
			WHERE Name = '{0}' AND
			StationID = {1};
			", stopName, stationID);

			object ID = dataTier.ExecuteScalarQuery(sql);
			stopID = Convert.ToInt32(ID);
		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.getStopID: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}

		return stopID;
	}

	///
	/// <summary>
	/// Executes Action Query to flip stops handicap accesibilty in database
	/// as well as on the presentation tier
	/// </summary>
	/// <returns>Status of Update 1 means sucessful 0 is unsucessful</returns>
	///
	public int updateADA(int updateValue, int stopID)
	{
		int updated = 0;
		try
		{
			string sql = string.Format(@"
			Update Stops
			Set Stops.ADA = {0}
			WHERE StopID = {1};",
			updateValue, stopID);

			updated = dataTier.ExecuteActionQuery(sql);
		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.updateADA: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}

		return updated;
	}

	///
	/// <summary>
	/// Returns the CTA Stations associated with a given string
	/// that a station name must contain to be included,
	/// ordered by name.
	/// </summary>
	/// <returns>Read-only list of CTAStation objects</returns>
	///
	public IReadOnlyList<CTAStation> GetSimilarStations(string partial)
	{
		List<CTAStation> stations = new List<CTAStation>();

		try
		{
			string sql = string.Format(@"
			SELECT Name, StationID
			FROM Stations 
			Where Name Like '%{0}%'
			ORDER BY Name ASC;
			", partial);


			DataSet ds = dataTier.ExecuteNonScalarQuery(sql);

			// display stops:
			foreach (DataRow row in ds.Tables["TABLE"].Rows)
			{
				stations.Add(new CTAStation(Convert.ToInt32(row["StationID"]), row["Name"].ToString()));
			}

		}
		catch (Exception ex)
		{
			string msg = string.Format("Error in Business.GetStations: '{0}'", ex.Message);
			throw new ApplicationException(msg);
		}
		return stations;
	}
  }//class
}//namespace
