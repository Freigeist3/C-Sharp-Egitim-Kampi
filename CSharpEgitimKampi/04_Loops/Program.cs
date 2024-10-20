using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü


            //Döngüler 1+2+3+4+5+6
            //3+3=6 6+4=10 10+5=15 15+6=21

            //for (x; y; z)
            //x: başlangıç
            //y: bitiş
            //z: artış/azalış




            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");

            //}




            //for(int i = 3; i <=50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}


            //int totalLine;

            //Console.WriteLine("kaç adet istiyosan onu gir");
            //totalLine = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= totalLine; i++)
            //{
            //    Console.WriteLine("şampiyon fener yeah");

            //}
             #endregion
            
            #region for döngüsü ile karar yapıları

            //for (int i = 0; i <= 100; i++)
            //{


            //    if(i % 5 == 0)
            //    {

            //        Console.WriteLine(i);

            //    }


            //}

            //1-2-4-8-16... 

            //int bacterium = 1;

            //for(int i = 1; i <= 24; i++)

            //{
            //    bacterium *= 2;             
            //    Console.WriteLine(i + "." + " saatin sonunda bakteri sayısı: " + bacterium);

            //}


            #endregion

            #region while

            //while(şart)
            //{
            //işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}









            #endregion

            #region Örnek sınav sorusu


            //Klavyeden girilien 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //BENİM ÇÖZÜMÜM

            //int number;
            //int sum = 0;

            //Console.WriteLine("3 basamaklı sayıyı giriniz");
            //number = int.Parse(Console.ReadLine());

            //sum += number / 100;
            //sum += number % 10;
            //sum += (number % 100) / 10;

            //Console.WriteLine(sum);
            /////////////////////////////////
            


            #endregion

            Console.Read();

            





        }
    }
}
