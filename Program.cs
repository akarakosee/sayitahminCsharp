using System;

namespace SayiTahminEtmeOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 10;
            int tahmin;
            Console.WriteLine("Sayı Tahmin Etme Oyununa Hoşgeldin");
            Console.WriteLine();
            Console.WriteLine($"0 ile 100 arasında rastgele bir sayının kaç olduğunu bulman için {hak} hakkın var.");
            Console.WriteLine();

            int sayi, enFazla = 100, enAz = 0;
            Random rastgeleSayi = new Random();
            sayi = rastgeleSayi.Next(enAz, enFazla);

            while (hak > 0)
            {
                Console.WriteLine($"Kalan hakkınız: {hak}");
                Console.Write("Bir Sayı Tahmini Yapınız:  ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == sayi)
                {
                    Console.WriteLine("Doğru bildiniz tebrikler!");
                    break;
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Tahmin ettiğiniz sayıyı büyütünüz.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Tahmin ettiğiniz sayıyı küçültünüz.");
                    Console.WriteLine();
                }
                hak--;
            }

            if (hak == 0)
            {
                Console.WriteLine("Daha fazla deneme hakkın kalmadı.");
                Console.WriteLine();
                Console.WriteLine($"Rastgele sayı buydu: {sayi}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
