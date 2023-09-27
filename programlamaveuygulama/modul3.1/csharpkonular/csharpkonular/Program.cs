// if-else if- else
namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {

            //int sayi = 5;

            //if (sayi == 4)
            //{
            //    Console.WriteLine("Dört");
            //}

            //// Console.WriteLine(sayi);

            //int sayi2 = 10;

            //if(sayi > sayi2)
            //{
            //    Console.WriteLine(sayi + " büyüktür " + sayi2);
            //}
            //else if(sayi < sayi2)
            //{
            //    Console.WriteLine(sayi + " küçüktür " + sayi2);
            //}
            //else //if(sayi == sayi2)
            //{
            //    Console.WriteLine(sayi + " eşittir " + sayi2);
            //}


            //iç içe if ifadeleri

            //int sayi1 = 10, sayi2 = 10;
            //if(sayi1 != sayi2)
            //{
            //    if(sayi1 > sayi2)
            //    {
            //        Console.WriteLine("sayi1 sayi 2den büyüktür");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayi1 küçüktür sayi2");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("sayilar eşittir");
            //}

            //MANTIKSAL OPERATÖRLER
            //int sayi1 = 10;
            //int sayi2 = 20;

            //if(sayi1 > 8 && sayi1 < 12) //ve işleminde tüm koşullar doğru olmalı
            //{
            //    //kodlar
            //}

            //if(sayi1 > 8 || sayi1 > 12)
            //{
            //    //kodlar
            //}
            //if ( !(sayi1 < 6 && sayi1 < 9))
            //{

            //}

            //MANTIKSAL OPERATORLER NOT HESAPLAMA

            //bool sinavaGirdiMi = true;
            //int not = 60;
            //string krediNotu = "";

            //if (sinavaGirdiMi == true)
            //{
            //    if (not < 100 && not >= 90)
            //    {
            //        krediNotu = "AA";
            //    }
            //    else if (not <= 89 && not >= 80)
            //    {
            //        krediNotu = "BA";
            //    }
            //    else if (not <= 79 && not >= 70)
            //    {
            //        krediNotu = "CA";
            //    }
            //    else if (not <= 69 && not >= 60)
            //    {
            //        krediNotu = "DD";
            //    }
            //    else
            //    {
            //        krediNotu = "FF";
            //    }
            //    Console.WriteLine("Öğrenci Sınava girmiştir");
            //    Console.WriteLine("Öğrenci Notu: " + krediNotu);
            //}
            //else
            //    Console.WriteLine("sınava girmemiştir");

            //TERNARY OPERATÖRÜ

            //int sayi1 = 10;
            //int sayi2 = 10;

            ////string sonuc = (sayi1 > sayi2) ? "büyüktür" : "küçüktür";
            //string sonuc = (sayi1 > sayi2) ? "büyüktür" : (sayi1 == sayi2) ? "esittir" : "kücüktür";

            //Console.WriteLine(sayi1 + sonuc + sayi2);



            //SWİTCH - CASE
            //int sayi = 6;
            //switch (sayi)
            //{
            //    case 5: Console.WriteLine("Sayi 5dir");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("Sayi 6 ya da 7dir");
            //        break;
            //    case 10:
            //        Console.WriteLine("Sayi 10dur");
            //        break;
            //    default:
            //        Console.WriteLine("bilinmeyen sayi");
            //        break;
            //}



            //TRY-CATCH-FINALLY

            //Console.Write("Lütfen bir sayı giriniz:");
            //string sayiStr = Console.ReadLine();

            //int sayi = int.Parse(sayiStr);

            //Console.Write("Lütfen bölen sayisini girin:");
            //string bolenStr = Console.ReadLine();

            //int bolen = int.Parse(bolenStr);

            //try
            //{
            //    decimal sonuc = sayi / bolen;

            //    Console.WriteLine("Bölüm: " + sonuc);
            //}

            //catch
            //{
            //    Console.WriteLine("İşlem yapılırken hata oluştu");
            //}
            //finally
            //{
            //    Console.WriteLine("işlem tamamlanmıştır");
            //}


            //Console.WriteLine("Bölünecek sayınız:");
            //int sayi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Bölen sayınız:");
            //int bolen = int.Parse(Console.ReadLine());

            //if(bolen == 0)
            //{
            //    Console.WriteLine("Bölen sııfr olamaz lütfen tekrar giriniz:");
            //    bolen = int.Parse(Console.ReadLine());
            //}

            //decimal sonuc = sayi / bolen;
            //Console.WriteLine(sonuc.ToString());
            ////try
            ////{
            ////    decimal sonuc = sayi / bolen;
            ////}
            ////catch
            ////{

            ////}



            //MANTIK HATALARI

            //Console.WriteLine("yasınız giriniz:");
            //int yas = int.Parse(Console.ReadLine());

            //if(yas <= 18)
            //{
            //    Console.WriteLine("Gençsiniz");
            //}
            //else if ( yas > 18 && yas < 50)
            //{
            //    Console.WriteLine("Orta yaştasınız");

            //}
            //else
            //{
            //    Console.WriteLine("Yaşlısınız");
            //}

            //TROW KEYWORD

            //Console.WriteLine("Bölünecek sayınız:");
            //int sayi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Bölen sayınız:");
            //int bolen = int.Parse(Console.ReadLine());

            //try 
            //{
            //    if (bolen == 0)
            //    {
            //        throw new Exception("Bölen sıfır olamaz lütfen programı tekrar çalıştırınız.");
            //    }

            //    decimal sonuc = sayi / bolen;

            //}
            //catch(Exception hata)
            //{
            //    Console.WriteLine("Hata oluştu");
            //    Console.WriteLine(hata.Message);
            //}

          



        }
    }
}