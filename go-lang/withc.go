package main

import "fmt"
/*
#include <stdlib.h>
#include <stdio.h>
void hello()
{
	printf("Hello World\n");
}
*/
import "C"

//func Hello() {
//	C.hello();
//}

func Random() int {
	// return int(C.random())
	return int(C.random())
}

func Seed(i int) {
	// C.srandom(C.uint(i))
	C.srandom(C.uint(i))
}

func main() {
	Seed(100)
	fmt.Println("Random:", Random())
//	Hello()
	// fmt.Println("abcdefg")
}
