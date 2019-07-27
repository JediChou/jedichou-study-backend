// program in scala, zh-cn, P55
// file name: initarray.scala

val greetStrings = new Array[String](3)
greetStrings(0) = "Hello"
greetStrings(1) = ","
greetStrings(2) = "World!\n"

for ( i <- 0 to 2)
	print(greetStrings(i))
