# CTA-Analysis
Uses a N-Tier Design to Analyze a CTA Database using both SQL and C#

-	N-Tier Design
-	Data-Access Tier allows for the return scalar values and sets of data, as well as changing data in the database.
-	The Data-Access Tier is the only Tier that directly accesses the Database through SQL.
-	Business Tier calls the Data-Access Tier and parses data after it is returned from the database.
-	The Data is returned in functions with return types in the form of lists or scalar values.
-	Presentation Tier only deals with C# as it simply calls functions in Business Tier and presents them.
-	Some object oriented design is used in the Business Tier to retrieve large amounts of data at once. 
-	There are many different features, first once loading in the stations you can click on a certain station.
-	This will trigger a change and the presentation tier will call the business tier for some data.
-	This will also load the stops at the station from there you can once again click on one element.
-	Doing so will present you with Data specifically about that stop.
-	Using the like function in SQL you can also find stations with similar names.


Example:
  ![ctaexample](https://user-images.githubusercontent.com/29234968/34662009-30696e3e-f413-11e7-8d16-481d7874d485.png)
