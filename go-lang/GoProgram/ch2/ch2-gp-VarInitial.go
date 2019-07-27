// @file ch1.go
// @description Initialize variables.
// @writer Jedi Zhou <skyzhx@163.com>
// @copyright 2014-4-10, Jedi Zhou

package main

import "fmt"

func main() {

	// Define variable and initialize variables
	// Notice:
	//   1. v1 and v2 only use "="
	//   2. v3 use ":="
	var v1 int = 1
	var v2 = 10
	v3 := 100

	// Output
	fmt.Println("v1 -> ", v1)
	fmt.Println("v2 -> ", v2)
	fmt.Println("v3 -> ", v3)

}
