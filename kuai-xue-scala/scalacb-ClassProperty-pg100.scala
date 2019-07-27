// file name: scalacb-ClassProperty-pg100.scala
// decription: create a primary constructor

class Person(var firstName: String, var lastName: String) {
	
	// some class fields
	private val HOME = System.getProperty("user.home")
	var age = 0

	// some methods
	override def toString = s"$firstName $lastName is $age years old"
	def printHome { println(s"HOME = $HOME") }
	def printFullName { println(this) } // uses toString

	println("the constructor begins")
	printHome
	printFullName
	println("still in the constructor")
}

val p = new Person("Jedi", "Chou")
