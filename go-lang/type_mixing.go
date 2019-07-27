// The Way to Go - A Thorough Introduction to Go
// Listing 4.8 - type_mixing.go (does not compile !)

package main

func main() {
	var a int
	var b int32

	a = 15
	b = a + a
	// Compile error message
	// .\type_mixing.go: 11: cannot use a + a (type int) as type int32 in assignment

	b = b + 5
}
