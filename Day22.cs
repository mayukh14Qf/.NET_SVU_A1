using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day22
    {

        static void Main(String[] args)
        {
            // String

            string var1 = "Mayukhjit Chakraborty";

            // Length
            // it will return the number of characters present in a string 
            Console.WriteLine(var1.Length);


            // Index of
            //It will take one character' will retun corresponding index
            Console.WriteLine(var1.IndexOf('u'));
            Console.WriteLine(var1.IndexOf('M'));
            Console.WriteLine(var1.IndexOf('z')); // -1 (Absent)



            // Accessing Particular Index Value
            Console.WriteLine(var1[6]);
            Console.WriteLine(var1[9]);
            Console.WriteLine(var1[20]);


            // Substring
            string varOne = "mayukhjit2001_";

            Console.WriteLine(varOne.Substring(9, 4)); 
            // first is the starting point
            // second is the number of characters we want to print


            // contains
            // returns either true or false

            Console.WriteLine(var1.Contains('y'));
            Console.WriteLine(var1.Contains('z'));


            // equals
            // Compare two different string , is it equal or not

            string var2 = "Mayukhjit Chakraborty";

            Console.WriteLine(var1.Equals(var2));

            // trim
            // it will remove leading and trailing whitespaces (special) generally

            string var3 = "***antara***";
            Console.WriteLine(var3.Length);

            Console.WriteLine(var3.Trim('*'));

            // replace
            // replace a character or substring with another character or substring

            Console.WriteLine(var2.Replace('a', 'z'));
            Console.WriteLine(var2.Replace("Chakraborty", "XYZ"));


            // remove
            Console.WriteLine(var2.Remove(10));
            Console.WriteLine(var2.Remove(10, 3));



            // upper case and lower case

            Console.WriteLine(var2.ToUpper());
            Console.WriteLine(var2.ToLower());



            // Print all the charaters of string 

            Console.WriteLine("Enter Your String : ");
            string name=Console.ReadLine();  // user input

            for(int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

        }
    }    
}
