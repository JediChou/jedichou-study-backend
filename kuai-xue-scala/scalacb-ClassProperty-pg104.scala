// file name: scalacb-ClassProperty-pg104.scala
// description: compare object
// from: O'Reiily, scala cookbook page 104(130/722)

class Person {
	var name = ""
	override def toString = s"name = $name"
}

val p = new Person
	
// the 'normal' mutator approach
p.name = "Ron Artest"
println(p)

// the 'hidden' mutator method
p.name_$eq("Metta World Peace")
println(p)
