using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tahminödev
{
    class Program
    {
        static void Main(string[] args)
        {
            #region renk
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            #endregion
            byte tutulan = 0;
            int toplam = 0;
            int puan = 0;
            byte islemsayac = 0;
            Random rnd = new Random();
            byte rasgele = (byte)rnd.Next(1, 10);
            byte sayac;
            string devam;
            Console.WriteLine("Sayı Tahmin Oyunumuza Hoşgeldiniz.\nKurallarımız:\nEn fazla 3 tahmin hakkınız bulunmaktadır.");
            do
            {
                islemsayac++;
                for (sayac = 1; sayac <= 3; sayac++)
                {
                    Console.Write("1-10 Arasında bir sayı giriniz: ");
                    tutulan = byte.Parse(Console.ReadLine());
                    if (tutulan == rasgele && sayac == 1)
                    {
                        puan = 100;
                        toplam += puan;
                        Console.WriteLine("Tebrikler {0}.ci hakkınızda bildiniz.Puanınız {1}", sayac, puan);
                        break;
                    }
                    else if (tutulan == rasgele && sayac == 2)
                    {
                        puan = 75;
                        toplam += puan;
                        Console.WriteLine("Tebrikler {0}.ci hakkınızda bildiniz.Puanınız {1}", sayac, puan);
                        break;
                    }
                    else if (tutulan == rasgele && sayac == 3)
                    {
                        puan = 50;
                        toplam += puan;
                        Console.WriteLine("Tebrikler {0}.ci hakkınızda bildiniz.Puanınız {1}", sayac, puan);
                        break;
                    }
                    else if (sayac >= 3)
                    {
                        puan = 0;
                        Console.WriteLine("Maalesef hakkınız kalmadı oyun bitti.Puanınız{0}", puan);
                        break;
                    }
                }
                Console.WriteLine("Bir kez daha oynamak istiyor musunuz?\n e:Evet h:Hayır");
                devam = Console.ReadLine();
            } while (devam == "e");
            Console.WriteLine($"Puanların Ortalaması: {toplam / islemsayac}");
            Console.ReadKey();
        }
    }
}
