using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a natural number: ");

        ulong number = ulong.Parse(Console.ReadLine());
        int power = 0;
        bool finish = false;

        while (!finish)
        {
            if (number >= Math.Pow(10, power) && number <= Math.Pow(10, (power + 1)))
            {
                if (power == 0)
                {
                    Console.WriteLine($"Given number is in range ( {Math.Pow(10, power)} , {Math.Pow(10, (power + 1))} )");
                }
                else Console.WriteLine($"Given number is in range ( {Math.Pow(10, power) + 1} , {Math.Pow(10, (power + 1))} )");
                finish = true;
            }
            else power++;
        }
        Console.ReadKey();

    }
}
