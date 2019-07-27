// The Way to Go - A Through Introduction to the Go
// Exercise 4.2: global_scope.go

package main
var a = "G"
func main() {
	n()
	m()
	n()
}

func n() {
	print(a)
}

func m() {
	a = "O"
	print(a)
}