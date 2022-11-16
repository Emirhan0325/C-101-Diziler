using System;

namespace degisken
{
    class program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar ={"kedi", "köpek", "kuş", "maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Yeşil";
            dizi[3] = 10;
            
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerde dizi kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("Lütfen dizinin {0}. sayısını giriniz: ", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());

            }

            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;

            }
            Console.Write("Ortalam: " + toplam/diziUzunluğu);
















        }
    }
}       
