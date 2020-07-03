// Save string to an array
#include <stdio.h>

int main(void)
{
	char str[4];  // define a char array

	str[0] = 'A';
	str[1] = 'B';
	str[2] = 'C';
	str[3] = '\0';

	printf("str: [%s].\n", str);  // echo str as string
	return 0;
}
