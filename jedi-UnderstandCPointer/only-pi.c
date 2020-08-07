#include <stdio.h>

int main(void)
{
	int *pi;
	printf("Address of pi (address of an int pointer) : [%d]\n", &pi);
	printf("Address of pi (address of an int pointer) : [%x]\n", &pi);
	printf("Value of pi (value of an int point) : [%d]\n", pi);
	return 0;
}
