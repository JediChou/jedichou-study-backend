// The Way to Go - A Thorough Introduction to the Go
// Exercise 4.3 - function_calls_function.go

package main

var a string

func main() {
	a = "G"
	print(a)
	f1()
	print("\n")
}

func f1() {
	a := "O"
	print(a)
	f2() // Why this function print gobal variable's value ?
}

func f2() {
	print(a)
}
