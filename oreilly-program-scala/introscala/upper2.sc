// Programming Scala - upper2.sc

object Upper {
	def upper(strings: String*) = strings.map(_.toUpperCase())
}

println(Upper.upper("Hello", "World!"))
