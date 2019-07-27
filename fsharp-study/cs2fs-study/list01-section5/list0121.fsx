// F# for C# Developers.pdf, page 26
// Listing 1-21, Defining an F# list

// defines a list with elements from 1 to 10.
let list0 = [1..10];;

// defines a list with element 1, 2, and 3.
let list1 = [1;2;3];;

// defines a list with elements 0,1,4,9, and 16.
let list2 = [for i=0 to 4 do yield i*i];;

// defines an empty list
let emptyList1 = [];;
let emptyList2 = List.empty;;