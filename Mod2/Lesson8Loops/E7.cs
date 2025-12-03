using System;
using System.Diagnostics.CodeAnalysis;

namespace Lesson8Loops;

public class E7
{
    public static void DrawDiamond(int diagonal)
    {
        if (diagonal % 2 == 0)
        {
            return;
        }
        for (int i = 1; i <= diagonal; i += 2)
        {
            DrawHalfDiamond(i, diagonal);
        }
        for (int i = diagonal - 2; i >= 1; i -= 2)
        {
            DrawHalfDiamond(i, diagonal);
        }
    }

    private static void DrawHalfDiamond(int i, int diagonal)
    {
        int spaces = (diagonal - i) / 2 ;
        int stars = i;
        Console.Write(new string(' ', spaces));
        Console.Write(new string('*', stars));
        Console.WriteLine();
    }
}
