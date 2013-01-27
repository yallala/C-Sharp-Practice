using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ArithmeticOperations
    {
           
                int a, b;

    public ArithmeticOperations(int X,int Y)
                {
                a = X;
                b = Y;
                }

    public int add()
                {
                    return a+b;
                }

    public int Sub()
                {
                    return a-b;
                }

    public int multi()
                {
                    return a*b;
                
                }

    public int div()
                {
                    return a/b;
                }
}
class Program
{
    public static void Main(string[] args)
        {
            Console.WriteLine("Enter A value");
            int val1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter B value");
            int val2 = Int32.Parse(Console.ReadLine());
            ArithmeticOperations FirstObject = new ArithmeticOperations(val1,val2);
            Console.WriteLine(" Addition is {0} \n Subtraction is {1} \n Multiplication is {2} \n Division is {3} \n", FirstObject.add(),FirstObject.Sub(),FirstObject.multi(),FirstObject.div());
            RLOperations SecondObject = new RLOperations(val1, val2);
            SecondObject.Arth_GreaterThan();
            Console.ReadLine();
        }

    }

   public class RLOperations
    { 
        //>, <, >=, <=, ==
        int a, b;

        public RLOperations(int X, int Y)
        {
            a = X;
            b = Y;
        }

        public void Arth_GreaterThan()
        {
            
           if (a > b)
           {
               Console.WriteLine("A is bigger than B");
           }
        }
        

    }
        
    

