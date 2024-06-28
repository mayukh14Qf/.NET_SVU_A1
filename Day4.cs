using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day4
    {
        static void Main(string[] args)
        {

            // Simple Interest

            double principle = 1234;
            double rateOfInterest = 4;
            double time = 3;

            double simpleInterest = (principle * rateOfInterest * time) / 100;
            Console.WriteLine(simpleInterest);

            //Swap two Numbers With Third variable

            int a = 10;
            int b = 40;

            int c = a; // c=10
            a= b; // a=40
            b= c; // b=10

            Console.WriteLine("your A is : "+a);
            Console.WriteLine("Your B is : " + b);

            //Swap two Numbers WithOut Using Third variable(addition and subtraction)

            int x = 30;
            int y = 50;

            x = x + y; // x=80 , y=50
            y = x - y; // x=80, y=30
            x = x - y; // x=50 , y=30

            Console.WriteLine("your X is : " + x);
            Console.WriteLine("Your Y is : " + y);

            //Swap two Numbers WithOut Using Third variable(Multiplication and Division)

            int p = 30;
            int q = 70;

            p = p * q; // p = 30*70, q=70
            q = p / q; // p = 30*70, q=30
            p = p / q; // p=70, q=30 

            Console.WriteLine("Your P is :" + p);
            Console.WriteLine("Your Q is :" + q);


            // Print the Last digit of a number

            int number1 = 45678;
            int lastDigit = (number1 % 10);
            Console.WriteLine(lastDigit); // ans : 8


            // sum of n natural Numbers 
            // (10+9+8+7+6+5+4+3+2+1)=55

            int n = 10;

            int result = (n * (n + 1)) / 2;

            Console.WriteLine(result);

        }
    }
}
