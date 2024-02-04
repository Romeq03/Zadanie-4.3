using System;

class Program
{
    static void Main()
    {
        int[] tablica = new int[100];

        for (int i = 0; i < 100; i++)
        {
            tablica[i] = i + 1;
        }

        int sumaParzyste = 0;
        int sumaNieparzyste = 0;

        foreach (int liczba in tablica)
        {
            if (liczba % 2 == 0)
            {
                sumaParzyste += liczba;
            }
            else
            {
                sumaNieparzyste += liczba;
            }
        }

        Console.WriteLine("Suma liczb parzystych: " + sumaParzyste);
        Console.WriteLine("Suma liczb nieparzystych: " + sumaNieparzyste);

        Console.ReadLine();
    }
}
