// program in scala, zh-cn, P66
// file name: ioread.scala

import scala.io.Source
if (args.length > 0)
	for ( line <- Source.fromFile(args(0)).getLines )
		println(line.length + "| " + line)
else
	Console.err.println("Please enter filename")
