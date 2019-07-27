// list 1-1
var contacts =
	from customer in db.Customers
	where customer.Name.StartsWith("A") && customer.Order.Count > 0
	orderby customer.Name
	select new { customer.Name, customer.Phone};

var xml =
	new XElement("contacts",
		from contact in contacts
		select new XElement("contact",
			new XAttribute("name", contact.Name),
			new XAttribute("phone", contact.Phone)
		)
	);
