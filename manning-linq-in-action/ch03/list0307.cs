// File name: list0307.cs
// Reference by Linq in Action zh-ch page 76
// Description: Query expression with operators

var authors =
	from distinctAuthor in (
		form book in SampleData.Books
		where book.Title.Contains("LINQ")
		from author in book.authors.Take(1)
		select author)
		.Distinct()
	select new { distinctAuthor.FirstName, distinctAuthor.LastName };
