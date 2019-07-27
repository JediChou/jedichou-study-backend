/* 
 * file name: thread.c
 * from Go Program, page 106
 * demo for thread program in C
 */

#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

void *count();
pthread_mutex_t mutex1 = PTHREAD_MUTEX_INITIALIZER;
int counter = 0;

main()
{
	int rc1, rc2;
	pthread_t thread1, thread2;

	/* Create threads, every thread execute functionC */
	if( (rc1 = pthread_create(&thread1, NULL, &add, NULL)) )
	{
		printf("Thread creation failed: %d\n", rc1);
	}

	if( (rc2 = pthread_create(&thread2, NULL, &add, NULL)) )
	{
		printf("Thread creation failed: %d\n", rc2);
	}

	/* Wait all thread execute complete */
	pthread_join(thread1, NULL);
	pthread_join(thread2, NULL);

	exit(0);
}

void *count()
{
	pthread_mutex_lock( &mutex1 );
	counter++;
	printf("Counter value: %d\n", counter);
	pthread_mutex_unlock( &mutex1 );
}
