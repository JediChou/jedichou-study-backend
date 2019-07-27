// Listing 5.7, for_string.go
package main
import "fmt"

func main() {
	forString1()
	fmt.Println()
	forString2()
}

func forString1() {
	str := "Go is a beautiful language!"
	fmt.Printf("The length of str is: %d\n", len(str))
	for ix := 0; ix < len(str); ix++ {
		fmt.Printf("Character on position %d is: %c\n", ix, str[ix])
	}
}

func forString2() {
	str2 := "日本語"
	fmt.Printf("The length of str2 is: %d\n", len(str2))
	for ix := 0; ix < len(str2); ix++ {
		fmt.Printf("Character on position %d is: %c\n", ix, str2[ix])
	}
}
