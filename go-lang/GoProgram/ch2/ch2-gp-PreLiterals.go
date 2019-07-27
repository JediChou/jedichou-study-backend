// @file ch1-gp-PreLiteral.go
// @description Define pre-define literal.
// @writer Jedi Zhou <skyzhx@163.com>
// @copyright 2014-4-10, Jedi Zhou

package main

import "fmt"

func main() {

	// Use pre-define
	const ( // iota reset to zero
		c0 = iota // c0 -> 0
		c1 = iota // c1 -> 1
		c2 = iota // c2 -> 2
	)
	fmt.Println("Pre-define 1:", c0, c1, c2)

	// Use pre-define
	const (
		a = 1 << iota
		b = 1 << iota
		c = 1 << iota
	)
	fmt.Println("Pre-define 2:", a, b, c)

	// Use pre-define
	const (
		u float32 = iota * 42.0
		v float32 = iota * 42.0
		w float32 = iota * 42.0
	)
	fmt.Println("Pre-define 3:", u, v, w)

	// Use pre-define
	const x = iota
	const y = iota
	fmt.Println("Pre-define 4:", x, y)

	// Use pre-define
	const (
		num1 = iota
		num2
		num3
	)
	fmt.Println("Pre-define 5:", num1, num2, num3)

	// Use pre-define
	const (
		l = (1 << iota) << iota // Jedi's skill
		m
		n
	)
	fmt.Println("Pre-define 6:", l, m, n)

}
