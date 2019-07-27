// @file ch2-gp-bool.go
// @description Bool type.
// @writer Jedi Zhou <skyzhx@163.com>
// @copyright 2014-4-10, Jedi Zhou

package main

import "fmt"

func main() {

	// Wrong define, you will get
	//   cannot use 1 (type int) as type bool in assignment
	// var b bool
	// b = 1

	// Wrong define, you will get
	//   cannot convert 1 to type bool
	//   cannot convert 1 (type int) to type bool
	//   cannot use bool(1) (type int) as type bool in assignment
	// var b bool
	// b = bool(1)

	// Right define
	var v1 bool
	v1 = true
	v2 := (1 == 2)

	// Output
	fmt.Println("v1 -> ", v1)
	fmt.Println("v2 -> ", v2)

}
