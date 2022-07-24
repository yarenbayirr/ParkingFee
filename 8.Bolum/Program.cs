using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Bolum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //soru: kullanıcıdan saat bilgisi, araç bilgisi alarak ödeyeceği otopark ücretini gösterir. 
            int aracTuru;
            double saatBilgisi;
            bool saatBilgisiMi, aracTuruMu;


            do
            {
                AcilisMesajı();
                aracTuruMu = int.TryParse(Console.ReadLine(), out aracTuru);
                if (aracTuru == 1 || aracTuru == 2 || aracTuru == 3 || aracTuru == 4)
                {
                    aracTuruMu = true;
                    break;
                }
                else
                {
                    aracTuruMu = false;
                }
               
                
            } while (!aracTuruMu);
            
           
            do
            {
                SaatOgren();
                saatBilgisiMi = Double.TryParse(Console.ReadLine(), out saatBilgisi);
                if (!saatBilgisiMi || saatBilgisi<0)
                {
                    UyarıMesaji();
                    
                }

            } while (!saatBilgisiMi || saatBilgisi<0);
            if (aracTuru == 1)
            {
                Console.WriteLine($"Ödemeniz gereken tutar : {Otomobil(saatBilgisi)} TL'dir");

            }
            else if (aracTuru == 2)
            {
                Console.WriteLine($"Ödemeniz gereken tutar : {Motosiklet(saatBilgisi)} TL'dir");
            }
            else if (aracTuru == 3)
            {
                Console.WriteLine($"Ödemeniz gereken tutar : {Minibus(saatBilgisi)} TL'dir");
            }
            else if (aracTuru == 4)
            {
                Console.WriteLine($"Ödemeniz gereken tutar : {Kamyon(saatBilgisi)} TL'dir");
            }

            Console.ReadLine();
            

        }



        private static void AcilisMesajı()
        {
            Console.WriteLine("Otomobil için 1'e basın. \nMotosiklet için 2'ye basın. \nMinibüs için 3'e basın. \nKamyon ve diğer ticari araçlar için 4'e basın.");
        }

        private static void SaatOgren() 
        {
            Console.WriteLine("Araç kaç saat boyunca park alanında kaldı?");
        }
        private static void UyarıMesaji()
        {
            Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
        }

        private static int Otomobil(double saatBilgisi) 
        {
            
            int ucret=0;
           
            if (saatBilgisi>= 0 && saatBilgisi<=2)
            {
                ucret = 5;
                
            }
            else if (saatBilgisi > 2 && saatBilgisi <= 6)
            {
                ucret = 10;
                
            }
            else if (saatBilgisi > 6 && saatBilgisi <= 12)
            {
                ucret = 20;
                
            }
            else if (saatBilgisi > 12 && saatBilgisi <= 24)
            {
                ucret = 35;
                
            }
            else if (saatBilgisi > 24)
            {
                saatBilgisi = saatBilgisi - 24;
                saatBilgisi = Math.Ceiling(saatBilgisi / 24);
                    
                ucret = 35 + (int)(saatBilgisi) * 20;
                

            }
            return ucret;
           

        }
        private static int Motosiklet(double saatBilgisi)
        {

            int ucret = 0;

            if (saatBilgisi >= 0 && saatBilgisi <= 2)
            {
                ucret = 0;

            }
            else if (saatBilgisi > 2 && saatBilgisi <= 6)
            {
                ucret = 3;

            }
            else if (saatBilgisi > 6 && saatBilgisi <= 12)
            {
                ucret = 6;

            }
            else if (saatBilgisi > 12 && saatBilgisi <= 24)
            {
                ucret = 12;

            }
            else if (saatBilgisi > 24)
            {
                saatBilgisi = saatBilgisi - 24;
                saatBilgisi = Math.Ceiling(saatBilgisi / 24);

                ucret = 35 + (int)(saatBilgisi) * 10;


            }
            return ucret;


        }
        private static int Minibus(double saatBilgisi)
        {

            int ucret = 0;

            if (saatBilgisi >= 0 && saatBilgisi <= 2)
            {
                ucret = 8;

            }
            else if (saatBilgisi > 2 && saatBilgisi <= 6)
            {
                ucret = 16;

            }
            else if (saatBilgisi > 6 && saatBilgisi <= 12)
            {
                ucret = 32;

            }
            else if (saatBilgisi > 12 && saatBilgisi <= 24)
            {
                ucret = 45;

            }
            else if (saatBilgisi > 24)
            {
                saatBilgisi = saatBilgisi - 24;
                saatBilgisi = Math.Ceiling(saatBilgisi / 24);

                ucret = 35 + (int)(saatBilgisi) * 25;


            }
            return ucret;


        }
        private static int Kamyon(double saatBilgisi)
        {

            int ucret = 0;

            if (saatBilgisi >= 0 && saatBilgisi <= 2)
            {
                ucret = 15;

            }
            else if (saatBilgisi > 2 && saatBilgisi <= 6)
            {
                ucret = 30;

            }
            else if (saatBilgisi > 6 && saatBilgisi <= 12)
            {
                ucret = 60;

            }
            else if (saatBilgisi > 12 && saatBilgisi <= 24)
            {
                ucret = 100;

            }
            else if (saatBilgisi > 24)
            {
                saatBilgisi = saatBilgisi - 24;
                saatBilgisi = Math.Ceiling(saatBilgisi / 24);

                ucret = 35 + (int)(saatBilgisi) * 55;


            }
            return ucret;


        }

    }
}
