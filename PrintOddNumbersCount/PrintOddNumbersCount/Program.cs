using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputnumber;

            Console.WriteLine("Enter a number");
            inputnumber = Int32.Parse(Console.ReadLine());

            int i;
            List<int> sumodd = new List<int>();
            int oddcounter = 0;

            for (i = 0; i < inputnumber; i++)
            {
                if (IsOdd(i))
                {
                    Console.WriteLine(i);
                    oddcounter++;
                    sumodd.Add(i);
                }
            }

            Console.WriteLine("Number of odd numbers found is {0}", oddcounter);
            int sum = sumodd.Sum();

            Console.WriteLine("Sum of all odd numbers till {0} is {1}", inputnumber, sum);
            Console.ReadLine();
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }

}
