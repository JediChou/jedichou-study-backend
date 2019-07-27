// 1.1 Testing String Equality
// Problem
// You want to compare two strings to see if they're equal, i.e.,
// whether they contain the same sequence of characters.

// solution

val s1 = "Hello"
val s2 = "Hello"
println(s1 == s2)

val s3 = "hello"
val s4 = "HELLO"
println( s3.toUpperCase == s4.toUpperCase )

val a = "Marisa"
val b = "marisa"
println(a.equalsIgnoreCase(b))
