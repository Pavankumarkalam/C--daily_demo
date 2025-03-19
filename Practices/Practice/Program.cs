using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practies
{
    
     class Program
    {
        public void OddElement(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==1)
                {
                    Console.WriteLine($"Odd Elements are: {arr[i]}");
                }
            }
        }
        

        static void Main(string[] args)
        {
            Program p=new Program();
            int[] a = new int[] {2,4,5,6,7 };
            var arrname = new[] { "Rv", "Dv", "Tv" };
            p.OddElement(a);
            Console.WriteLine(arrname[2]);

            int[] myArray = new int[5] {3,5,7,4,2 };
            Object[] myObjArr = new Object[5] {4,5,2,7,9 };
            System.Array.Copy(myObjArr, myArray,2);
            //PrintValues(myObjArr);

            Nullable<float> fvalue = null;
            fvalue = 7;
            if (fvalue.HasValue)
            {
                Console.WriteLine(fvalue.Value);
            }
            else
            {
                Console.WriteLine("Null");
            }
        }
    }
}
