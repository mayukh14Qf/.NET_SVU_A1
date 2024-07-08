using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day9
    {
        static void Main(string[] args)
        {
            // Math Operation in C sharp


            Console.WriteLine(Math.Min(12, 34)); // Min Value
            Console.WriteLine(Math.Min(12, 34));

            Console.WriteLine(Math.Max(12, 34)); // Max value

            // Greater Among 3 numbers

            int a = 19;
            int b = 34;
            int c = 56;

            int greater1 = Math.Max(a, b); // 34
            int greater2 = Math.Max(greater1, c); //56

            Console.WriteLine(greater2); //56


            Console.WriteLine(Math.Pow(5,3)); // 5^3=125 (******)

            Console.WriteLine(Math.Abs(-23)); // positive integer

            Console.WriteLine(Math.Round(23.5678)); // Round off
            Console.WriteLine(Math.Round(23.39));


            // Ternary Operator (only for if and else)

            int n = 28;

            Console.WriteLine( n%2==0 ? "even" : "odd");



            // Switch Case 

            Console.WriteLine("enter your number : ");
            int num1=Convert.ToInt32(Console.ReadLine());

            switch (num1)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thur sday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("Enter Any Number between 1 and 7");
                    break;
            }

            // Positive or not (ternary operator)

            Console.WriteLine("enter your number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            string check= num2>0 ? "positive" : "negative";
            Console.WriteLine(check);

            // Divisible by 25 or not

            Console.WriteLine("enter your number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            string check2 = num3 % 25 == 0 ? "divisible by 25" : "not divisle by 25";
            Console.WriteLine(check2);

            // vowel or not (Switch case)


            Console.WriteLine("enter your alphabet : ");
            char char1 = Convert.ToChar(Console.ReadLine());

            switch (char1) 
            {
                case 'a':
                case 'A':
                case 'i':
                case 'I':
                case 'e':
                case 'E':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }

            // calculator by using switch case

            Console.WriteLine("enter your any symbol (+,-,*,/) : ");
            char char2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Number1 > number2");
            Console.WriteLine("enter your 1st number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your 2nd number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            switch (char2)
            {
                case '+':
                    Console.WriteLine(number1 + number2);
                    break;
                case '-':
                    Console.WriteLine(number1 - number2);
                    break;
                case '*':
                    Console.WriteLine(number1 * number2);
                    break;
                case '/':
                    Console.WriteLine(number1 / number2);
                    break;
                default:
                    Console.WriteLine("Choose the appropriate symbol");
                    break;
            }

        }
    }
    
}
    
