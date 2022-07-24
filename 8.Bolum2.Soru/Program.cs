using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Bolum2.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            bool sayiMi, palindromMu=true;
            string SayiUzunlugu, cevap;

            do
            {
                do
                {
                    AcilisMesaji();
                    sayiMi = int.TryParse(Console.ReadLine(), out sayi);
                    if (!sayiMi)
                    {
                        HataMesaji();
                    }

                } while (!sayiMi);
                sayi = Math.Abs(sayi);
                SayiUzunlugu = sayi.ToString();
                int[] basamaklar = new int[SayiUzunlugu.Length];
                BasamaklarıAt(SayiUzunlugu, sayi, basamaklar);
                for (int i = 0, j = basamaklar.Length - 1; i < basamaklar.Length / 2; i++, j--)
                {
                    if (basamaklar[i] == basamaklar[j])
                    {

                        palindromMu = true;


                    }
                    else
                    {

                        palindromMu = false;

                    }
                }

                if (palindromMu == true)
                {
                    Console.WriteLine("Girdiğiniz sayı bir palindromdur");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz sayı bir palindrom değildir");
                }
                cevap = Exit();
                
                
            } while (cevap != "exit");



        }

        
            
       
        private static void AcilisMesaji() 
        {
            Console.Write("Bir tamsayı yazınız");
            
        }
        private static void HataMesaji()
        {
            Console.WriteLine("Lütfen doğru formatta bir sayı yazınız!");

        }
        private static int[] BasamaklarıAt(string uzunluk, int sayi, int[] dizi)
        {
            for (long i = uzunluk.Length - 1; i >= 0; i--)
            {
                dizi[i] = sayi % 10;
                sayi = sayi / 10;
            }
            return dizi;
        }
        private static string Exit() 
        {
            string cevap;
            Console.WriteLine("Çıkış yapmak için exit yazınız, devam etmek için herhangi bir tuşa basabilirsiniz");
            cevap = Console.ReadLine();
            return cevap;
        }

    }
}
