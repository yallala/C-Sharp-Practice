  //    Caluclate the electrical bill payment.
  //    Read the units from the user and print the bill amount
  //    Conditions:
  //    if units from 0 to 100 -----> 3 Rs. per unit
  //    units from 101 to 300 -----> 4.50 Rs. per unit
  //    units from 301 to 500 -----> 6 Rs. per unit
  //    units from 501 to 700 -----> 7 Rs. per unit
  //    units > 700 -----> 7.50 Rs. per unit

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Units");
            int Units = Int32.Parse(Console.ReadLine());

            if ((Units >= 0) && (Units <= 100))
            {
                int TotalPrice_1 = (Units * 3);
                Console.WriteLine("Total units {0} \nYour total cost is ${1} \nYou fall under \"0 to 100\" range", Units, TotalPrice_1);
                Console.ReadLine();
            }
            else if ((Units >= 101) && (Units <= 300))
            {
                float TotalPrice_2 = (Units * 4.5F);
                Console.WriteLine("Total units {0} \nYour total cost is ${1} \nYou fall under \"100 to 300\" range", Units, TotalPrice_2);
                Console.ReadLine();

            }
            else if ((Units >= 301) && (Units <= 500))
            {
                int TotalPrice_3 = (Units * 6);
                Console.WriteLine("Total units {0} \nYour total cost is ${1} \nYou fall under \"300 to 500\" range", Units, TotalPrice_3);
                Console.ReadLine();
            }
            else if ((Units >= 501) && (Units <= 700))
            {
                int TotalPrice_4 = (Units * 7);
                Console.WriteLine("Total units {0} \nYour total cost is ${1} \nYou fall under \"500 to 700\" range", Units, TotalPrice_4);
                Console.ReadLine();
            }
            else
            {
                float TotalPrice_5 = (Units * 7.50f);
                Console.WriteLine("Total units {0} \nYour total cost is ${1} \nYou fall under \"Greater than 700\" range", Units, TotalPrice_5);
                Console.ReadLine();
            }
        }
    }
        }



