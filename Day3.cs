using System;

namespace BCA_A1_207
{
    public class Day3
    {
        static void Main (string[] args)
        {
            // Type Casting
            // Implicit Type Conversion

            double number1 = 45.45;
            double number2 = 34;
            double number3 = 'A';

            float number4 = 56;
            float number5 = 'o';


            int number6 = 't'; // Ascii value will be 116

            // Explicit Conversion ( Type Casting)


            int number7 = (int) 89.32F;
            int number8 = (int) 75.56D;

            Console.WriteLine (number7);
            Console.WriteLine (number8);


            char char1 = (char)101;



            Console.WriteLine(char1);
            Console.WriteLine (number1);
            Console.WriteLine (number2);
            Console.WriteLine (number3);
            Console.WriteLine (number4);
            Console.WriteLine (number5);
            Console.WriteLine (number6);



            int num = Convert.ToInt32(34.67);
            string s1 = Convert.ToString(78950);
            char char3 = Convert.ToChar(107);


            Console.WriteLine (num);
            Console.WriteLine (s1);
            Console.WriteLine(s1.GetType());   // Get type to check the Type of a data
            Console.WriteLine (char3);
            Console.WriteLine (123.GetType());


            // Arithmetic Operator 

            int num1 = 17;
            int num2 = 2;

            Console.WriteLine (num1+num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine (num1 / num2);
            Console.WriteLine (num1 % num2);

            // Important

            Console.WriteLine(8965 / 10); // all the digits except the last one
            Console.WriteLine(8965 % 10); // only the last digit


            // assignment Operator 

            num2 = num2 * 10;
            Console.WriteLine (num2);

            num2 = num2 + 12;

            Console.WriteLine (num2);

            num2 = num2 - 3;
            Console.WriteLine (num2);


        }
    }
}
