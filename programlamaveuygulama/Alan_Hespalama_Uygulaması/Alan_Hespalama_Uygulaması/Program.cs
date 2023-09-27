using System;

namespace Alan_Hesaplama
{

    class Program
    {

        static void Main(string[] args)


        {
            int secim;
            do
            {
                MenuYaz();

                bool result;
                do
                {
                    Console.Write("Seçiminiz:  ");
                    string secimStr = Console.ReadLine();

                    result = int.TryParse(secimStr, out secim);

                } while (result == false);


                İslemYap(secim);

            } while (secim != 0);

        }
        static void MenuYaz()
        {
            Console.Clear();


            Console.WriteLine("Alan Hesaplama Uygulaması ");
            Console.WriteLine("----------------------------");
            Console.WriteLine();


            Console.WriteLine("Menü");
            Console.WriteLine("-----");
            Console.WriteLine("1) Kare Alan Hesabı ");
            Console.WriteLine("2) Dikdörtgen Alan Hesabı ");
            Console.WriteLine("3) Üçgen Alan Hesabı");
            Console.WriteLine("4) Yamuk Alan Hesabı");
            Console.WriteLine("0) Çıkış");
            Console.WriteLine();


        }

        static void EkrandaBaslikYaz(string baslik)
        {
            Console.WriteLine(baslik);

            for (int i = 0; i < baslik.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void KareAlaniHesaplama()
        {
            Console.Clear();

            EkrandaBaslikYaz("Kare Alan Hesabı");
            Console.Write("Lütfen a kenar uzunluğu girinz(cm): ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Kare alanı: " + (a * a) + "cm");

            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için bir tuşa basın:");
            Console.ReadKey();
        }

        static void DiktdortgenAlaniHesaplama()
        {
            Console.Clear();

            EkrandaBaslikYaz("Dikdörtgem Alan Hesabı");

            Console.Write("Lütfen a kenar uzunluğu girinz(cm): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lütfen b kenar uzunluğu girinz(cm): ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Diktörgen alanı: " + (a * b) + "cm");

            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için bir tuşa basın:");
            Console.ReadKey();
        }

        static void UcgenAlaniHesaplama()
        {
            Console.Clear();

            EkrandaBaslikYaz("Ucgen Alan Hesabı");

            Console.Write("Lütfen bir a kenar uzunluğu girinz(cm): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lütfen h yüksekliği girinz(cm): ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Üçgen alanı: " + ((a * h ) / 2) + "cm");

            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için bir tuşa basın:");
            Console.ReadKey();
        }

        static void YamukAlaniHesaplama()
        {
            Console.Clear();

            EkrandaBaslikYaz("Yamuk Alan Hesabı");

            Console.Write("Lütfen bir a kenar uzunluğu girinz(cm): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Lütfen b kenarı girinz(cm): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Lütfen h yüksekliği girinz(cm): ");
            int h = int.Parse(Console.ReadLine());


            double sub = (Convert.ToDouble(a) + Convert.ToDouble(b)) / 2d;
            double result = sub * Convert.ToDouble(h);
            


            Console.WriteLine();
            Console.WriteLine("Yamuk alanı: " + result + "cm");

            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için bir tuşa basın:");
            Console.ReadKey();
        }


        static void İslemYap(int secim)
        {
            switch (secim)
            {
                case 1:
                    KareAlaniHesaplama();

                    break;
                case 2:
                    DiktdortgenAlaniHesaplama();

                    break;

                case 3:
                    UcgenAlaniHesaplama();

                    break;

                case 4:
                    YamukAlaniHesaplama();
                    break;

                default:
                    break;

            }
        }


    }
}
