using FunctionalPrograms;
using System;

namespace FunctionalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programs");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute \n 1. Flip Coin \n 2. LeapYear \n 3. PowerOf2 \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flip = new FlipCoin();
                        Console.WriteLine("Enter num of flips: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        flip.Flip(num);
                        break;
                }
            }
        }
    }
}