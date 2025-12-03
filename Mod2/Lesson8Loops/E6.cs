using System;

namespace Lesson8Loops;

public class E6
{
    public static double CalculateSum(int start, int stop)
    {
        double sum = 0.0;
        int i = start;
        do
        {
            if (i != 0)
                sum += Math.Pow(i,-1);
            i++;
        } while ( i<= stop);
        return sum;
    }
}
