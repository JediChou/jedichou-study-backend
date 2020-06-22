#include <stdio.h>
#include <stdlib.h>

int main() {
	int num = 100;
	int *pi = &num;
	printf("Address of num: %p, value: %d\n", &num, num);
	printf("Address of *pi: %p, value: %p\n", &pi, pi);
	
	return 0;
}
