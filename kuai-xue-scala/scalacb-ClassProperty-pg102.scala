public Person(String firstName, String lastName)
{
	super()
	firstName = firstName
	lastName = lastName
	Predef$.MODULES$.println("the constructor begins")
	age = 0
	printHome()
	printFullName()
	Predef$.MODULE$.println("still in the constructor")
}
