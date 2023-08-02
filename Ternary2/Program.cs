using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** ternary ile pozitif - negatif tespiti ***
            //Console.WriteLine("Lütfen bir sayi giriniz : ");
            //short sayi = Convert.ToInt16(Console.ReadLine());
            //string sonuc = sayi > 0 ? "Pozitif" : sayi < 0 ? "Negatif" : "Notr";
            //Console.WriteLine(sonuc);


            // *** null kullanimi ***
            //string adSonuc;
            //string ad = null;
            //if (ad == null)
            //{
            //    adSonuc = "Ad bostur";
            //    Console.WriteLine(adSonuc);
            //}
            //else
            //{
            //    adSonuc = ad;
            //    Console.WriteLine(adSonuc);
            //}

            //adSonuc = ad == null ? "ad bostur" : ad;
            //Console.WriteLine(adSonuc);

            //adSonuc = ad ??  "ad bostur";
            //Console.WriteLine(adSonuc);


            //*** ternary ile sayinin tek mi cift mi oldugunu bulma ***
            Console.WriteLine("Lütfen bir sayi giriniz : ");
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine("Sayi girilmelidir : ");
            }
            else
            {
                int number = Convert.ToInt32(input);
                if (TekMi(number))
                {
                    Console.WriteLine("Tek");
                }
                else
                {
                    Console.WriteLine("Cift");
                }
            }

            Console.Read();



        }

        static bool TekMi(int no)
        {
            //if (no % 2 == 0)

            //    return true;
            //return false;

            return no % 2 == 0 ? false : true;
        }

        
    }
}
