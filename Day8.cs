using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day8
    {
        static void Main(string[] args)
        {
            // Leap Year or not
            
                        Console.WriteLine("Enter A Number");
                        int year = Convert.ToInt32(Console.ReadLine());


                        if ((year % 4==0 ) && (year %100 != 0))
                        {
                            Console.WriteLine("This is leap year");
                        }
                        else if (year % 400 == 0){
                            Console.WriteLine("This is Leap Year");
                        }
                        else
                        {
                            Console.WriteLine("This is not Leap Year");
                        }
            


            // Check a character is alphabet , special or numeric
            
                        Console.WriteLine("Enter Your Character :");
                        char char1 = Convert.ToChar(Console.ReadLine());

                        int container = char1; // Implicit Conversion

                        if(container>=65 && container<= 90)
                            {
                                Console.WriteLine("This is An Alphabet");
                            }
                        else if (container >= 97 && container <= 122)
                             {
                                 Console.WriteLine("This is An Alphabet");
                             }
                        else if (container >= 48 && container <= 57)
                             {
                                 Console.WriteLine("This is A Numeric");
                             }
                        else
                             {
                                 Console.WriteLine("This is a special Character");
                             }

                        

            /* (2nd Method)
             if (char1 >= 'A' && char1 <= 'Z')
            {
                Console.WriteLine("This is An Alphabet");
            }
            else if (char1 >= 'a' && char1 <= 'z')
            {
                Console.WriteLine("This is An Alphabet");
            }
            else if (char1 >= '0' && char1 <= '9')
            {
                Console.WriteLine("This is A Numeric");
            }
            else
            {
                Console.WriteLine("This is a special Character");
            }
            */

            // (1-12) take month as input, print respective days
            

                        Console.WriteLine("Enter A number which belongs to it's corresponding Month(1-12) ");
                        int number1= Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter your Corresponding Year ");
                        int year1 = Convert.ToInt32(Console.ReadLine());

                        if (number1 == 1 || number1 == 3 || number1 == 5 
                            || number1 ==7  || number1 == 8 || number1 == 10 
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
            
            // check A particular input lies between (100-1000) or not

            
                        Console.WriteLine("Enter A Number");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        if(num1 >=100 && num1 <= 1000)
                        {
                            Console.WriteLine("it lies between 100 and 1000");
                        }

                        else
                        {
                            Console.WriteLine("it does not lie between 100 and 1000");
                        }

                         
          // Check A particular Number is divisible by 25 and 13 or not 

                        Console.WriteLine("Enter A Number");
                        int num=Convert.ToInt32(Console.ReadLine());


                        if (num % 25 == 0 && num % 13 == 0)
                        {
                            Console.WriteLine("Divisible By 25 and 13");
                        }

                        else if (num % 25 == 0)
                        {
                            Console.WriteLine("Divisible By only 25");
                        }

                        else if (num % 13 == 0)
                        {
                            Console.WriteLine("Divisible By only 13");
                        }
                        else
                        {
                            Console.WriteLine("The number is not divisible by either 13 or 25");
                        }


        }
    }
}
