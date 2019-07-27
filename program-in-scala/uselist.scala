// program in scala, zh-cn, P58
// file name: uselist.scala

val list1 = List(1,2)
val list2 = List(3,4)
val list3 = list1 ::: list2
println ("" + list1 + " and " + list2 + " were not mutated.")
println ("Thus, " + list3 + " is a new List object")
