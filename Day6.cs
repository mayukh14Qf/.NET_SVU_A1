using System; 

namespace BCA_A1_207
{
    public class Day6
    {
        static void Main(string[] args)
        {

            // Check the max between Two Number

            Console.WriteLine("Enter Your 1st Number");
            int number1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your 2nd Number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Enter two Different values ");
            }
            else if (number1 > number2)
            {
                Console.WriteLine("the Greater Number is " + number1);
            }
            else {
                Console.WriteLine("the Greater Number is " + number2);
            }


            // Positive or not

            Console.WriteLine("Enter A Number : ");
            int number=Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Enter a number which is not zero");
            }
            else if (number > 0)
            {
                Console.WriteLine("The number is Positive");
            }
            else
            {
                Console.WriteLine("The Number is Negative");
            }

            // Grading system using if else

            Console.WriteLine("Enter Your Number in Bengali");
            double bengali = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Your Number in English");
            double english = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Your Number in Hindi");
            double hindi = Convert.ToDouble(Console.ReadLine());


            double avg=(bengali+english+hindi)/3;

            if(avg > 90)
            {
                Console.WriteLine("A+");
            }
            else if (avg >= 80 && avg <= 90)
            {
                Console.WriteLine("A");
            }
            else if (avg >= 70 && avg < 80)
            {
                Console.WriteLine("B+");
            }
            else if (avg >= 60 && avg <=69)
            {
                Console.WriteLine("B");
            }
            else if (avg >= 50 && avg < 60)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("F");
            }



        }
    }
}
