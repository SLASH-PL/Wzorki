using System.Threading.Channels;

class kfadrat
{
    const char CHAR = '*';
    static void Star() => Console.Write(CHAR);
    static void StarLn() => Console.WriteLine(CHAR);
    static void Space() => Console.Write(" ");
    static void SpaceLn() => Console.WriteLine(" ");
    static void NewLine() => Console.WriteLine();

    public static void Prostokat(int n, int m)
    {
        for (int i = 0; i < n; i++)
        {
            Star();
        }
        NewLine();

        for (int j = 1; j < m - 1; j++)
        {
            Star();
            for (int i = 1; i < n - 1; i++)
            {
                Space();
            }
            StarLn();
        }

        for (int i = 0; i < n; i++)
        {
            Star();
        }
        NewLine();
    }

    public static void Main()
    {
        Prostokat(10, 7);
    }
}