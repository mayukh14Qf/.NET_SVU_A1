using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_A1_207
{
    public class Day23
    {
        static void Main(String[] args)
        {
            // Print only the prime digits of a number

            Console.WriteLine("Enter A number : ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime digits are : ");
            while (num1 > 0)
            {
                if(num1%10==2 || num1 % 10 == 3 || num1 % 10 == 5 || num1 % 10 == 2)
                {
                    Console.WriteLine(num1%10);
                }
                num1 = num1 / 10;
            }

            /*
             1 2 * * 3 4 
             1 2 * * 3 4
             1 2 * * 3 4
             1 2 * * 3 4
             1 2 * * 3 4

             */

            Console.WriteLine("Enter Number Of Rows : ");
            int rows1=Convert.ToInt32(Console.ReadLine());

            

            for(int i = 1; i <= rows1; i++)
            {
                int count = 1;
                for (int j = 1; j <= 6; j++)
                {
                    
                    if (j==3 || j == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(count+" ");
                        count++;
                    }
                }
                Console.WriteLine();
            }


            // Print the series 
            // 5,8, 13 , 20, 29 .......

            Console.WriteLine("Enter Your Range : ");
            int position= Convert.ToInt32(Console.ReadLine());

            int num = 5;
            int gap = 3;

            for(int i = 1;i <= position; i++)
            {
                Console.WriteLine(num);
                num = num + gap;
                gap = gap + 2;
            }

            // Twin Prime

            Console.WriteLine("Enter Your Range : ");
            int range2=Convert.ToInt32(Console.ReadLine());

            for(int i = 1;i<= range2; i++)
            {
                int count = 0;
                for (int j = 1;j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    int count1 = 0;
                    for (int j = 1; j <= i+2; j++)
                    {
                        if ((i+2) % j == 0)
                        {
                            count1++;
                        }
                    }
                    if (count1 == 2)
                    {
                        Console.WriteLine("( " + i + " , " + (i + 2) + " )");
                    }
                }
            }

        }
    }
}
