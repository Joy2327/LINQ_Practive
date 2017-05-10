<Query Kind="Statements">
  <Connection>
    <ID>33852aa5-a8c5-4269-ad4a-0a8825b6720c</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
       where g.Name.Equals("Heavy Metal")
		  select new
		   {
			 TracksCount =g.Tracks.Count(),
			 Tracks=from t in g.Tracks
			 select new 
			 {
			    TracksName=t.Name,
				AlbumName=t.Album.Title,
				Milliseconds=t.Milliseconds,
				Size=(t.Bytes/1000)+"kb",
				Price=t.UnitPrice
			 }
		   };
results.Dump("Query Math 2");