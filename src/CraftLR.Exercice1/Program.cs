using System;
namespace CraftLR.Exercice1;

public static class Program
{
    public static void Main(string[] _)
    {
        Method1();
        Method2();
        Method3();
        Console.Read();
    }

    private static void Method1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
    }

    private static void Method2()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method2 :" + i);
            if (i == 3)
            {
                Console.WriteLine("Performing the Database Operation Started");
                Thread.Sleep(10000); // Sleep for 10 seconds
                Console.WriteLine("Performing the Database Operation Completed");
            }
        }
    }

    private static void Method3()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method3 :" + i);
        }
    }
}
