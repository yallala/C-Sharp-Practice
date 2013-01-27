// calculate the gross salary of an employee 
// gross sal=Basic + HRA+DA-PF
// HRA=50%of basic
//	DA=25%of basic
//	PF=15%of Basic



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossSalary
{


   public class OtherSalaries
    {
    int Con_1;

    public OtherSalaries(int Base_Sal)
        {
            Con_1 = Base_Sal;
        }

        public int HRA()
        {
           return (Con_1 * 50 / 100);
        }

        public int DA()
        {
            return (Con_1 * 25 / 100);
        }

        public int PF()
        {
            return (Con_1 * 15 / 100);
        }
        public int TotGross()
        {
            return (Con_1 + HRA() + DA() + PF());
        }
     }
    
    class GrossSalaryClass    {
       
       public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Basic Salary Of the Employee");
            int BasicSalary = Int32.Parse( Console.ReadLine());
            OtherSalaries  GS = new OtherSalaries(BasicSalary);
            Console.WriteLine("Your Base Basalary is {0}", BasicSalary);
            Console.WriteLine("           Your HRA is {0}",GS.HRA());
            Console.WriteLine("            Your DA is {0}", GS.DA());
            Console.WriteLine("            Your PF is {0}", GS.PF());
            int TotGross = BasicSalary + GS.HRA();
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Your Gross Salary is {0}", GS.TotGross ());
            Console.ReadLine();
         }

      }
}
