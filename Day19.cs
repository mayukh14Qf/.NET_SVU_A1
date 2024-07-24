using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day19
    {
        static void Main(string[] args)
        {
            /*
                         1
                         2 3
                         4 5 6
                         7 8 9 10 
                        (Floyd's Triangle)

            */

            Console.WriteLine("Enter Your no of Rows : ");
            int rows1 = Convert.ToInt32(Console.ReadLine());

            int count = 1;

            for (int i = 1; i <= rows1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count = count + 1;
                }

                Console.WriteLine();
            }

            /*
                                *
                              * *
                            * * *
                          * * * *
                        * * * * *

            */


            Console.WriteLine("Enter No of Rows : ");
            int rows2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows2; i++)
            {
                for (int j = rows2; j > i; j--)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }



            /*
                         * * * * *
                           * * * *
                             * * *
                               * *
                                 * 
            */

            Console.WriteLine("Enter No of Rows : ");
            int rows3 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows3; i++)
            {

                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = rows3; j >= i; j--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }





            /*

                        * 
                      * * * 
                    * * * * *
                  * * * * * * *
                * * * * * * * * *

            */

            Console.WriteLine("Enter No of Rows : ");
            int rows4 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows4; i++)
            {
                for (int j = rows4; j > i; j--)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }



            /*
                        * * * * * * * * *
                          * * * * * * *
                            * * * * *
                              * * *
                                *

            */

            Console.WriteLine("Enter No of Rows : ");
            int rows5 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows5; i++)
            {

                for (int j = 1; j < i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = rows5; j >= i; j--)
                {
                    Console.Write("* ");
                }

                for (int j = rows5; j > i; j--)
                {
                    Console.Write("* ");
                }


                Console.WriteLine();
            }


        }
    }
}