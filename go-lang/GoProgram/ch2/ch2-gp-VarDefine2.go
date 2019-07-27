// @file gp-VarDefine2.go
// @description How to define variables(second method).
// @writer Jedi Zhou <skyzhx@163.com>
// @copyright 2014-4-10, Jedi Zhou

package main

import "fmt"

func main() {

	//Define variables
	var (
		v1 int
		v2 string
		v3 [10]int
		v4 []int
		v5 struct{ f int }
		v6 *int
		v7 map[string]int // map[key type]value type
		v8 func(a int) int
	)

	//Output
	fmt.Println("v1 -> ", v1)
	fmt.Println("v2 -> ", v2)
	fmt.Println("v3 -> ", v3)
	fmt.Println("v4 -> ", v4)
	fmt.Println("v5 -> ", v5)
	fmt.Println("v6 -> ", v6)
	fmt.Println("v7 -> ", v7)
	fmt.Println("v8 -> ", v8)

}
