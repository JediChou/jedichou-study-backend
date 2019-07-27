// listing 1.3 simple query expression
from customer in customers
	where customer.Name.StartWith("A") && customer.Orders.Count > 0
	orderby customer.Name
	select new { customer.Name, customer.Orders}

