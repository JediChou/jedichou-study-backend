// Listing 4.16, repeat_string.go
package main
import (
	"fmt"
	"strings"
)

func main() {
	var origS string = "Hi there!"
	var newS string
	
	newS = strings.Repeat(origS, 3)
	fmt.Printf("The new repeated string is : %s\n", newS)
}
