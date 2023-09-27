//
//Aritmetik işlem
//int sayi1 = 20;
//int sayi2 = 4;

//decimal toplam = sayi1 + sayi2;
//decimal fark = sayi1 - sayi2;
//decimal bolum = sayi1 / sayi2;
//decimal carpim = sayi1 * sayi2;
//decimal mod = sayi1 % sayi2;

//Console.WriteLine("Toplam: " + toplam);
//Console.WriteLine("Fark : " + fark);
//Console.WriteLine("Bölüm: " + bolum);
//Console.WriteLine("Çarpım : " + carpim);
//Console.WriteLine(sayi1 + "mod" + sayi2 + ":" + mod);


//
//Random

//Random rastgele = new Random();
//int rastgeleSayi1 = rastgele.Next(100);
//int rastgeleSayi2 = rastgele.Next(5, 15);

//Console.WriteLine("rastgele1.sayi " + rastgeleSayi1);
//Console.WriteLine("rastgele2.sayi" + rastgeleSayi2);


//
//Convert
//int sayi = 12;
//string sayiString = "12";

//bool varmi = false;
//string varmiString = "false";

//Console.WriteLine(sayiString + 2);

//int sonuc1 = Convert.ToInt32(sayiString);
//bool sonuc2 = Convert.ToBoolean(varmiString);
//Console.WriteLine(sonuc1 + 2);
//Console.WriteLine(sonuc2);


//
//Parse

//string metin = "122";
//Console.WriteLine(metin + 3);

//int sonuc1 = int.Parse(metin);
//Console.WriteLine(sonuc1 + 3);

//bool sonuc2 = bool.Parse("true");
//bool sonuc3 = bool.Parse("false");

//decimal sayi = 12.3m;
//decimal sonuc4 = decimal.Parse("12,3");

//Console.WriteLine(sonuc4 + 3);


//int sayi = 10;
//decimal parasal = 1000.45m;
//double virgulluBuyuk = 100.4d;
//float virgulluKucuk = 4.5f;
//bool varmi = true;

//Console.WriteLine(sayi + 5); // 15

//string sayiString = sayi.ToString(); // 10
//Console.WriteLine(sayiString + 5); //105

//Console.WriteLine(parasal.ToString() + 5); //"1000,455
//Console.WriteLine(virgulluBuyuk.ToString() + 5); //"100,45
//Console.WriteLine(virgulluKucuk.ToString() + 5); //"4,55
//Console.WriteLine(varmi.ToString() + 5); //true



// implicit (üstü kapalı) - explicit(belirgin) dönüşüm

//int sayi = 4;

//Console.WriteLine(sayi + 5); //implicit

//string sayiString = "10";
//Console.WriteLine(sayiString + 5.ToString()); //implicit

//Console.WriteLine(sayiString + sayi.ToString()); //explicit


//Boxing (Kutulama) Kavramı

//byte yas = 25;
//int sayi = yas;

//object obj; //null
////obj = 5;
////obj = true;
////obj = "abc";  // boxing:kutulama

//obj = 10;
//Console.WriteLine(obj);
//Console.WriteLine(obj.ToString() + 5);  // "105"
//Console.WriteLine(Convert.ToInt32(obj) + 5); // 15

//unboxing (kutudan çıkarma - Casting 

//object obj1 = 5; //boxing
//object obj2 = true; //boxing

//int sonuc1 = Convert.ToInt32(obj1); //5 unboxing
//bool sonuc2 = Convert.ToBoolean(obj2); //true- unboxing

//int sonuc3 = (int)obj1; //unboxing - casting
//bool sonuc4 = (bool)obj2; // unboxing - casting

//Console.WriteLine(sonuc3 + 5); //10
//Console.WriteLine(sonuc4); //true




