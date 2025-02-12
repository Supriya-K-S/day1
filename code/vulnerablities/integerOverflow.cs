using System;

class HelloWorld
{
    static int add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int x = 2147483647;
        int y = 1;
        int result = add(x, y);  // Fixed function call

        Console.WriteLine("Result: " + result);
    }
} 
