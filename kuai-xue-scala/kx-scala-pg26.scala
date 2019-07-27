// File name: kx-scala-pg26.scala
// TODO: is not right

try {
	process(new URL("http://horstmann.com/fred-tiny.gif"))
} catch {
	case _: MalformedURLException => println("Bad URL: "+url)
	case ex: IOException => ex.printStackTrace()
}
