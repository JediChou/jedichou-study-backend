package main

import "fmt"

func main() {
	var a Integer = 1
	if a.Less(2) {
		fmt.Println(a, "Less 2")
	}
	if a.Bigger(0) {
		fmt.Println(a, "Bigger than 0")
	}
}
