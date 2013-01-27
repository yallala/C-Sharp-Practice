using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCreationPractice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username, address;
            int age, phone;

            Console.WriteLine("Enter user name");
            Username= Console.ReadLine();

            Console.WriteLine("Enter user address");
            address  = Console.ReadLine();

            Console.WriteLine("Enter User age");
            age = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter user phone number");
            phone = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" Name = {0} \n address = {1} \n age = {2} \n phonenumber = {3}", Username, address, age, phone);
            Console.ReadLine();
         }
    }
}
//Take user details like name , address, age, telephone and print