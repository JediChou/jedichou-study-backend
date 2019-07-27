// 1.2 Creating Multiline Strings
// Problem
// You want to create multiline strings within your
// scala source code, like you can with the "heredoc"
// syntax of other languages.

// solution
val foo = """This
a multiline
String"""
println(foo+"\n")

// discuss
val speech = """Four score and
#seven years ago""".stripMargin('#')
println(speech)
