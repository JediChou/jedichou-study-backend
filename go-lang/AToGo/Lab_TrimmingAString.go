// Lab 4.7.8 - Lab_TrimmingAString.go
// From The Way to Go - A Through Introduction to the Go

package main
import (
	"fmt"
	"strings"
)

func main() {
	// define 2 variables
	str1 := "  ABCDEFG   "
	str2 := "ABCDEFGAB"
	
	// output normal
	fmt.Printf("str1 - \"%s\"\n", str1)
	fmt.Printf("str2 - \"%s\"\n\n", str2)
	
	// output result
	fmt.Printf("Call TrimSpace(s) method result is: \"%s\"\n", strings.TrimSpace(str1))
	fmt.Printf("Call Trim(s) method result is: \"%s\"\n", strings.Trim(str2, "AB"))
	fmt.Printf("Call TrimLeft(s) method result is: \"%s\"\n", strings.TrimLeft(str2, "AB"))
	fmt.Printf("Call TrimRight(s) method result is: \"%s\"\n", strings.TrimRight(str2, "AB"))
}
