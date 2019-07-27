// Ref: Programming Scala Tackle Multi-core Complexity on the Java Virtual Machine
// MultipleAssignment2.scala
def getPersonInfo(primaryKey : Int) = {
	("Jedi", "Chou", "Jedi Chou/CEN/FOXCONN.COM")
}

val (firstName, lastName, _) = getPersonInfo(1)
println(firstName)
println(lastName)
