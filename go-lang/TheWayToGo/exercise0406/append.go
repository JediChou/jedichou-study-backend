package main

import "fmt"

func main() {
	s := "hel" + "lo,"
	s += "world!"
	fmt.Printf("%s\n", s)
	fmt.Printf("%d", len(s))
}
