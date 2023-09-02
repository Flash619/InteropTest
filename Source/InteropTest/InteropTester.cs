using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace InteropTest;

public class InteropTester
{
    public bool Test()
    {
        var number1 = 24;
        var number2 = 48;
        var number3 = 1223;
        var data1 = RandomNumberGenerator.GetBytes(64);
        var number4 = 86;
        var data2 = RandomNumberGenerator.GetBytes(64);
        var number5 = 108;
        var number6 = 132;
        var number7 = 1935;
        var number8 = 213;
        
        Console.WriteLine("SENT: ");
        Console.WriteLine("number1: {0}", number1);
        Console.WriteLine("number2: {0}", number2);
        Console.WriteLine("number3: {0}", number3);
        
        Console.WriteLine("number4: {0}", number4);
        
        Console.WriteLine("number5: {0}", number5);
        Console.WriteLine("number6: {0}", number6);
        Console.WriteLine("number7: {0}", number7);
        Console.WriteLine("number8: {0}", number8);

        var response = test_interop(
            number1,
            number2,
            number3,
            data1,
            number4,
            data2,
            number5,
            number6,
            number7,
            number8
        );

        return response == number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8;
    }

    [DllImport("clib", EntryPoint = "test_interop", CallingConvention = CallingConvention.Cdecl)]
    private static extern int test_interop(int number1, int number2, int number3, byte[] data1, int number4, byte[] data2, int number5, int number6, int number7, int number8);
}