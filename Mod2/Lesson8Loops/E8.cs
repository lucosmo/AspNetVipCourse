using System;

namespace Lesson8Loops;

public class E8
{
    public static string ReverseString(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        
        char[] reversed = str.ToCharArray();
        Array.Reverse(reversed);
        for (int i = 0; i <= str.Length-1; i++)
        {
            if (char.IsUpper(str[i]))
            {
                reversed[i] = char.ToUpper(reversed[i]);
            }
            if (char.IsLower(str[i]))
            {
                reversed[i] = char.ToLower(reversed[i]);
            }
        }
        return new string(reversed);
    }
}
