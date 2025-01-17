// Listing 5.3, string_conversion2.go
package main
import (
	"fmt"
	"strconv"
)

func main() {
	
	// define part
	var orig string = "ABC"
	var an int
	var err error
	an, err = strconv.Atoi(orig)
	
	// process
	if err != nil {
		fmt.Printf("orig %s is not an integer - exiting with error\n", orig)
		// fmt.Println(err)
		return
	}
	fmt.Printf("The integer is %d\n", an)
// rest of the code
}
