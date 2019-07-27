// program in scala, zh-cn, P64
// file name: funcStyle.scala

def printArgs1(args: Array[String]): Unit = {
	var i = 0
	while ( i < args.length) {
		print (args(i) + " ")
		i += 1
	}
	println()
}

def printArgs2(args: Array[String]): Unit = {
	for (arg <- args) print (arg + " ")
	println()
}

def printArgs3(args: Array[String]): Unit = {
	args.foreach(addblank)
	println()
}

def addblank(str: String) = {
	print(str + " ")
}

val arr = Array.apply("Jedi", "Becky", "CiCi")
printArgs1(arr); printArgs2(arr); printArgs3(arr)
