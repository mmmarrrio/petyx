using System;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Transactions;
namespace dz3
{
    class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what do you need, calculator or guesser?");
            string Z = Console.ReadLine();
            if (Z == "guesser")
            {
                Console.WriteLine("gues what numb we guessed (for esier to you  it's somewhere from 0-1000)");
                Random rnd = new Random();
                int rn = rnd.Next(1001);
                int x = 0;
                while (x == 0)
                {
                    int f = int.Parse(Console.ReadLine());
                    if (f > rn)
                    {
                        Console.WriteLine("less");
                        x = 0;
                    }
                    else if (f < rn)
                    {
                        Console.WriteLine("more");
                        x = 0;
                    }
                    else
                    {
                        Console.WriteLine("you won!!!! you should go start gambling!");
                        x++;
                    }
                }
            }
            else if (Z == "calculator")
            {
                Console.WriteLine("enter ur frst numb!");
                int z = int.Parse(Console.ReadLine());
                Console.WriteLine("enter ur scnd numb!");
                int c = int.Parse(Console.ReadLine());
                int d = z + c;
                Console.WriteLine("equals! = "+d);
            }
            else
            {
                Console.WriteLine("actually... neverminde! ur spell issue is rlly bad :(");
            }
        }
    }
}
