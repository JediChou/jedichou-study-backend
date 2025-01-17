// Programming Scala - ShapesDrawingActor.scala

package progscala2.introscala.shapes

object Message {
	object Exit
	object Finished
	case class Response(message: String)
}

import akka.actor.Actor

class ShapesDrawingActor extends Actor {
	import Messages._

	def receive = {
		case s: Shape =>
			s.draw(str => println(s"ShapesDrawingActor: $str"))
			sender ! Response(s"ShapesDrawingActor: $s drawn)
		case Exit =>
			println(s"ShapesDrawingActor: exiting...")
			sender ! Finished
		case unexpected => // default. Equivalent to "unexpected: Any"
			val respone = Reponse(s"ERROR: Unknown message: $unexpected")
			println(s"ShapesDrawingActor: $response")
			sender ! reponse
	}
}
