//@file name: ch2-gp-SliceCopy.go
//@description: Slice copy.
//@author: Jedi Zhou <skyzhx@163.com>
//@copyright: 2014-4-10, Jedi Zhou

package ch2

import "fmt"

func main() {

	// Define
	slice1 := []string{"a", "b", "c", "d", "e"}
	slice2 := []string{"z", "h", "x"}

	// Slice copy
	copy(slice2, slice1)
	copy(slice1, slice2)

	// Create a slice array and output
	dispElt(slice1)
	dispElt(slice2)

}

func dispElt(array []string) {
	for _, element := range array {
		fmt.Print(element, " ")
	}
	fmt.Println()
}
