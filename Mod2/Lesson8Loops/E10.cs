namespace Lesson8Loops;

public class E10
{
    public static int GreatestCommonDivisor(int number1, int number2)
    {
        int a = number1;
        int b = number2;

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    public static int LeastCommonMultiple(int number1, int number2, int gcd)
    {
        return number1 * number2 / gcd;
    }
}
