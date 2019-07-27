// program in scala, zh-cn, P57
// filename: initarray2.scala

val greetStrings = new Array[String](3)

greetStrings.update(0, "Hello")
greetStrings.update(1, " , ")
greetStrings.update(2, "World!\n")

for (i <- 0.to(2))
	print(greetStrings(i))
