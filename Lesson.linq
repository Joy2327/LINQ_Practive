<Query Kind="Statements">
  <Connection>
    <ID>33852aa5-a8c5-4269-ad4a-0a8825b6720c</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
          orderby g.Name
		  select new
		   {
		     Genre=g.Name,
			 TracksCount =g.Tracks.Count()
		   };
results.Dump("Query Math 1");