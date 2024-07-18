using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day15
    {
        static void Main(string[] args)
        {

            // Print fibonacci Number for a specific position
             
            Console.WriteLine("Enter Your position : ");
            int position = Convert.ToInt32(Console.ReadLine());

            int firstPosition = 0;
            int secondPosition = 1;
            int nextPosition = 0;

            for (int i = 3; i <= position; i++)
            {
                nextPosition = firstPosition + secondPosition;

                firstPosition = secondPosition;
                secondPosition = nextPosition;
            }

            if (position == 1)
            {
                Console.WriteLine(firstPosition);
            }
            else if (position == 2)
            {
                Console.WriteLine(secondPosition);
            }
            else
            {
                Console.WriteLine(nextPosition);
            }

            // Check a number is palindrome or not

            Console.WriteLine("Enter Your Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int temp = number; // Storing actual Number

            int reverse = 0;

            while (number > 0)
            {
                reverse = (reverse * 10) + (number % 10);
                number = number / 10;
            }
            if (reverse == temp)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not palindrome ");
            }
                
            // ArmStrong Number


            Console.WriteLine("Enter A Number : "); 
            int number1= Convert.ToInt32(Console.ReadLine());


            int temp1 = number1; // storing for counting

            // step 1 (counting number of digits)

            int count = 0;

            while(temp1 > 0)
            {
                count++;
                temp1 = temp1 / 10;
            }

            Console.WriteLine(count);

            // step 2 : for armstrong check

            int temp2 = number1; // storing for armstrong check

            int arm = 0;
                                 
            while(temp2 > 0)
            {
                arm = arm +(int) Math.Pow(temp2%10, count);
                temp2 = temp2 / 10;
            }
            Console.WriteLine(arm);

            if (arm == number1)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number ");
            }

              
        }
    }
}
