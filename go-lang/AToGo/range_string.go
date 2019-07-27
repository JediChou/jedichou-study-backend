// Listing 5.9 - range_string.go

package main
import "fmt"

func main() {
	// example 1
	str := "Go is a beautiful language!"
	for position, char := range str {
		fmt.Printf("Character on position %d is %c \n", position, char)
	}
	
	fmt.Println()
	// example 2
	str2 := "Chinese: 漢語"
	for position, char := range str2 {
		fmt.Printf("Character %c starts at byte position %d\n", char, position)
	}
	
	fmt.Println()
	// example 3
	fmt.Println("index int(rune) rune	char bytes")
	for index, rune := range str2 {
		fmt.Printf("%-2d	%d	%U '%c' % X\n", index, rune, rune, rune, []byte(string(rune)))
	}
}
