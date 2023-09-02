using System;
using InteropTest;

var tester = new InteropTester();

if (!tester.Test())
{
    Console.WriteLine("Interop test failed!");
}
else
{
    Console.WriteLine("Interop test passed! :D");
}