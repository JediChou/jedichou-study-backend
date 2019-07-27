// listing 1.5 working with relational data and xml in the same query
var database = new RssDB("server=.; initial catalog=RssDB");

XElement rss = new XElement("rss",
	new XAttribute("version", "2.0"),
	new XElement("channel",
		new XElement("title", "linqi in action rss feed"),
		new XElement("link", "http://linqinaction.net"),
		new XElement("description", "the rss feed for this book"),
		from post in database.Posts
		orderby post.CreationDaa descending
		select new XElement("item",
			new XElement("title", pos.Title),
			new XElement("link", "posts.aspx?id="+post.ID),
			new XElement("description", post.Description),
			from category in post.Categories
			select new XElement("category", category.Description)
		)
	)
);
