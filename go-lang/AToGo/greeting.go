// Listing 6.1 - greeting.go
// Here is the simplest of a function calling another function.

package main

func main() {
	println("In main before calling greeting")
	greeting()
	println("In main after calling greeting")
}

func greeting() {
	println("In greeting: Hi!!!!!")
}
