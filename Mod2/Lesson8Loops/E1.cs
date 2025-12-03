
namespace Lesson8Loops;

public static class E1
{
    public static bool CheckIsPrimeNumber(int end)
    {
        if(end <= 1)
            return false;
        if(end==2 || end ==3)
            return true;
        if(end %2 == 0)
            return false;
        double sqrt = Math.Sqrt(end);
        for(int i = 3; i <= sqrt; i+=2)
        {
            if (end % i == 0)
                return false;
        }
        return true;
    }
}
