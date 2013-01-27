using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
   class SimpleInterest
    {
        static void Main(string[] args)
        {
            double[] PNR = new double[4];
            Console.WriteLine("Enter P value");
            PNR[0] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter N value");
            PNR[1] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter R values");
            PNR[2] = Int32.Parse(Console.ReadLine());
            PNR [3] = PNR[0] * PNR[1] * PNR[2] / 100;
            Console.WriteLine("PNR is {0}", PNR[3]);
            Console.ReadLine();
         }
    }
}
