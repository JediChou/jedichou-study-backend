// program in scala, zh-cn, P52
// file name: echoargs.scala
var i = 0
while (i < args.length) {
	if (i != 0) print(" ")
	print(args(i))
	i += 1
}
println()
