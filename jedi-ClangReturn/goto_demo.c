#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    printf("goto test start...\n");
    goto end;
    printf("display it that means get an error\n");

end:
    printf("Wow, that right!\n");
    printf("The program terminated.\n");

    return 0;
}