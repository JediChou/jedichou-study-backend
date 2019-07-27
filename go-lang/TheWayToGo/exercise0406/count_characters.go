package main

import (
	"fmt"
	// "unicode/utf8"
)

func main() {
	s1 := "asSASA ddd dsjkdsjs dk"
	fmt.Printf("%s1, length is %d\n", s1, len(s1))
	
	s2 := "这里有一堆中文"
	fmt.Printf("%s, length is :", s2, len(s2))
}
