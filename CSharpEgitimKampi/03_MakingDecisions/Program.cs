using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_MakingDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");

            //}
            //else
            //{

            //    Console.WriteLine("Şifre yanlış");

            //}







            //int number;
            //Console.WriteLine("Sayı giriniz, umarım 5 girersin: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5 )
            //{
            //    Console.WriteLine("Aferin dostum, bu işi başardın");

            //}
            //else
            //{
            //    Console.WriteLine("seni başarısız moruk");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "düzgün gir şu notları be sana zahmet";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());


            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların ortalaması: " +  average);

            //if(average >= 0 & average < 50)
            //{
            //    result = ("Sonuç kötü kanzi");
            //}

            //if (average >= 50 & average < 70)
            //{
            //    result = ("Sonuç ortalama baco");
            //}


            //if (average >= 70 & average < 85)
            //{
            //    result = ("Sonuç fena değil hacı");
            //}

            //if (average >= 85 & average < 100)
            //{
            //    result = ("Tebrikler dost, güzel iş");
            //}

            //Console.WriteLine(result);

            #endregion

            #region mod işlemleri

            //int number;
            //Console.WriteLine("-------TEK Mİ ÇİFT Mİ OYUNUNA HOŞGELDİNİZ------");
            //Console.WriteLine();
            //Console.Write("Bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Çift bir sayı seçtiğini sezinliyorum ");


            //}

            //else
            //{
            //    Console.WriteLine("tek bir sayı seçtiğini düşünüyorum ");


            //}





            #endregion

            #region char değişkenler ile karar yapıları
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g'|| team =='G')
            //{
            //    Console.WriteLine("Galatasaraylı kardeş");
            //}

            //if (team == 'f' || team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçeli kardeş");
            //}

            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Beşiktaşlı kardeş");
            //}
            #endregion

            #region örnek uygulama

            //Console.WriteLine("TARİHİ C# RESTORAN");
            //Console.WriteLine("----------------------");

            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");

            //string menuItem;
            //menuItem = Console.ReadLine();


            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ANA YEMEKLER-----------");
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma tabağı");
            //    Console.WriteLine("3-Fasulye pilav");
            //    Console.WriteLine("4-somon pilav");
            //    Console.WriteLine("------------ANA YEMEKLER-----------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ÇORBALAR-----------");
            //    Console.WriteLine("1-Ezogelin çorbası");
            //    Console.WriteLine("2-Domates çorbası");
            //    Console.WriteLine("3-Mercimek çorbası");
            //    Console.WriteLine("4-kokoreç çorbası");
            //    Console.WriteLine("------------ÇORBALAR-----------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------PİZZALAR-----------");
            //    Console.WriteLine("1-Barbekü tavuklu");
            //    Console.WriteLine("2-Akdeniz");
            //    Console.WriteLine("3-Vegan");
            //    Console.WriteLine("4-Pastırmalı");
            //    Console.WriteLine("------------PİZZALAR-----------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İÇECEKLER-----------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran tabağı");
            //    Console.WriteLine("3-Limonata");
            //    Console.WriteLine("4-Şalgam");
            //    Console.WriteLine("------------İÇECEKLER-----------");
            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------TATLILAR-----------");
            //    Console.WriteLine("1-Supangle");
            //    Console.WriteLine("2-Profiterol");
            //    Console.WriteLine("3-Triliçe");
            //    Console.WriteLine("4-Tavuk göğsü");
            //    Console.WriteLine("------------TATLILAR-----------");
            //    Console.WriteLine();

            //}

            #endregion

            #region switch case

            //Console.WriteLine("Lütfen Ay girişi yapınız");

            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)

            //{
            //    case 1: Console.Write("Ocak");
            //    break;

            //    case 2: Console.Write("Şubat");
            //    break;

            //    case 3: Console.Write("Mart");
            //    break;

            //    case 4: Console.Write("Nisan");
            //    break;

            //    case 5: Console.Write("Mayıs");
            //    break;

            //    case 6: Console.Write("Haziran");
            //    break;

            //    case 7: Console.Write("Temmuz");
            //    break;

            //    case 8: Console.Write("Ağustos");
            //    break;

            //    case 9: Console.Write("Eylül");
            //    break;

            //    case 10:Console.Write("Ekim");
            //    break;

            //    case 11:Console.Write("Kasım");
            //    break;

            //    case 12: Console.Write("Aralık");
            //    break;

            //    default: Console.WriteLine("Hatalı veri girişi");
            //    break;

        }


        #endregion


        Console.Read();




        }
    }
}
