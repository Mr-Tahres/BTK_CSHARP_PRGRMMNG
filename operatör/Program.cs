// //Aritmetik Operatörler (uygulama)
// int a = 10;
// int b = 50;
// int c = 20;
// var sonuc = (a-c) * b;
// Console.WriteLine(sonuc);
// int? a1 = null;
// int b1 = 20;
// var bos = (a1 ?? 0) + b1;
// Console.WriteLine(bos);
// int a2 = 10;
// int b2 = 20;
// a2=b2--;
// Console.WriteLine(a2);
// Console.WriteLine(b2);
// Console.WriteLine("sayı: ");
// int sayi = int.Parse(Console.ReadLine() ?? "0");
// var tc = sayi % 2;
// Console.WriteLine(tc);

// //Atama Operatörleri
// var a = 5;
// var b = 10;
// a *= b;
// a += 5;
// Console.WriteLine(a);
// //Math
// double sonuc1;
// sonuc1 = Math.Sqrt(45);
// Console.WriteLine(sonuc1);

// // KARŞILAŞTIMA OPERATÖRLERİ
// int a = 5, b = 5, c = 10, d = 3;
// string username = "serhatmeral";
// string password = "123";
// var sonuc2 = (a==b);
// sonuc2 = (c==d);
// sonuc2 = (username == "serhatmeral");
// sonuc2 = (password == "1234");
// sonuc2 = (a != b);
// sonuc2 = (a > b);
// sonuc2 = (a < b);
// sonuc2 = (a >= b);
// //ternary ****
// var sonuc3 = (a > b) ? "a büyük" : (a == b) ? "a b eşit" : "b büyük";
// Console.WriteLine(sonuc2);
// Console.WriteLine(sonuc3);

// int yasa = 18 , a = 17 , b = 12 , c = 9999%4 ;
// var sonuc4 = (yasa >= a) ? "Uygun" : "Uygun değil";
// var sonuc5 = (yasa >= b) ? "Uygun" : "Uygun değil";
// var sonuc6 = (yasa >= c) ? "Uygun" : "Uygun değil";
// Console.WriteLine("a kişisi: " + sonuc4);
// Console.WriteLine("b kişisi: " + sonuc5);
// Console.WriteLine("c kişisi: " + sonuc6);

// Console.Write("Yaşınız:");
// var yas = Convert.ToInt32(Console.ReadLine());
// var sonuc7 = (yas >= 18) ? "EHLİYET ALABİLİRSİNİZ.":"EHLİYET İÇİN YAŞINIZ TUTMUYOR";
// Console.WriteLine(sonuc7);
// Console.Write("SAYI: ");
// var say = Convert.ToInt32(Console.ReadLine());
// var sonuc8 = (say > 0) ? "POZİTİF(+)" : (say < 0) ? "NEGATİF(-)" : "NÖTR(-)";
// Console.WriteLine(sonuc8);
// Console.Write("SAYI: ");
// var sayi = Convert.ToInt32(Console.ReadLine());
// var sonuc9 = (sayi % 2 == 1) ? "SAYI TEK" : "SAYI ÇİFT";
// Console.WriteLine(sonuc9);

// // MANTIKSAL OPERATÖRLER
// var a3 = true;
// var b3 = true;
// var c = false;
// var d = false;
// //1 veya &&
// var sonuc10 = (a3 && b3);
// sonuc10 = (a3 && c);
// sonuc10 = (c && d);
// //2 veya || 
// sonuc10 = (a3 || b3);
// sonuc10 = (a3 || c);
// sonuc10 = (c || d);
// //3 veya !
// sonuc10 = !c;
// Console.WriteLine(sonuc10);

//MANTIKSAL OPERATÖRLER UYGULAMA
//APP1
int yas = 17;
bool veli_izni = false;
var sonuc11 = (yas >= 18 || veli_izni) ? "ÇALIŞABİLİR" : "ÇALIŞAMAZ" ;
Console.WriteLine(sonuc11);
//APP2
int not = 50;
bool gecer_not = (not >= 50);
var sonuc12 = (gecer_not) ? "GEÇTİ" : "KALDI" ;
Console.WriteLine(sonuc12);
//APP3
int ortalama = 50;
int zayif = 0;
var sonuc13 = (ortalama >= 70) ? 
                 ((zayif == 0) ? "TEŞEKKÜR ALABİLİRSİNİZ." : "ZAYIFINIZIN OLMAMASI GEREKİYOR.") : 
                 "NOTUNUZ EN AZ 70 OLMALIDIR." ;
Console.WriteLine(sonuc13);
//APP4
string egitim = "lisans";
bool sigara_icme = true;
var sonuc14 = ((egitim == "lisans" || egitim == "önlisans") && (!sigara_icme)) ? "İŞÇİ OLABİLİR" : "İŞCİ OLAMAZ";
Console.WriteLine(sonuc14);
//APP5
string name = "Serhat Meral";
string e_mail = "bilmemne";
string pasword = "123";
var sonuc15 = ((name == "NEMRUT" || e_mail == "bilmemne" ) && (pasword == "123")) ? "HOŞGELDİNİZ" : "YANLIŞ BİLGİ";
Console.WriteLine(sonuc15);

//RANDOM
string[] takimlar = {"a","b","c","d"};
var rnd =new Random();
int sayi = rnd.Next(0,4);
Console.WriteLine(takimlar[sayi]);



