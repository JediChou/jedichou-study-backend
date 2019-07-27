// The way to Go A Thorough Introduction to the Go
// Listing 4.7 - use_init.go

package main

import (
	"fmt"
	"./trans"
)

var twoPi = 2 * trans.Pi

func main() {
	fmt.Printf("2 * Pi = %g\n", twoPi)
	return
}
