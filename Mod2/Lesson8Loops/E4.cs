using System;

namespace Lesson8Loops;

public static class E4
{
    public static void DigitalTree(int n)
    {
        int maxDigitsInRow = 1;
        int digitsInRow = 1;

        for(int digit = 1; digit <= n; digit++)
        {
            if (digitsInRow <= maxDigitsInRow)
            {
                Console.Write(digit);
                digitsInRow++;
            }
            if (digitsInRow > maxDigitsInRow)
            {
                Console.WriteLine();
                maxDigitsInRow++;
                digitsInRow = 1;
            }
        }
    }
}
