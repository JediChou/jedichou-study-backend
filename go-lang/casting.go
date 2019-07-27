// The Way to Go - A Thorough Introduction to the Go
// Listing 4.9 - casting.go

package main

import "fmt"

func main() {
	var n int16 = 34
	var m int32

	m = int32(n) // use int32() to change variable type

	fmt.Printf("16 bit int is : %d\n", n)
	fmt.Printf("32 bit int is : %d\n", m)
	return
}
