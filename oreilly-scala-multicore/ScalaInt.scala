// Ref: Programming Scala Tackle Multi-Core Complexity on the Java Virtual Machine
// ScalaInt.scala
class ScalaInt {
	def playWithInt() {
		val capacity : Int = 10
		val list = new java.util.ArrayList[String]
		list.ensureCapacity(capacity)
	}
}
