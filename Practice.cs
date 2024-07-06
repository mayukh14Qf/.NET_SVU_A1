using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Practice
    {
        static void Main(string[] args)
        {
            

            //Write A C# program to find out the quadrant in which the given co-ordinate lie


            Console.WriteLine("Enter Your X co-ordinate : ");
            int x=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Y co-ordinate : ");
            int y = Convert.ToInt32(Console.ReadLine());

            if(x ==0 && y ==0)
            {
                Console.WriteLine("You Are at the Origin"); 
            }
            else if (x == 0 && y > 0)
            {
                Console.WriteLine("You Are in the Y axis ");
            }
            else if (x > 0 && y == 0)
            {
                Console.WriteLine("You Are in the X axis ");
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



            //Write a C# program for Finding Roots of a quadratic equation in C sharp

            Console.WriteLine("your format should be (ax^2 + bx +c)");
            Console.WriteLine("Enter your a : ");
            double a=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your b : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your c : ");
            double c = Convert.ToDouble(Console.ReadLine());

            double root1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            double root2 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);


            Console.WriteLine("Your one root is " + root1);
            Console.WriteLine("Your Second root is " + root2);



            //Program for calculating the Area of a circle

            Console.WriteLine("Enter your radius : ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = 3.14 * (radius * radius);

            Console.WriteLine("Your Area of the Circle is "+area);




            //Write a program to check whether your input is in upper case or lower case

            Console.WriteLine("Enter your Character : ");
            char char1 = Convert.ToChar(Console.ReadLine());

            if(char1 >= 'a' && char1 <= 'z')
            {
                Console.WriteLine("This is A Lower Case Alphabet");
            }
            else if (char1 >= 'A' && char1 <= 'Z')
            {
                Console.WriteLine("This is A Upper Case Alphabet");
            }
            else
            {
                Console.WriteLine("This is not an Alphabet");
            }


        }
    }
}
