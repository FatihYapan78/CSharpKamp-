using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDegiskenler
            double number;
            number = 4.85; // Noktanın çıktısı virgül şeklinde oluyor.
            Console.WriteLine(number);

            #endregion

            #region CharDegiskenler

            // Tek tırnak kullanılarak tanımlama yapılır.

            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);



            #endregion

            #region KlavyedenVeriGirisleriStrigDegiskenler

            //Console.WriteLine("Yolcu Bilgieri");
            //Console.WriteLine();

            //string name, surname, district, city, age, IdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //name = Console.ReadLine();

            //Console.Write("Yolcu SoyAdı: ");
            //surname = Console.ReadLine();

            //Console.WriteLine(name + " " + surname);

            #endregion

            #region KlavyedenTamSayıGirisleriveDönüsümler

            //int shoesPrice;
            //shoesPrice = 1000;

            //int shoesCount;

            //Console.Write("Kaç Adet Ayakkabı Alacaksınız : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //int TotalPrice = shoesPrice * shoesCount;  
            //Console.WriteLine(TotalPrice);

            #endregion

            #region KlavyedenOndalıklıSayıGirisleriveDönüsümler

            double exam1, result;

            Console.Write("Lütfen Sınav Notunu Gİriniz : ");
            exam1 = double.Parse(Console.ReadLine());

            #endregion

            #region KlavyedenKarakterGirisleriveDönüsümler

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz : ");
            gender = char.Parse(Console.ReadLine());


            #endregion

            Console.Read();
        }
    }
}
