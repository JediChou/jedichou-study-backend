// program in scala, zh-cn, P65
// file name: mkStr.scala
def formatArgs(args: Array[String]) = args.mkString("\n")
val arr = Array.apply("Jedi", "Becky", "CiCi")
println(formatArgs(arr))
