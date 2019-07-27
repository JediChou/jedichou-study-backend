// listing 1.2 typical .net data-access code
using (var connection = new SqlConnection("...")) {
	connection.Open();
	var command = connection.CreateCommand();
	command.CommandText =
		@"SELECT Name, Country
		  FROM Customers
		  WHERE City = @City";
	command.Parameters.AddWithValue("@City", "Paris");
	using (var reader = command.ExecuteReader()) {
		while(reader.Read()) {
			var name = reader.GetString();
			var country = reader.GetString(1);
			...
		}
	}
}
