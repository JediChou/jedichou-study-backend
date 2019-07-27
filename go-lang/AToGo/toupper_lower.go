// Listing 4.17, toupper_lower.go

package main
import (
	"fmt"
	"strings"
)

func main() {
	var orig string = "Hey, how are you Georage?"
	
	fmt.Printf("The original string is: %s\n", orig)
	fmt.Printf("The lowercase string is: %s\n", strings.ToLower(orig))
	fmt.Printf("The uppercase string is: %s\n", strings.ToUpper(orig))
}
