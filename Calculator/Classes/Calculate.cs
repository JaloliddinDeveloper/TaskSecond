public class Calculate
{
    public static string CalculateMethod(double a, double b, string c)
    {
        double result = 0;

        var action = c switch
        {
            "+" => result = a + b,
            "-" => result = a - b,
            "*" => result = a * b,
            "/" => result = b != 0 ? a / (double)b : throw new DivideByZeroException(),
            _ => throw new InvalidOperationException("Invalid operation")
        };

        return $"{a} {c} {b} = {result}";
    }

    public static string SumMethod(int n)
    {
        int s = 0;
        for (int i = 1; i <= n; i++)
        {
            s = s + i;
        }
        return s.ToString();
    }

    public static string IsPrime(int n)
    {
        int s = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                s++;
            }
        }
        return s == 2 ? $"Berilgan {n} soni tub son ekan " : $"Berilgan {n} soni tub son emas ekan ";
    }
}
