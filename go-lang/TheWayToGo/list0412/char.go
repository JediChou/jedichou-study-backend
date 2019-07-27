package main

import "fmt"

func main() {
	// define character variables
	var ch int  = '\u0041'
	var ch2 int = '\u03B2'
	var ch3 int = '\U00101234'

	// output
	fmt.Printf("%d - %d - %d\n", ch, ch2, ch3)  // integer
	fmt.Printf("%c - %c - %c\n", ch, ch2, ch3)  // character
	fmt.Printf("%X - %X - %X\n", ch, ch2, ch3)  // UTF-8 bytes
	fmt.Printf("%U - %U - %U\n", ch, ch2, ch3)  // UTF-8 code point

	// The package unicode has useful function for testing
	// characters, like (ch is a character):
	//    testing for a letter:  unicode.IsLetter(ch)
	//    testing for a digit:   unicode.IsDigit(ch)
	//    testing for a whitespace character: unicode.IsSpace(ch)
}
