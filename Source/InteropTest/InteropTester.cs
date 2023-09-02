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
        var number3 = 64;
        var data1 = RandomNumberGenerator.GetBytes(64);
        var data2 = RandomNumberGenerator.GetBytes(64);
        var number4 = 86;
        var number5 = 108;
        var data3 = RandomNumberGenerator.GetBytes(64);
        var data4 = RandomNumberGenerator.GetBytes(64);
        var number6 = 132;
        
        Console.WriteLine("SENT: ");
        Console.WriteLine("number1: {0}", number1);
        Console.WriteLine("number2: {0}", number2);
        Console.WriteLine("number3: {0}", number3);
        
        Console.WriteLine("number4: {0}", number4);
        Console.WriteLine("number5: {0}", number5);
        
        Console.WriteLine("number6: {0}", number6);

        var response = test_interop(
            number1,
            number2,
            number3,
            data1,
            data2,
            number4,
            number5,
            data3,
            data4,
            number6
        );

        return response == number1 + number2 + number3 + number4 + number5 + number6;
    }

    [DllImport("clib", EntryPoint = "test_interop", CallingConvention = CallingConvention.Cdecl)]
    private static extern int test_interop(int number1, int number2, int number3, byte[] data1, byte[] data2, int number4, int number5, byte[] data3, byte[] data4, int number6);
}