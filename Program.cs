using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaprekar_s_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Kaprekar's Constant is 6174
                //1. take a 4 digit start number using at least two  different digits ... e.g. 9218
                //2. order the digits descending 4321, then ascending to get two 4 digit numbers(add leading zeros if needed)
                //3. subtract smaller number from bigger number e.g. 9821 - 1289 = 8532
                //4. Go back to step 2 replacing start number with result of step 3, repeat until numbers converge to 6174

                //Task: Write a program to compute Kaprekar's constant using any four digit start number
                //Ext: Display the number of iterations needed until 6174 is reached

                Console.WriteLine("Hello, Type a four digit number:"); // starter code for students
                int x = Convert.ToInt32(Console.ReadLine()); //starter for students
                                                             //YOUR CODE GOES HERE ....

            int num1 = x/1000;
            int num2 = (x/100)%10;
            int num3 = (x / 10) % 10;
            int num4 = x % 10;
            int y = 0;
            int res = 0;
            int count = 0;

            int ASC = Ascending(num1,num2,num3,num4);
            int DES = Descending(num1,num2,num3,num4);

            while (y == 0)
            {
                res = DES - ASC;

                if (res == 6174)
                {
                    count++;
                    y++;
                }
                else
                {
                    count++;
                    int r1 = res / 1000;
                    int r2 = (res / 100) % 10;
                    int r3 = (res / 10) % 10;
                    int r4 = res % 10;
                    ASC = Ascending(r1, r2, r3, r4);
                    DES = Descending(r1, r2, r3, r4);
                }
            }
            Console.WriteLine($"It took {count} times to reach 6174.2");

        }

        static int Ascending(int a, int b, int c, int d)
        {
            int[] ascendingArr = { a, b, c, d };
            int temp;
            int i = 0;
            int a1;
            int b1;
            int c1;
            int d1;
            bool swaps = false;
            bool sorted = false;
            while (sorted == false)
            {
                while (i <= 2)
                {
                    if (ascendingArr[i] > ascendingArr[i + 1])
                    {
                        temp = ascendingArr[i];
                        ascendingArr[i] = ascendingArr[i + 1];
                        ascendingArr[i + 1] = temp;
                        swaps = true;
                        
                    }
                     i++;
                }
                 if (i >= 3 && swaps == true)
                 {
                  i = 0;
                  swaps = false;
                 }
                  else if (i >= 3 && swaps == false)
                  {
                  sorted = true;
                 
    
                  }
            }

            a1 = ascendingArr[0];
            b1 = ascendingArr[1];
            c1 = ascendingArr[2];
            d1 = ascendingArr[3]; 
            return a1 * 1000 + b1 * 100 + c1 * 10 + d1;
        }


        static int Descending(int a, int b, int c, int d)
        {
            int[] descendingArr = { a, b, c, d };
            int temp;
            int i = 0;
            int a1;
            int b1;
            int c1;
            int d1;
            bool swaps = false;
            bool sorted = false;
            while (sorted == false)
            {
                while (i <= 2)
                {
                    if (descendingArr[i] > descendingArr[i + 1])
                    {
                        temp = descendingArr[i];
                        descendingArr[i] = descendingArr[i + 1];
                        descendingArr[i + 1] = temp;
                        swaps = true;

                    }
                    i++;
                }
                if (i >= 3 && swaps == true)
                {
                    i = 0;
                    swaps = false;
                }
                else if (i >= 3 && swaps == false)
                {
                    sorted = true;


                }
            }

            a1 = descendingArr[3];
            b1 = descendingArr[2];
            c1 = descendingArr[1];
            d1 = descendingArr[0];
            return a1 * 1000 + b1 * 100 + c1 * 10 + d1;

        }




    }
}
