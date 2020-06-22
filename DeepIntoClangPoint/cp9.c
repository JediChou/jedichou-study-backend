#include <stdio.h>

int main() {
	int num = 1024;
	int *p = &num;

	// output 1
	printf("Output num's message\n");
	printf("&num: [%p], num: [%d].\n\n", &num, num);

	// output 2
	printf("Output *p message with 4 styles\n");
	printf("&p: [%d], p: [%d]\n", &p, p);
	printf("&p: [%x], p: [%d]\n", &p, p);
	printf("&p: [%o], p: [%d]\n", &p, p);
	printf("&p: [%p], p: [%p]\n", &p, p);

	return 0;
}
