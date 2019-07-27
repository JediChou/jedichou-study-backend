// file name: kx-scala-pg54.scala
// description: modify setter method

// define class and creat a instance
class Person {
	private var privateAge = 0
	
	def age = privateAge
	def age_= (newAge: Int) {
		if (newAge > privateAge) privateAge = newAge
	}
}
val fred = new Person

// output default value
println("deault value: " + fred.age)

// assign 21 to fred.age
fred.age = 21
println("after first change - 21: " + fred.age)

// assign 20 to fred.age
fred.age = 20
println("after second change - 20: " + fred.age)
