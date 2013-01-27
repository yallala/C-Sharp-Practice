using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ObjectCreationPractice
{
    int a, b;
      ObjectCreationPractice()
                {
                    a = 10;
                    b = 20;
                }

                int addition()
                {
                    int c;
                    c = a + b;

                    return c;
                }

    public static void Main(string[] args)
    {
        ObjectCreationPractice FirstObject = new ObjectCreationPractice();
        
        int sum1 = FirstObject.addition();
        Console.WriteLine("Total {0}", sum1);
        Console.Read();

    }
}

//Class = User defined data type
//Class = We use class to groupjectC Similar methods/similar functionality
//Object = Reserves some space from heap. (new)
//FirstObject = This will be stored in stack
//Stack and Heap 
//Ram has total 4 parts of memories.
//1. Stack (only memory location will be here.. Uaually smally memory. "new" will take care of this).
//2. Heap (Huge memory) (Objct related methods, variables will be stored here. "new will create objects..etc).
//3. Global variables
//4. Temporary variables