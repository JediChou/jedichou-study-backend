// Listing 5.12 - for5.go
package main
func main() {
	for i := 0; i < 10; i++ {
		if i == 5 {
			continue
		}
		print(i)
		print(" ")
	}
}
