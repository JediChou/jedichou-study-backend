// The way to Go A Thorough Introduction to the Go
// Listing 4.5 - goos.go

package main

import (
    "fmt"
    "os"
)

func main() {
	var goos string = os.Getenv("GOOS")
	fmt.Printf("The operating system is : %s\n", goos)
	path := os.Getenv("PATH")
	fmt.Printf("Path is %s\n", path)
	return
}