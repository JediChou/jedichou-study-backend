// Listing 4.22, string_pointer.go
package main
import "fmt"

func main() {
	
	// define
	s := "good bye"
	var p *string = &s
	*p = "ciao"
	
	// output
	fmt.Printf("Here is the pointer p: %p\n", p)
	fmt.Printf("Here is the string *p: %s\n", *p)
	fmt.Printf("Here is the string  s: %s\n", s)
}
