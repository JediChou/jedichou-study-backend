package main
import "fmt"

func main() {
	var number int = 5
	for number >= 0 {
		number = number - 1
		fmt.Printf("The variable number is now: %d\n", number)
	}
}
