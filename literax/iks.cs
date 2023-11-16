using System.Threading.Channels;

class iks
{
    const char CHAR = '*';
    static void Star() => Console.Write(CHAR);
    static void StarLn() => Console.WriteLine(CHAR);
    static void Space() => Console.Write(" ");
    static void SpaceLn() => Console.WriteLine(" ");
    static void NewLine() => Console.WriteLine();

    static void LiteraX(int n)
    {
        if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
        if (n % 2 == 0) n = n + 1;

        //górna połówka
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < i; j++) //spacje przed
            {
                Space();
            }
            Star();
            for (int j = 0; j < n - 2 - 2 * i; j++) //spacje w środku
            {
                Space();
            }   
            StarLn();
        }
        
        //pojedyncza gwiazdka w środku
        for (int i = 0; i < n / 2; i++)
        {
            Space();
        }
        StarLn();

        //dolna połówka, symetrycznie do górnej
        for (int i = n / 2; i > 0; i--)
        {
            for (int j = i - 1; j > 0; j--) //spacje przed
            {
                Space();
            }
            Star();
            for (int j = 0; j < n - 2 * i; j++) //spacje w środku
            {
                Space();
            }
            StarLn();
        }

    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.Clear();
        int x = int.Parse(input);
        LiteraX(x);
    }
}