using System;

namespace Lesson8Loops;

public class E5
{
    public static void Cubes(int start, int end)
    {
        for(int i = start; i <= end; i++)
        {
            Console.WriteLine($"{i} cubed is {Math.Pow(i,3)}");
        }
    }
}
