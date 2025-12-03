using System;

namespace Lesson8Loops;

public static class E3
{
    public static void Fibonacci(int n)
    {
        int f0 = 0;
        int f1 = 1;
        int f = 0;

        if (n == 1)
        {
            Console.Write($"{f0}");
            return;
        }
        if (n == 2)
        {
            Console.Write($"{f0} {f1}");
            return;
        }

        for(int i = 1; i<=n; i++)
        {
            if (i == 1)
            {
                Console.Write($"{f0} ");
                continue;
            }
                
            if (i == 2)
            {
                Console.Write($"{f1} ");
                continue;
            }
            
            f = f0 + f1;
            Console.Write($"{f} ");
            f0 = f1;
            f1 = f;
        }
    }

}
