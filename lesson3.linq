<Query Kind="Statements">
  <Connection>
    <ID>33852aa5-a8c5-4269-ad4a-0a8825b6720c</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results =from m in MediaTypes
      select new {
	   Name=m.Name ,
	   Tracks=from t in m.Tracks
	 		  select new
	   {
	     TrackName=t.Name,
		  Album = t.Album.Title,
		  Artist=t.Album.Artist.Name,
		  ReleaseYear=t.Album.ReleaseYear,
		  ReleaseLabel=t. Album.ReleaseLabel,
		  Genre=t.Genre.Name
	   }
	  };
results.Dump();