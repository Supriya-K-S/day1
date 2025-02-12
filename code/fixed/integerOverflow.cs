using System;

class Math
{
    static int add(int a, int b)
    {
        if (a > 0 && b > 0 && (a > int.MaxValue - b))  // Check for overflow
        {
            Console.WriteLine("Overflow detected! Returning int.MaxValue.");
            return int.MaxValue;  // Prevent wraparound
        }
        return a + b;
    }

    static void Main()
    {
        int x = 2147483647;
        int y = 1;
        int result = add(x, y);

        Console.WriteLine("Result: " + result);
    }
}
