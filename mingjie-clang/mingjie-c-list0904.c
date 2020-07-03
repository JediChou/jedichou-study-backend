/*
 * file: mingjie-c-list0904.c
 * description: read string from console input.
 */

#include <stdio.h>

int main(void)
{
	char name[40];

	printf("pls input your name: ");
	scanf("%s", name);

	printf("Hello, %s Mr/Mrs!\n", name);
	return 0;
}
