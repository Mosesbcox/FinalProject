using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Random eightBall = new Random();
            int randomNum = eightBall.Next(7);
            string answer = Fortune(randomNum);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

        static string Fortune(int num)
        {
            string fortune1 = "You'll live a long life!";
            string fortune2 = "You'll be rich!";
            string fortune3 = "You'll have 17 kids!";
            string fortune4 = "You'll marry a bum!";
            string fortune5 = "You'll have a mansion!";
            string fortune6 = "You'll marry a millionaire!";
            string fortune7 = "You'll be an athele!";
            string fortune8 = "You'll smell like feet FOREVER!!";

            if (num == 1)
            {
                return fortune1;
            }
            if (num == 2)
            {
                return fortune2;
            }
            if (num == 3)
            {
                return fortune3;
            }
            if (num == 4)
            {
                return fortune4;
            }
            if (num == 5)
            {
                return fortune5;
            }
            if (num == 6)
            {
                return fortune6;
            }
            if (num == 7)
            {
                return fortune7;
            }
            else
            {
                return fortune8;
            }
        }
    }
}
