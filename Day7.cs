using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day7
    {
        static void Main(string[] args)
        {

            // Even or Not 


            Console.WriteLine("Enter a number");
            int number1= Convert.ToInt32(Console.ReadLine());

            if (number1 == 0)
            {
                Console.WriteLine("Give Something which is not zero");
            }
            else if (number1 % 2 == 0)
            {
                Console.WriteLine("This is Even");
            }
            else 
            {
                Console.WriteLine("This is Odd");
            }

            // Vowel or not

            Console.WriteLine("Enter a Character :");
            char char1 = Convert.ToChar(Console.ReadLine());

            if (char1 =='a' || char1 == 'e' || char1 == 'i' || char1 == 'o' ||char1 == 'u' ||
                char1 == 'A' || char1 == 'E' || char1 == 'I' || char1 == 'O' || char1 == 'U')
            {
                Console.WriteLine("This is vowel ");
            }
            else
            {
                Console.WriteLine("This is Not Vowel");
            }


            // Max Among the three

            Console.WriteLine("Enter your 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());


            if((a>b) && (a > c))
            {
                Console.WriteLine("Your number one is greater " + a);
            }

            else if ((b > a) && (b > c))
            {
                Console.WriteLine("Your number two is greater " + b);
            }

            else
            {
                Console.WriteLine("Your number three is greater " + c);
            }



            // Check After division , is your output carry any decimal value or not


            Console.WriteLine("Enter your 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("It is an Integer Output");
                }
                else
                {
                    Console.WriteLine("It is a Decimal Output");
                }
            }
            else
            {
                if (num2 % num1 == 0)
                {
                    Console.WriteLine("It is an Integer Output");
                }
                else
                {
                    Console.WriteLine("It is a Decimal Output");
                }
            } 

        }
    }
}
