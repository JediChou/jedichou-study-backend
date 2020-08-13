#include <stdio.h>
#include <stdlib.h>

/* 第一种定义方式 */
struct date_s1 {int day, month, year;};

/* 第二种定义方式 */
struct date_s2 {
    int day;
    int month;
    int year;
};

int main(void) {

    /* 创建一个date_s1变量 */
    struct date_s1 date_s1_v1;
    date_s1_v1.year = 2012;
    date_s1_v1.month = 8;
    date_s1_v1.day = 20;
    printf("date_s1_v1: %d-%d-%d\n", 
        date_s1_v1.year,
        date_s1_v1.month,
        date_s1_v1.day
    );

    /* 创建一个date_s2变量 */
    struct date_s2 date_s2_v2;
    date_s2_v2.year = 2020;
    date_s2_v2.month = 8;
    date_s2_v2.day = 20;
    printf("date_s2_v2: %d-%d-%d\n",
        date_s2_v2.year,
        date_s2_v2.month,
        date_s2_v2.day
    );

    return 0;
}