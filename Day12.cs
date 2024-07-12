using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day12
    {
        static void Main(string[] args)
        {



            //factorial of a number

            Console.WriteLine("enter a range:");
            int range = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= range; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("factorial of the number is: " + fact);




            //input a range from user find out
            //print if the number is even and greater than 10

            Console.WriteLine("enter range:");
            int range2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= range2; i++)
            {
                if (i % 2 == 0 && i > 10)
                {
                    Console.WriteLine(i);
                }

            }




            //Count and find out factors of a number

            Console.Write("enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int count2 = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count2++;
                    Console.WriteLine(i); //It Will be Printing All the factors
                }

            }
            Console.WriteLine("the number of factors: " + count2);



        }

    }
}
