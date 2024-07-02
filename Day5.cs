using System;

namespace BCA_A1_207 
{
    public class Day5
    {
        static void Main(string[] args)
        {

            // String as user Input

            Console.WriteLine("Enter your Name :");
            string name1 = Console.ReadLine();

            Console.WriteLine("Your given name is " + name1);


            // Char as user Input

            Console.WriteLine("Enter Your Character");
            char char1=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("your char is " + char1);


            // int as user input

            Console.WriteLine("Enter your 1st Number");
            int number1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your 2nd Number");
            int number2 = Convert.ToInt32(Console.ReadLine());


            int sum = number1 + number2;

            Console.WriteLine("your output sum is : "+sum);
            
            // double as user input

            Console.WriteLine("Enter your Floating point Number");
            double number3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Your Double is :" + number3);

        }
    }
}