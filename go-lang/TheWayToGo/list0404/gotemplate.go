// Listing 4.4 - gotemplte.go

package main

import (
	"fmt"
)

const c = "C"

var v int = 5

type T struct{}

func init() {  // initialization of package
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
}

// The order of execution (program startup) of a Go
// application is as follows:
//
// (1) all packages in package main are imported in
//     the order as indicated, in every package:
// (2) if it imports packages, (1) is called for this
//     package (recursively) but a certain package is
//     imported only once
// (3) then for every package (in reverse order) all
//     constants and variables are evaluated, and
//     the init() if it contains this function.
// (4) at last in package main the same happens, and
//     then main() stars executing.

