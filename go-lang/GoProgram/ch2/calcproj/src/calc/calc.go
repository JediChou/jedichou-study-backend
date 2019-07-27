// calc.go
package main

import "os"
import "fmt"
import "simplemath"
import "strconv"

var Usage = func() {
	fmt.Println("USAGE: calc command [arguments] ...")
	fmt.Println("The commands are:")
	fmt.Println("\tadd\tAddition of two values.")
	fmt.Println("\tsqrt\tSquare root of a non-negative value.")
}

func main() {

	// Process parameters
	args := os.Args
	if args == nil || len(args) < 2 {
		Usage()
		return
	}

	// Process calculate
	switch args[1] {

	case "add":
		// check args size
		if len(args) != 4 {
			fmt.Println("USAGE: calc add <integer1><integer2>")
			return
		}
		// get parameter and convert to integer
		v1, err1 := strconv.Atoi(args[2])
		v2, err2 := strconv.Atoi(args[3])
		if err1 != nil || err2 != nil {
			fmt.Println("USAGE: calc add <intger1><inter2>")
			return
		}
		ret := simplemath.Add(v1, v2)
		fmt.Println("Result: ", ret)

	case "sqrt":
		if len(args) != 3 {
			fmt.Println("USAGE: calc sqrt <integer>")
			return
		}
		v, err := strconv.Atoi(args[2])
		if err != nil {
			fmt.Println("USAGE: calc sqrt <integer>")
			return
		}
		ret := simplemath.Sqrt(v)
		fmt.Println("Result: ", ret)

	default:
		Usage()

	}

} // End main
