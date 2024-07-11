using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day11
    {
        static void Main(string[] args)
        {
            // Loops
            // 1. Starting
            // 2. Ending 
            // 3. Counts

            // for loop
            // i++ or i=i+1 or i += 1 (same same)

            // printing 1-100 in forward manner

            //for (int mayukh = 1; mayukh <= 100; mayukh++) 
            //{
            //    Console.WriteLine(mayukh+" I am Sorry");
            //}

            // Printing 1-100 in reverse order

            //for (int i=100; i>=1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            // Printing all even numbers within the range of 1 to 100

            //for(int i=1; i<=100; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine("Even : "+ i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("odd : " + i);
            //    }
            //}

            // or
            Console.WriteLine("Even Numbers");
            //for (int i = 2; i <=100; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Odd Numbers");

            //for (int i = 1; i <= 100; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}

            // Print all the numbers Divisible by 7 within
            // the range of 25 to 600

            for(int i = 25; i <= 600; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Sum of n natural Numbers


            Console.WriteLine("Enter your range : ");
            int n=Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for(int i = 1; i <= n; i++)
            {
                result=result+i;
            }

            Console.WriteLine(result); 

        }
    }
}
