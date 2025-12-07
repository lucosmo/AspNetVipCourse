namespace Lesson8Loops;

class Program
{
    static void Main(string[] args)
    {
        /*
        int number = 100;
        bool isPrime = E1.CheckIsPrimeNumber(number);
        string prime = isPrime ? "is" : "is not";
        Console.WriteLine($"{number} {prime} a prime number");
        */

        /*
        int number = 1000;
        E2 obj = new();
        obj.PrintEvens(number);
        */

        /*
        int number = 4;
        E3.Fibonacci(number);
        */

        /*
        int number = 10;
        E4.DigitalTree(number);
        */

        /*
        int start = 1;
        int end = 20;
        E5.Cubes(start, end);
        */

        /*
        int start = 0;
        int end = 20;
        double sum = E6.CalculateSum(start, end);
        Console.WriteLine(sum);
        */

        /*
        int oddNumber = 9;
        E7.DrawDiamond(oddNumber);
        */

        /*
        string str = "AbcdefgGGh";
        string reversed = E8.ReverseString(str);
        Console.WriteLine($"Reversed {str} is {reversed}");
        */

        /*
        int number = 5;
        List<bool> list = E9.DecimalToBinary(number);
        E9.PrintBinary(list, number);
        */

        int number1 = 48;
        int number2 = 180;

        int gcd = E10.GreatestCommonDivisor(number1, number2);
        int lcm = E10.LeastCommonMultiple(number1, number2, gcd);
        Console.WriteLine($"Least Common Multiple of {number1} and {number2} is {lcm}");

    }
}
