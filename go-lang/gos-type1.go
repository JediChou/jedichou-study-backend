package main

import "fmt"

type Book struct {
	Name       string
	ISBN       string
	Press      string
	PageNumber uint16
}

func main() {
	var a := Book
	fmt.Println("something")
}
