using System.Text;

namespace Lesson8Loops;

public class E9
{
    public static string DecimalToBinary(int number)
    {
        if (number <= 0)
        {
            return "0";
        }
        StringBuilder output = new();
        int num = number;
        while (num >= 1)
        {
            output.Append(num % 2);
            num/=2;
        }
        return output.ToString();
    }

    public static void PrintBinary(int number)
    {
        string binaryStr = DecimalToBinary(number);
        Console.Write($"Decimal {number} is equal to binary {binaryStr}");
    }
}
