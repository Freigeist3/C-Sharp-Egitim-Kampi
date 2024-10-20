using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region double float değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma Fiyatı: " applePrice);
            //Console.WriteLine("Portakal Fiyatı: " orangePrice);
            //Console.WriteLine("Çilek Fiyatı: " strawberryPrice);
            //Console.WriteLine("Patates Fiyatı: " potatoPrice);
            //Console.WriteLine("Domates Fiyatı: " tomatoPrice);

            ////gramaj variable ekledik, fiyatlarıyla çarptık yazdırdık vs






            #endregion

            #region char değişkenler

            //char symbol;
            //symbol = 'a';
            ////char'ın formatı tek tırnaktır. ''
            #endregion

            #region klavyeden string veri girişleri
            //Console.WriteLine(symbol); 

            //Console.WriteLine("Hava yolu müşteri bilgisi");

            //string passengerName, passengerSurname, passengerAge, passengerIdentityNumber, passengerDistrict, passengerCity;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("yolcu TC kimlik no: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("ilçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine(passengerName + " " + passengerSurname + ", " + passengerAge + ", " + passengerIdentityNumber + ", " + passengerDistrict + ", " + passengerCity);


            #endregion

            #region klavyeden int veri girişleri
            //int shoePrice, computerPrice, chairPrice;

            //shoePrice = 1000;
            //computerPrice = 40000;
            //chairPrice = 400;

            //int shoeCount, computerCount, chairCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());


            //int totalPrice = shoeCount*shoePrice + computerCount*computerPrice + chairCount*chairPrice;

            //Console.WriteLine("toplam tutar: " + totalPrice);
            #endregion

            #region klavyeden ondalıklı sayı girişleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("sınav 1 notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("sınav 2 notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("sınav 3 notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("ortalamanız: " + result);
            #endregion

            #region klavyeden char girişleri


            //char gender;


            //Console.WriteLine("Cinsiyetinizi belirtiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("cinsiyetiniz: " + gender);

            #endregion

            Console.Read();

        }
    }
}
