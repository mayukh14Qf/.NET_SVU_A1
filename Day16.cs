using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day16
    {
        static void Main(string[] args)
        { 
            // Perfect Number

            Console.WriteLine("Enter Your Number : ");
            int number1=Convert.ToInt32(Console.ReadLine());

            int sumOfFactors = 0;

            for(int i = 1; i < number1; i++)
            {
                if(number1%i == 0)
                {
                    sumOfFactors += i; //sumOfFactors=sumOfFactors+i
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sumOfFactors);

            if(sumOfFactors == number1)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not A Perfect Number ");
            }


            // Print all digits of a Number

            int temp1 = number1;


            while(temp1 > 0)
            {
                Console.WriteLine(temp1%10);
                temp1=temp1 / 10;
            }


            // Print sum of the digits

            int temp2 = number1;
            int sumOfDigits = 0;

            while(temp2 > 0)
            {
                sumOfDigits = sumOfDigits + (temp2 % 10);
                temp2=temp2 / 10;
            }

            Console.WriteLine(sumOfDigits);
        } 
    }
}
