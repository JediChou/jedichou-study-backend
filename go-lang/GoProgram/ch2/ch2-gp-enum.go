// @file ch2-gp-enum.go
// @description Define enum
// @writer Jedi Zhou <skyzhx@163.com>
// @copyright 2014-4-10, Jedi Zhou

package main

import "fmt"

func main() {

	// Google GO has not enum keyword.
	// So we can use literal to define a enum that like C.
	const (
		Sunday = iota
		Monday
		Tuesday
		Wednesday
		Thursday
		Friday
		Saturday
		numberOfDays // this literal do not export
	)

	// Output
	fmt.Println(Sunday)
	fmt.Println(Monday)
	fmt.Println(Tuesday)
	fmt.Println(Wednesday)
	fmt.Println(Thursday)
	fmt.Println(Friday)
	fmt.Println(Saturday)

	// Notice:
	// Other package can not use this variable.
	// It's only for package inside.
	fmt.Println(numberOfDays)

}
