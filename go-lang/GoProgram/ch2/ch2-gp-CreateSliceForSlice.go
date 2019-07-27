//@file name: ch2-gp-CreateSliceForSlice.go
//@description: create slice reference by slice.
//@author: Jedi Zhou <skyzhx@163.com>
//@copyright: 2014-4-10, Jedi Zhou

package ch2

import "fmt"

func main() {

	// define
	oldSlice := []int{1, 2, 3, 4, 5}
	newSlice := oldSlice[:3]

	// output
	for index, value := range newSlice {
		fmt.Println("idx->", index, "val->", value)
	}

}
