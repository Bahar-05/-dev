using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.ÖdevApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KAÇ ADET SAYI ÜRETMEK İSTİYORSUNUZ?");

            int adet = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int[] sayilar = new int[adet];

            int i = 0;

            while (adet != i)
            {
                sayilar[i] = rnd.Next(10, 100);
                int a = 0;

                while (a < i)
                {

                    if (sayilar[i] == sayilar[a])
                    {
                        i--;
                        break;
                    }
                    a++;


                }

                i++; 
            }

            Array.Sort(sayilar);

            for (int k = 0; k< sayilar.Length; k++)
            {
                Console.WriteLine($"{k + 1}.Sayı: {sayilar[k]}");
            }

            Console.ReadKey();










        }
    }
}