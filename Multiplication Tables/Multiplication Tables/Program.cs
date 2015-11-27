using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    string m = string.Format("{0, 4}", i * j);
                    Console.Write(m);

                } Console.WriteLine();
            } Console.ReadLine();
        } 
    }
}
