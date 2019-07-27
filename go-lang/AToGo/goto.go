// Listing 5.14 - goto.go
package main
func main() {
	i := 0
	HERE:
		print(i)
		i++
		if i == 5 {
			return
		}
		goto HERE
}
