//@file name: ch2-gp-AnaymousMethod.go
//@description: 演示匿名函数
//@author: Jedi Zhou <skyzhx@163.com>
//@copyright: 2014-4-11, Jedi Zhou

package main

import "fmt"

func main() {

	// define anaymous method and bind to a variable
	fmt.Println(func(a, b int) int { return a + b }(2, 3))
	fmt.Println(func() string { return "Hello Go" }())

	// Will return function address
	// fmt.Println(func() string { return "Hello Go" })

	// Other - 1
	pt := func(a, b int) { fmt.Println(a + b) }
	func(a, b int) { pt(a, b) }(2, 3)

	// Other - 2
	// Jedi: This feature is very cool!
	func(params ...interface{}) { pt(2, 3) }()
	func(params ...interface{}) { pt(2, 3) }("param1", "param2")
	func(params ...interface{}) { pt(2, 3) }(1, 2, 3, 4)

}
