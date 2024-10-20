using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region alt alta 10 yıldız oluşturma

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion


            #region yan yana 10 yıldız oluşturma

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion


            #region dik üçgen

            //int i;

            //for (i = 1; i<=5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");


            //    }

            //    Console.WriteLine();


            //}
            #endregion


            #region ters dik üçgen

            //for (int i = 5; i >=1; i--)
            //{

            //    for(int j = 1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();


            }

            #endregion

            #region eljif elmas

            //    *     
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *

            int n = 5; 
            for (int i = 1; i <= n; i++)
            {
                // boşluklar
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }

                // yıldızlar
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }


Console.WriteLine();
            
             }

           
            for (int i = n - 1; i >= 1; i--)
        {
            //boşluklar
            for (int j = n; j > i; j--)
            {
                Console.Write(" ");
            }

            //yıldızlar
            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }

            
            Console.WriteLine();

        }





#endregion


Console.Read();
        }
    }
}
