using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day13
    {
        static void Main(string[] args)
        {


            // Check A Number is Prime or Not

            Console.Write("enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Composite Number or Non-Prime");
             }



            // Make a Multiplication Table

            Console.WriteLine("Enter Your Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1;i <= 10; i++)
            {
                Console.WriteLine(number1 + " * " + i + " = " + (number1 * i));
            }




            // Print fibonacci Series upto a Certain Range

            Console.WriteLine("Enter Your range : ");
            int position= Convert.ToInt32(Console.ReadLine());

            int firstPosition = 0;
            int secondPosition = 1;

            Console.WriteLine(firstPosition);
            Console.WriteLine(secondPosition);

            for (int i = 3; i<=position; i++)
            {
                int nextPosition=firstPosition+secondPosition;
                Console.WriteLine(nextPosition);
                firstPosition = secondPosition;
                secondPosition = nextPosition;
            }


              
            // Print 1st Digit of a Number

            Console.WriteLine("Enter Your Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            for(int i = number2; number2>10; number2 = number2 / 10)
            {

            }
            Console.WriteLine(number2);

        }
    }
}
