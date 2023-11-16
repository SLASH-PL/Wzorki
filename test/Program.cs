using System;

class Program
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
            for (int j = 0; j < i; j++)
                Space();
            Star();
            for (int j = 0; j < n - 2 - 2 * i; j++)
                Space();
            StarLn();
        }

        //pojedyncza gwiazdka w środku
        for (int i = 0; i < n / 2; i++)
            Space();
        StarLn();

        //dolna połówka, symetrycznie do górnej
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            for (int j = 0; j < i; j++)
                Space();
            Star();
            for (int j = 0; j < n - 2 - 2 * i; j++)
                Space();
            StarLn();
        }
    }

    static void Main(string[] args)
    {
        LiteraX(11);
        Console.WriteLine("------------");
        LiteraX(8);
    }
}