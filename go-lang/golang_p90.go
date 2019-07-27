package main
import "fmt"

var pr = fmt.Println
var g func()

var f = func() {
	pr("Hello")
}

var h = func() {
	pr("World")
}

func main() {
	g = f
	g()
	g = h
	g()
}
