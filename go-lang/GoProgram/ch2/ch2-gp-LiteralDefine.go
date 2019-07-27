// @file ch1-gp-LiteralDefine.go
// @description Define literal.
// @writer Jedi Zhou <skyzhx@163.com>
// @copyright 2014-4-10, Jedi Zhou

package main

import "fmt"

func main() {

	// define literals
	const Pi float64 = 3.14159265358979323846
	const zero = 0.0
	const (
		size int64 = 1024
		eof        = -1
	)
	const u, v float32 = 0, 3
	const a, b, c = 3, 4, "foo"

	// special literals
	const mask = 1 << 3

	// Output these literals
	fmt.Println("Pi -> ", Pi)
	fmt.Println("zero -> ", zero)
	fmt.Println("size -> ", size)
	fmt.Println("eof -> ", eof)
	fmt.Println("u -> ", 0)
	fmt.Println("v -> ", v)
	fmt.Println("a -> ", a)
	fmt.Println("b -> ", b)
	fmt.Println("c -> ", c)
	fmt.Println("mask -> ", mask)

	//   Notice: If you execute these constants, you will get complie
	// error. Error message will like.
	//   [file name]:[line number]: const initializer os.Getenv("Home")
	// is not a constant
	//   const Home = os.Getenv("Home")
	//   fmt.Println("Home -> ", Home)

}
