using System;

namespace modul3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////FOR DÖNGÜSÜ

            //for ( int sayac = 0; sayac < 10; sayac += 2)
            //{
            //    Console.WriteLine("Sayac : " +sayac);
            //}

            //Console.WriteLine("**************");

            ////WHILE DÖNGÜSÜ
            //int sayac = 0;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine("Sayac:" + sayac);
            //    sayac++;
            //}
            //Console.WriteLine("**************");

            ////DO-WHİLE DÖNGÜSÜ

            //int sayac = 0;
            //do
            //{
            //    Console.WriteLine("Sayac:" + sayac);
            //    sayac++;

            //} while (sayac < 10);

            //Console.WriteLine("**************");

            ////BREAK-CONTINUE

            //for(var i = 0; i < 10; i++)
            //{
            //    if(i == 2)
            //    {
            //        continue; //2 sayısını durduracak sadece.
            //    }
            //    Console.WriteLine("Sayac:" +i);

            //    if(i == 5)
            //    {
            //        break; //döngüden çıkmamı sağlıyor. 5 koşuluna bağlı olduğu için 5den sonrasını çalıştırmayacak.
            //    }
            //}
            //Console.WriteLine("**************");

            ////DİZİ KAVRAMI
            //string[] dizi = new string[3];
            //dizi[0] = "abc";
            //dizi[1] = "def";
            //dizi[2] = "ghk";
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine("-----");

            //for ( var i = 0; i< 3; i++)
            //{
            //    Console.WriteLine(dizi[i]); 
            //}

            //int[] sayilar = new int[2];
            //sayilar[0] = 1;
            //sayilar[1] = 2;

            //Console.WriteLine(sayilar[1]);
            //Console.WriteLine(sayilar[0]);

            //string[] meyveler = new string[] {"elma" , "armut" , "üzüm" , "kiraz"};

            //for (int i = 0; i<meyveler.Length; i++)
            //{
            //    Console.WriteLine(i + "nci meyve "  + meyveler[i]);
            //}

            //Console.WriteLine("**************");


            ////FOREACH DÖNGÜSÜ
            //string[] meyveler = new string[] { "elma", "armut", "üzüm", "kiraz" , "Kavun"};

            //    for (int i = 0; i<meyveler.Length; i++)
            //     {
            //          string meyveAdi = meyveler[i];
            //          Console.WriteLine(meyveAdi);

            //     }
            //    Console.WriteLine("-------");
            //foreach (string meyveAdi in meyveler)
            //{
            //    Console.WriteLine(meyveAdi);
            //}


            //Console.WriteLine("**************");
            ////CLONE-COPY-SORT-RESİZE-INDEXOF-REVERSE
            //string[] meyveler = new string[] { "elma", "armut", "üzüm", "kiraz", "Kavun" };

            //foreach (string meyveAdi in meyveler)
            //    {
            //        Console.WriteLine(meyveAdi);
            //    }
            //Console.WriteLine("--CLone--");
            ////Clone yeni bir dizi nesnesi şeklinde orjinal diziyi kopyalar
            //   string[] meyveler2 = (string[])meyveler.Clone();
            //foreach (string meyveAdi in meyveler2)
            //{
            //    Console.WriteLine(meyveAdi);
            //}

            //Console.WriteLine("--Copy--");

            ////yeni idiz oluşturmasını biz yaparız ve onun içine kopyalanacak index elemanlarından itibaren kopyalanması sağlanır.
            //string[] meyveler3 = new string[meyveler.Length];
            //meyveler.CopyTo(meyveler3, 0);
            //foreach (string meyveAdi in meyveler3)
            //{
            //    Console.WriteLine(meyveAdi);
            //}

            //Console.WriteLine("--Sort--");
            ////dizideki elemanları tipine göre sıralama yapar.
            //Array.Sort(meyveler);

            //foreach (string meyveAdi in meyveler)
            //{
            //    Console.WriteLine(meyveAdi);
            //}
            //Console.WriteLine("--Reverse--");
            ////diziyi tersten sıralar 
            //Array.Reverse(meyveler);

            //foreach (string meyveAdi in meyveler)
            //{
            //    Console.WriteLine(meyveAdi);
            //}
            //Console.WriteLine("--Resize--");
            ////boyutlandırma yapar
            //Array.Resize(ref meyveler, meyveler.Length + 1);

            //meyveler[meyveler.Length - 1] = "Çilek";

            //foreach (string meyveAdi in meyveler)
            //{
            //    Console.WriteLine(meyveAdi);
            //}

            //Console.WriteLine("--Indexof--");
            ////elemanların index numarasını döndürür
            //int index = Array.IndexOf(meyveler, "Çilek");//bulamazsa -1 döner 
            //Console.WriteLine(index);

            //    Console.WriteLine("**************");
            //    //METODLAR

            //    string[] meyveler = new string[] { "elma", "armut", "üzüm", "kiraz", "Kavun" };

            //    EkranaDiziyiYaz(meyveler);

            //    Console.WriteLine("--Sort--");
            //    //dizideki elemanları tipine göre sıralama yapar.
            //    Array.Sort(meyveler);

            //    EkranaDiziyiYaz(meyveler);
            //    Console.WriteLine("--Reverse--");
            //    //diziyi tersten sıralar 
            //    Array.Reverse(meyveler);

            //    EkranaDiziyiYaz(meyveler);


            //    Console.WriteLine("**************");
            //}


            //static void EkranaDiziyiYaz(string[] dizi)
            //{
            //    foreach (string eleman in dizi)
            //    {
            //        Console.WriteLine(eleman);
            //    }

            //}



            //METOD TÜRLERİ DEĞER DÖNDÜREN VE VOİD 
            //    EkranaMerhabaYaz();

            //    int sonuc = Topla();
            //    Console.WriteLine("Toplama işlemi sonucu:" + sonuc);


            //}

            //static void EkranaMerhabaYaz() 
            //{
            //    Console.WriteLine("Merhaba Nasılsınız?");
            //    return; //ALttaki tum kodları sonlandırır.
            //    Console.WriteLine(".......");
            //}

            //static int Topla()
            //{
            //    int sayi1 = 5;
            //    int sayi2 = 20;

            //    int toplam = sayi1+ sayi2;
            //    return toplam;
            //}

            //    //PARAMETLERİ VE PARAMETRESİZ METODLAR
            //    Console.WriteLine("Hello World");
            //    Console.WriteLine();

            //    int sonuc = Topla(25, 45);
            //    Console.WriteLine("Sonuc" + sonuc);
            //    MerhabaYaz("Şeyma Sırakaya");

            //}
            //static int Topla(int sayi1, int sayi2) 
            //{ 
            //    return sayi1 + sayi2;
            //}

            //static void MerhabaYaz(string isim)
            //{
            //    Console.WriteLine("Merhaba " + isim);
            //    Console.WriteLine("Hoş Geldiniz");
            //    Console.WriteLine();
            //}

            //VARSAYILAN DEĞERLİ VE OPSİYONEL PARAMETRELER  

            //    int sonuc1 = Topla(10, 25);
            //    Console.WriteLine(sonuc1);
            //    int sonuc2 = Topla(23, 25, 35);
            //    Console.WriteLine(sonuc2);


            //}
            //static int Topla(int sayi1, int sayi2, int sayi3 = 0)
            //{
            //    return sayi1 + sayi2 + sayi3;
            //}


            //Params Keywords

            //    int[] sayilarim = new int[] { 1, 2, 4, 5, 2, 3 };
            //    int sonuc = Topla(sayilarim);

            //    Console.WriteLine("Sonuc 1" + sonuc);

            //    int sonuc2 = Topla(12, 34, 54, 6, 789, 98, 67, 56);
            //    Console.WriteLine("Sonuc2: " + sonuc2);
            //}

            //static int Topla(params int[] sayilar)
            //{
            //    int toplam = 0;

            //    foreach (int sayi in sayilar)
            //    {
            //        toplam += sayi;
            //    }
            //    return toplam;
            //}

            //METOD İMZASI

            //}

            //static void Metot1(int s1)
            //{

            //}

            //static void Metot1(int s2, int s1)
            //{

            //}

            //RECURSİVE(ÖZYİNELEMELELİ) METODLAR
            //    Console.WriteLine("Faktoriyel Hesaplama");
            //    Console.WriteLine("**********************");
            //    Console.WriteLine();

            //    Console.WriteLine("Lütfen bir sayi giriniz");
            //    int sayi = int.Parse(Console.ReadLine());
            //    int sonuc = Faktoriyel(sayi);
            //    Console.WriteLine(sayi + "! " + "Sonucu:" + sonuc);


            //}

            //static int Faktoriyel(int deger)
            //{
            //    if(deger == 0) 
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        return deger * Faktoriyel(deger - 1);
            //    }

            //}

            //STRİNG METODLAR 
            //string str = "Ne mutlu Türküm diyene!" ;

            //Console.WriteLine(str);

            //Console.WriteLine("--Trim--");
            //str = str.Trim();
            //Console.WriteLine(str);

            //Console.WriteLine("--ToLower--");
            //str = str.ToLower();
            //Console.WriteLine(str);

            //Console.WriteLine("--ToUpper--");
            //str = str.ToUpper();
            //Console.WriteLine(str);

            //Console.WriteLine("--SubString--");
            //string sonuc1 = str.Substring(3,5); //3den başla 5 karakter al
            //Console.WriteLine(sonuc1);

            //Console.WriteLine("--Reverse--");
            //char[] chars = str.ToCharArray();
            //Array.Reverse(chars);
            //string sonuc2 = new string(chars);
            //Console.WriteLine(sonuc2);

            //Console.WriteLine("--IndexOf--");
            //int sonuc3 = str.IndexOf('M'); //soldan başayarak ilk M harfinin indexi :3
            //int sonuc4 = str.IndexOf('M', sonuc3 + 1); //Bir önceki M harfinden sonraki M harfinin indexi :14
            //Console.WriteLine(sonuc3 + " ve " + sonuc4);

            //Console.WriteLine("--Remove--");
            //string sonuc5 = str.Remove(3,5); //3den itibaren 5 karakter sil yapıyı sil
            //Console.WriteLine(sonuc5);

            //Console.WriteLine("--Contains--");
            //bool sonuc6 = str.Contains("MUTLU");//değer var mı yok mu 
            //Console.WriteLine(sonuc6);

            //Console.WriteLine("--Replace--");
            //string sonuc7 = str.Replace("MUTLU", "MUTLUYUM"); //Mutluyu Mutluyum yap 
            //Console.WriteLine(sonuc7);

            //Console.WriteLine("--Split--");
            //string[] sonuc8 = str.Split(' ');
            //Console.WriteLine(string.Join(',', sonuc8));


            //MATH METODLARI

            //double val = 3.46;

            //Console.WriteLine("--PI--");
            //Console.WriteLine("PI:" + Math.PI); //pi değeri

            //Console.WriteLine("--Floor--");
            //Console.WriteLine("Flor:" + Math.Floor(val)); //virgülü atıyor

            //Console.WriteLine("--Ceiling--"); //yuvarlama
            //Console.WriteLine("Ceiling:" + Math.Ceiling(val));

            //Console.WriteLine("--Round--"); //sayının virgülden sonra yazacağı kısım
            //Console.WriteLine("Round:" + Math.Round(val,3));

            //Console.WriteLine("--Max--"); 
            //Console.WriteLine("Max:" + Math.Max(val, 3.85)); //maximum sayı

            //Console.WriteLine("--Min--");
            //Console.WriteLine("Min:" + Math.Min(val, 3.44)); //minimum sayı

            //Console.WriteLine("--Pow--");
            //Console.WriteLine("Pow:" + Math.Pow(4,2)); //üslü ifade

            //Console.WriteLine("--Sqrt--");
            //Console.WriteLine("Sqrt:" + Math.Sqrt(995)); //sayının karekökü



            //DATE METODLARI

            DateTime tarih = new DateTime(2010, 5, 20, 10, 20, 15);
            Console.WriteLine("Kendi oluşturduğum toString: " +tarih.ToString());


            Console.WriteLine("--Now--");
            Console.WriteLine("Now:" + DateTime.Now); //şuan tarih
            Console.WriteLine("Day:" + DateTime.Now.Day);//gün
            Console.WriteLine("Month:" + DateTime.Now.Month); //ay
            Console.WriteLine("Year:" + DateTime.Now.Year); //yıl
            Console.WriteLine("Hour:" + DateTime.Now.Hour); //saat
            Console.WriteLine("Minute:" + DateTime.Now.Minute); //dakika
            Console.WriteLine("Second:" + DateTime.Now.Second); //saniye
            Console.WriteLine("MilliSecond:" + DateTime.Now.Millisecond); //milisaniye

            Console.WriteLine("--AddDays--");
            Console.WriteLine("AddDays:" + DateTime.Now.AddDays(-10)); //Şuanki zamandan 10 gün azalt

            Console.WriteLine("--AddHours--");
            Console.WriteLine("AddHours:" + DateTime.Now.AddHours(10)); //Şuanki zamana 10 saat

            Console.WriteLine("--AddMonth--");
            Console.WriteLine("AddMonth:" + DateTime.Now.AddMonths(6)); //Şuanki zamana 6 ay

            Console.WriteLine("--AddYears--");
            Console.WriteLine("AddYears:" + DateTime.Now.AddYears(8)); //Şuanki zamana 8 yıl

            Console.WriteLine("--ToShortDateString--");
            Console.WriteLine("ToShortDateString:" + DateTime.Now.ToShortDateString()); //Şuanki zamanın kısa hali gün ay yıl

            Console.WriteLine("--ToLongDateString--");
            Console.WriteLine("ToLongDateString:" + DateTime.Now.ToLongDateString()); //Şuanki zamanın uzun hali gün ay yıl 

            Console.WriteLine("--ToShortTimeString--");
            Console.WriteLine("ToShortDateString:" + DateTime.Now.ToShortTimeString()); //Şuanki saatin kısa hali 

            Console.WriteLine("--ToLongTimeString--");
            Console.WriteLine("ToLongDateString:" + DateTime.Now.ToLongTimeString()); //Şuanki saatin uzun hali 









        }
    }
}

