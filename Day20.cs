using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day20
    {
        static void Main(string[] args)
        {
            /*
             
             a 
             a b
             a b c
             a b c d
             a b c d e

             */


            Console.WriteLine("Enter Your No of Rows");
            int rows1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(96 + j) + " ");
                }
                Console.WriteLine();
            }



            /*

             a 
             b b
             c c c
             d d d d
             e e e e e


             */


            Console.WriteLine("Enter Your No of Rows");
            int rows2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(96 + i) + " ");
                }
                Console.WriteLine();
            }




            // Print all the Prime Numbers Within A Certain range
            // for 20 -> 2,3,5,7,11,13,17,19

            Console.WriteLine("Enter Your range : ");
            int range1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= range1; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
            }


            // String ( Sequence of Characters) 


            string var1 = "mayukhjit";
            Console.WriteLine(var1);

            // Length of a string
            Console.WriteLine(var1.Length);

            // Index of a string (starting from 0 , to ended at length -1)

            Console.WriteLine(var1.IndexOf('m'));
            Console.WriteLine(var1.IndexOf('t'));

            Console.WriteLine(var1.IndexOf('z')); // output-> -1 (absent)


            Console.WriteLine("Enter Your String ");
            string var2=Console.ReadLine();

            Console.WriteLine("Your name is "+var2);



         }
    }
}
