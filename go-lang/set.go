// set.go
// Get variable's setable property by reflect
package main

import (
	"fmt"
	"reflect"
)

func testA() {
	var x float64 = 3.4
	v := reflect.ValueOf(x)
	if true == v.CanSet() {
		fmt.Println("v is setable")
	} else {
		fmt.Println("v is not setable")
	}
}

func testB() {
	var x float64 = 3.4
	p := reflect.ValueOf(&x)
	fmt.Println("type of p", p.Type())
	fmt.Println("settability of p:", p.CanSet())

	v := p.Elem()
	fmt.Println("setability of v:", v.CanSet())

	v.SetFloat(7.1)
	fmt.Println(v.Interface())
	fmt.Println(x)
}

func main() {
	testA()
	testB()
}
