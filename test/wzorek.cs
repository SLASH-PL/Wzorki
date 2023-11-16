class Program
{
    const char CHAR = '*';
    static void Star() => Console.Write(CHAR);
    static void StarLn() => Console.WriteLine(CHAR);
    static void Space() => Console.Write(" ");
    static void SpaceLn() => Console.WriteLine(" ");
    static void NewLine() => Console.WriteLine();

    static void Wzorek(int n)
    {
        if (n < 3) return;
        if (n % 2 == 0) n = n + 1;

        //top half
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < i; j++) //space before
            {
                Space();
            }
            Star();
            for (int j = 0; j < n - 2 - 2 * i; j++) //space in between
            {
                Space();
            }
            StarLn();
        }
        //star mid
        for (int i = 0; i < n / 2; i++)
        {
            Space();
        }
        StarLn();

        //bottom half
        for (int i = n / 2; i > 0; i--)
        {
            for (int j = i - 1; j > 0; j--) //space before
            {
                Space();
            }
            Star();
            for (int j = 0; j < n - 2 * i; j++) //spacje in between
            {
                Space();
            }
            StarLn();
        }
    }
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        Wzorek(n);
    }
} 
