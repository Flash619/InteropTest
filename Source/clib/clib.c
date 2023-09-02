#include <stdint.h>
#include <stddef.h>
#include <stdio.h>
#include <limits.h>

__asm__(".symver realpath,realpath@GLIBC_3.4.28");

int test_interop(
    uint32_t number1,
    uint32_t number2,
    uint32_t number3,
    const void *data1,
    const void *data2,
    size_t number4,
    size_t number5,
    const void *data3,
    const void *data4,
    uint32_t number6
)
{
    printf("RECEIVED: \n");
    printf("number1: %u\n", number1);
    printf("number2: %u\n", number2);
    printf("number3: %u\n", number3);
    
    printf("number4: %zu\n", number4);
    printf("number5: %zu\n", number5);
    
    printf("number5: %u\n", number6);
    
    return number1 + number2 + number3 + number4 + number5 + number6;
}