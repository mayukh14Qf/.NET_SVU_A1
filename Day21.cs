using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day21
    {
        static void Main(string[] args)
        {

            // Find The Max And Min Digit of A Number

            //Console.WriteLine("Enter Your Number ");
            //int num1= Convert.ToInt32(Console.ReadLine());

            //int min = 9;
            //int max = 0;   

            //while (num1 > 0)
            //{
            //    min=Math.Min(min,num1%10);
            //    max = Math.Max(max, num1 % 10);
            //    num1 = num1 / 10;
            //}

            //Console.WriteLine("Min is " + min);
            //Console.WriteLine("Max is "+max);


            // String

            string var1 = "Mayukhjit Chakraborty" ;

            // Length

            Console.WriteLine(var1.Length);


            // Index of

            Console.WriteLine(var1.IndexOf('u'));
            Console.WriteLine(var1.IndexOf('M'));
            Console.WriteLine(var1.IndexOf('z')); // -1 (Absent)

            // Accessing Particular Index Value


            Console.WriteLine(var1[6]);
            Console.WriteLine(var1[9]);
            Console.WriteLine(var1[20]);

            // Substring

            Console.WriteLine(var1.Substring(0,21)); // ending point is Excluded
            
            // contains

            Console.WriteLine(var1.Contains('y'));
            Console.WriteLine(var1.Contains('z'));

            // equals

            string var2 = "Mayukhjit Chakraborty";

            Console.WriteLine(var1.Equals(var2));

            // trim

            string var3 = "***antara***";
            Console.WriteLine(var3.Length);

            Console.WriteLine(var3.Trim('*'));

            // replace

            Console.WriteLine(var2.Replace('a','z'));
            Console.WriteLine(var2.Replace("Chakraborty","XYZ"));


            // remove

            Console.WriteLine(var2.Remove(10));
            Console.WriteLine(var2.Remove(10,3));



        }
    }
}
