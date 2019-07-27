//@file name: ch2-gp-varg1.go
//@description: Create a simple map
//@author: Jedi Zhou <skyzhx@163.com>
//@copyright: 2014-4-10, Jedi Zhou

package ch2

import "fmt"

func varTypeCheck(args ...interface{}) {
	for _, arg := range args {
		switch arg.(type) {
		case int:
			fmt.Println(arg, "is an int value.")
		case string:
			fmt.Println(arg, "is an string value.")
		case int64:
			fmt.Println(arg, "is an int64 value.")
		default:
			fmt.Println(arg, "is an unknow type.")
		}
	}
}

func main() {
	var v1 int = 1
	var v2 int64 = 234
	var v3 string = "hello"
	var v4 float32 = 1.234

	varTypeCheck(v1, v2, v3, v4)
}
