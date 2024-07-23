using System;


namespace BCA_A1_207
{
    public class Day18
    {
        static void Main(string[] args)
        {
            /*  print the pattern given below :
             
             1 
             2 2
             3 3 3
             4 4 4 4
             5 5 5 5 5
             
             */
            Console.WriteLine("Enter Your no of Rows : ");
            int rows1 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }


            /*  print the pattern given below :
             
             1 
             1 2
             1 2 3
             1 2 3 4
             1 2 3 4 5
             
             */

            Console.WriteLine("Enter Your no of Rows : ");
            int rows2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            /*  print the pattern given below :
             
             1 
             1 0
             1 0 1
             1 0 1 0
             1 0 1 0 1
             
             */


            Console.WriteLine("Enter Your no of Rows : ");
            int rows3 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= rows3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if(j%2 == 0)
                    {
                        Console.Write(0+" ");
                    }
                    else
                    {
                        Console.Write(1+" ");
                    }
                }
                Console.WriteLine();
          
           
            }



            /*  print the pattern given below :
             
            
             5 4 3 2 1
             5 4 3 2
             5 4 3
             5 4
             5
             
             */

            Console.WriteLine("Enter Your no of Rows : ");
            int rows4 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows4; i++)
            {
                for (int j = rows4; j >= i; j--)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }



            /*  print the pattern given below :
             
            
             5 5 5 5 5
             4 4 4 4
             3 3 3
             2 2
             1
             
             */

            Console.WriteLine("Enter Your no of Rows : ");
            int rows5 = Convert.ToInt32(Console.ReadLine());
            for (int i = rows5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write( i+ " ");
                }
                Console.WriteLine();
            }
        }

     }
}
