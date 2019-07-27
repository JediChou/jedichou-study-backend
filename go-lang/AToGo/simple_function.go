// Listing 6.2 - simple_function.go
package main
import "fmt"

func main() {
	fmt.Printf("Method 1 - Multiply 2 * 5 * 6 = %d\n", MultiPly3Nums(2, 5, 6))
	var il int = MultiPly3Nums(2, 5, 6)
	fmt.Printf("Method 2 - Multiply 2 * 5 * 6 = %d\n", il)
}

func MultiPly3Nums(a int, b int, c int) int {
	// var product int = a * b * c
	// return product
	return a * b * c
}
