namespace Lesson8Loops;

public class E9
{
    public static List<bool> DecimalToBinary(int number)
    {
        List<bool> output = [];
        int num = number;
        while (num >= 1)
        {
            output.Add(num % 2 == 1);
            num/=2;
        }
        return output;
    }

    public static void PrintBinary(List<bool> list, int number)
    {
        Console.Write($"Decimal {number} is equal to binary ");
        foreach (bool x in list)
        {
            char value = x == true ? '1' : '0';
            Console.Write(value);
        }
    }
}
