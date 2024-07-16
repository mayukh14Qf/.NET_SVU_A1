using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day14
    {
        static void Main(string[] args)
        {
            //   While Loop

            // Starting ( outside of the loop )
            // Ending ( inside the parenthesis beside the while keyword)
            // counts( inside the loop but after the logic )


            // Printing N numbers 

            int i = 1; // starting
            while (i <= 10) // Ending
            {
                Console.WriteLine(i); // logic

                i++; // Counts
            }

            //Printing N numbers in Reverse way

            int j = 10;
            while (j >= 1)
            {
                Console.WriteLine(j);
                j--;
            }

            //Sum of n Natural Numbers

            Console.WriteLine("Enter your Range : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            int k = 1;
            while (k <= n)
            {
                result = result + k; // logic
                k++;
            }
            Console.WriteLine(result);

            //Factorial of A Number

            Console.WriteLine("Enter your Range : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int result1 = 1;
            int k1 = 1;
            while (k1 <= n1)
            {
                result1 = result1 * k1; // logic
                k1++;
            }
            Console.WriteLine(result1);



            // Print 1st digit of a Number
            Console.WriteLine("Enter Your Number : ");
            int number1=Convert.ToInt32(Console.ReadLine());

            while (number1 > 10)
            {
                number1 = number1 / 10;
            }
            Console.WriteLine("First digit is "+ number1);



            // Count Number Of Digits
            Console.WriteLine("Enter Your Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int countDigits = 0; 

            while (number2 > 0)
            {
                countDigits++;
                number2 = number2 / 10;
            }
            Console.WriteLine("Number of Digits Present are : "+countDigits);



            // Reverse A given Number 
            Console.WriteLine("Enter Your Number : ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            while (number3 > 0)
            {
                reverse=(reverse*10)+(number3 % 10);
                number3 = number3 / 10;
            }
            Console.WriteLine("Reverse Of the Input is : "+reverse);


        }
    }
} 
