using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{ 
    public class Day10
    {
        static void Main(string[] args)
        { 

            // Write a C# program  using ternary operator that assigns a category ("Child", "Teenager", or "Adult") based on the age
            // of a person using a ternary operator. If the age is 12 or less, they are a "Child".
            // If the age is between 13 and 19, they are a "Teenager". If the age is 20 or more, they are an "Adult"


            Console.WriteLine("Enter your age :");
            int age= Convert.ToInt32(Console.ReadLine());

            // nesting in else/false condition

            string check = (age <= 12) ? "child" : ((age >= 13 && age <= 19) ? "Teenager" : "Adult");

            Console.WriteLine(check);

            // nesting in true/if condition

            string check1 = (age > 12) ? ((age >= 13 && age <= 19) ? "Teenager" : "Adult") : "Child";

               Console.WriteLine(check1);



            // (1) Compound Interest

            Console.WriteLine("Enter Your Principle :");
            double principal=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Your Rate of interest :");
            double rateOfInterest = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Your time period :");
            double time = Convert.ToDouble(Console.ReadLine());

            double amount = principal * Math.Pow((1 + (rateOfInterest / 100)), time);
            Console.WriteLine("Your Amount is : " + amount);

            Console.WriteLine("Compound Interest is : " + (amount - principal));



            // (2)Swap two Numbers WithOut Using Third variable(addition and subtraction)

            int x1 = 30;
            int y1 = 50;

            x1 = x1 + y1; // x1=80 , y1=50
            y1 = x1 - y1; // x1=80, y1=30
            x1 = x1 - y1; // x1=50 , y1=30

            Console.WriteLine("your X is : " + x1);
            Console.WriteLine("Your Y is : " + y1);

            //Swap two Numbers WithOut Using Third variable(Multiplication and Division)

            int p = 30;
            int q = 70;

            p = p * q; // p = 30*70, q=70
            q = p / q; // p = 30*70, q=30
            p = p / q; // p=70, q=30 

            Console.WriteLine("Your P is :" + p);
            Console.WriteLine("Your Q is :" + q);



            //(3) Leap Year or not 

            Console.WriteLine("Enter A Number");
            int year = Convert.ToInt32(Console.ReadLine());


            if ((year % 4 == 0) && (year % 100 != 0))
            {
                Console.WriteLine("This is leap year");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("This is Leap Year");
            }
            else
            {
                Console.WriteLine("This is not Leap Year");
            }



            //(4) Greater Among 3 numbers (you should take user input)

            Console.WriteLine("Enter the 1st Number : ");
            int a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd Number : ");
            int c = Convert.ToInt32(Console.ReadLine());


            int greater1 = Math.Max(a, b); // 34
            int greater2 = Math.Max(greater1, c); //56

            Console.WriteLine(greater2); //56



            //(5) sum of n natural Numbers
            // (10+9+8+7+6+5+4+3+2+1)=55

            Console.WriteLine("Enter Your Range :");
            int n= Convert.ToInt32(Console.ReadLine());

            int result = (n * (n + 1)) / 2;

            Console.WriteLine(result);




            // (6) Write A C# program to find out the quadrant in which the given co-ordinate lie


            Console.WriteLine("Enter Your X co-ordinate : ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Y co-ordinate : ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("You Are at the Origin");
            }
            else if (x == 0 && (y > 0 || y < 0))
            {
                Console.WriteLine("You Are on the Y axis ");
            }
            else if ((x > 0 || x < 0) && y == 0)
            {
                Console.WriteLine("You Are on the X axis ");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("You Are in the 1st quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("You Are in the 2nd quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("You Are in the 3rd quadrant");
            }
            else
            {
                Console.WriteLine("You Are in the 4th quadrant");
            }



            //(7) (1-12) take month as input, print respective days


            Console.WriteLine("Enter A number which belongs to it's corresponding Month(1-12) ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Corresponding Year ");
            int year1 = Convert.ToInt32(Console.ReadLine());

            if (number1 == 1 || number1 == 3 || number1 == 5
                || number1 == 7 || number1 == 8 || number1 == 10
                || number1 == 12)
            {
                Console.WriteLine("No of Days are " + 31);
            }
            else if (number1 == 2)
            {
                if ((year1 % 4 == 0) && (year1 % 100 != 0))
                {
                    Console.WriteLine("No of Days are " + 29);
                }
                else if (year1 % 400 == 0)
                {
                    Console.WriteLine("No of Days are " + 29);
                }
                else
                {
                    Console.WriteLine("No of Days are " + 28);
                }
            }
            else
            {
                Console.WriteLine("No of Days are " + 30);
            }



            //(8) Print the last Digit of the Number and Check that particular digit is even or not


            Console.WriteLine("Enter Your Number");
            int number5=Convert.ToInt32(Console.ReadLine());

            int lastDigit=number5%10;

            Console.WriteLine((lastDigit % 2 == 0) ? "even" : "odd");




            //(9) Check Your Input Character is Numeric or Not


            Console.WriteLine("Enter Your Character : ");
            char char5=Convert.ToChar(Console.ReadLine());

            string check5 = (char5 >= '0' && char5 <= '9') ? "Numeric" : "Not Numeric";

            Console.WriteLine(check5);

            // (10) Print your name 

            Console.WriteLine("Mayukhjit Chakraborty :))");
        }
    }
}
