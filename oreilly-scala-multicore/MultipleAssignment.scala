// Ref: Programming Scala Tackle Multi-Core Complexity on the Java Virtual Machine
// MultipleAssignment.scala
def getPersonInfo(primaryKey : Int) = {
	// Assume primaryKey is used to fetch a person's info ...
	// Here response is hard-coded
	("Venkat", "Subramaniam", "venkat@agiledeveloper.com")
}

val (firstName, lastName, emailAddress) = getPersonInfo(1)
println("First name is: " + firstName)
println("Second name is: " + lastName)
println("Address is: " + emailAddress)
