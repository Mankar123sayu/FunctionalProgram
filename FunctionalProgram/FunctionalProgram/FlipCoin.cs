using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunctionalPrograms
{
        public class FlipCoin
        {
            public void Flip(int noOfTimes)
            {
                int head = 0;
                int tail = 0;
                int headcount = 0;
                int tailcount = 0;

                if (noOfTimes > 0)
                {
                    for (int i = 0; i < noOfTimes; i++)
                    {
                        Random random = new Random();
                        int coin = random.Next(2);

                        if (coin == 0)
                        {
                            Console.WriteLine("Its Head!");
                            head = 1;
                            headcount += 1;
                        }
                        else if (coin == 1)
                        {
                            Console.WriteLine("Its Tail!");
                            tail = 1;
                            tailcount += 1;
                        }
                    }
                }
                double headPercentage = (headcount * 100) / noOfTimes;
                double tailPercentage = (tailcount * 100) / noOfTimes;
                Console.WriteLine($"Head Percentage ----> {headPercentage} \n Tail Percentage ----> {tailPercentage}");
            }
        }
}
