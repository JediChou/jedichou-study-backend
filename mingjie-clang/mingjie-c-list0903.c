// file: mingjie-c-list0903.c
// description: save string to a char array (string initialize)

#include <stdio.h>

int main(void)
{
				char str1[] = "ABC";
				char str2[] = {'A','B','C','\0'};

				printf("str1: [%s].\n", str1);
				printf("str2: [%s].\n", str2);

				return (0);
}
