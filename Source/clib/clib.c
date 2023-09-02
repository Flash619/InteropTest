#include <stdint.h>
#include <stddef.h>
#include <stdio.h>
#include <limits.h>

int test_interop(
    const uint32_t number1,
    const uint32_t number2,
    const uint32_t number3,
    const void *data1,
    const size_t number4,
    const void *data3,
    const size_t number5
    const size_t number6
    const size_t number7
    const uint32_t number8
)
{
    printf("RECEIVED: \n");
    printf("number1: %u\n", number1);
    printf("number2: %u\n", number2);
    printf("number3: %u\n", number3);
    
    printf("number4: %zu\n", number4);
    
    printf("number5: %zu\n", number5);
    printf("number6: %zu\n", number6);
    printf("number7: %zu\n", number6);
    printf("number8: %u\n", number6);
    
    return number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8;
}