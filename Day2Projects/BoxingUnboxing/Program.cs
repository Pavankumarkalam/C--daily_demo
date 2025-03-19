using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //value type is going inside ref type then it is called boxing 
            //while displaying ref type which is storing value type it is called 
            //unboxing 
            // now this process of boxing and unboxing should happen for same type of data types compatibity should match 
            // means int x=45 i cannot put it in string eventhough string is reference type 


            object objone;//ref type
            int numberone; //value type 
            numberone = 77;
            objone = numberone;//boxing

            int result = (int)objone;//unboxing only by taking into another variable 

            Console.WriteLine($"objectone is {objone}");//unboxing

            // Boxing: Converting a string value to an object type
            string originalString = "Hello, Boxing and Unboxing!";
            object boxedString = originalString;

            Console.WriteLine("Boxed string: " + boxedString);

            // Unboxing: Converting the object back to a string
            string unboxedString = (string)boxedString;

            Console.WriteLine("Unboxed string: " + unboxedString);

            // Check if the original and unboxed strings are equal
            if (originalString.Equals(unboxedString))
            {
                Console.WriteLine("The original and unboxed strings are equal.");
            }

            

            Console.ReadLine();
        }
    }
}
