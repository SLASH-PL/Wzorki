int n = int.Parse(Console.ReadLine());
Wzorek(n);

static void Wzorek(int n)
{
    if (n % 2 == 0)
    {
        n--;
    }

    int middle = n / 2;
    int spaces = middle;

    spaces = 0;

    for (int i = middle ; i >= 0; i--)
    {
        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < i * 2 + 1; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
        spaces++;
    }
        
    
    /*for (int i = 0; i <= middle; i++)  górna połówka nie potrzebna
    {
        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < i * 2 + 1; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
        spaces--;
    }*/
}