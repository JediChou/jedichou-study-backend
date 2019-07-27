// File name: list0308.cs
// Reference by Linq in Action zh-cn, page 77
// Query expression with operator

var authors =
	SampleData.Books
		.Where (book => book.Title.Contains("LINQ"))
		.SelectMany( book => book.authors.Take(1))
		.Distinct()
		.Select (author => new { author.FirstName, author.LastName});
