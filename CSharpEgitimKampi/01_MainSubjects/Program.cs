using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Yazdırma Komutları
            #region Yazdırma Komutları
            //Console.Write("Merhaba DÜnya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            // Değişkenler 
            #region Değiskenler

            // string 
            // Değişken_türü Değişken_adı

            //string name;
            //name = "Fatih";
            //Console.WriteLine(name);

            string customerName;
            string customerSurName;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Fatih";
            customerSurName = "Yapan";
            customerPhone = "507 963 71 95";
            customerEmail = "yapanfatih78@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine(customerName);
            Console.WriteLine(customerSurName);
            Console.WriteLine(customerPhone);
            Console.WriteLine(customerEmail);
            Console.WriteLine(city);
            Console.WriteLine(district);


            #endregion

            Console.Read();
        }
    }
}




