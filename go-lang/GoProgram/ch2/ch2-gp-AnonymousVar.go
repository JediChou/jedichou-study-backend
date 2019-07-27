// @file ch1-gp-AnonymousVar.go
// @description Use anonymous variable.
// @writer Jedi Zhou <skyzhx@163.com>
// @copyright 2014-4-10, Jedi Zhou

package main

import "fmt"

// This method return three string objects
func GetName() (string, string, string) {
	return "Jedi Chou", "J.C", "Little Fatman"
}

func main() {

	// Use anonymous variable and output
	_, _, nickname := GetName()
	fmt.Println("Nickname -> ", nickname)
}
