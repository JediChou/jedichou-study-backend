// file: mingjie-c-ex0901.c
// description: add some chars after \0 mark. 

#include <stdio.h>

int main(void)
{
				char str[] = "ABC\0EFG";
				printf("str: [%s].\n", str);
				return (0);
}
