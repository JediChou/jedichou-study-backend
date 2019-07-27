// Lab 4.7.9 - Lab_SplittingAString.go
// From The Way to Go - A Thorough Introduction to the Go

package main
import (
	"fmt"
	"strings"
)

func main() {
	str1 := "a,b,c,d,e,f"
	sLst := strings.Split(str1, ",")
	
	for id, val := range sLst {
		fmt.Printf("ID->%d, ", id)
		fmt.Printf("Value->%s\n", val)
	}
}
