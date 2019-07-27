// File name: defclass.scala
// Description: create a simple class

class Counter {
	private var value = 0
	def increment() { value+=1 }
	def current() = value
}

var curr = new Counter
curr.increment()
println(curr.current)
