using System;

namespace Lesson8Loops;

public class E2
{
    List<int> evens = [];
    private void SaveEvens(int n)
    {
        int i = 0;
        if (n < 0)
            return;
        
        do
        {
            evens.Add(i);
            i+=2;
        } while (i<=n);
    }

    public void PrintEvens(int n)
    {
        SaveEvens(n);
        foreach(int i in evens)
        {
            Console.Write($"{i} ");
        }
    }
}
