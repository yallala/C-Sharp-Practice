using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintThetTables
{
    class Program
    {
        static void Main(string[] args)
        {
            int TableValue, Increment;
            Console.WriteLine("Enter the table value");
            TableValue = Int32.Parse(Console.ReadLine());

              int TableValuePrint; 

              for (Increment = 1; Increment <=10; Increment ++)
                {
                    TableValuePrint = TableValue * Increment ;
                    Console.WriteLine("{0} * {1} = {2}", TableValue, Increment, TableValuePrint);
                }
                       
                    Console.ReadLine();
        }
    }
}
