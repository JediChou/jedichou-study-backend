package main

import "fmt"

const c = "C"

var v int = 5

type T struct{}

func init() { // initialization of package
	fmt.Println("This is init() method.")
}

func main() {
	var a int
	Func1()
	// ...
	fmt.Println(a)
}

func (t T) Method1() {
	// ...
}

func Func1() { // exported function Func1
	// ...
	fmt.Println("This is Func1() method.")
}
