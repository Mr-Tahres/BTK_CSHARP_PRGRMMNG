
// KOD BLOKLARINI TEKRARLAMAK İÇİN KULLANILIR.
//BAŞLA -> KONTROL DEĞİŞKENİ -> KONTROL -> 1.KOD BLOĞU -> DUR, VEYA -> KONTROL DEĞİŞKENİ -> KONTROL(ÖNCEKİ KONTROL) FALSE -> 2.KOD BLOĞU -> DUR
  // //FOR
// // kontrol değişkeni
// // kontrol
// // güncellenmesi
// for (var i = 1; i <= 9; i++) {
//     Console.WriteLine(i);
//     Console.WriteLine("MRB BTK AKADEMİ");
// }
// // FOR APP
// var toplam = 0;
// for(var i = 1; i <= 10; i++) {
//     if(i % 2 == 1) {
//     toplam += i;
//     }
// }
// Console.WriteLine(toplam);
 // FOR APP2
// Console.WriteLine("BAŞLANGIÇ: ");
// var baslangic = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("BİTİŞ: ");
// var bitis = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("ARTIŞ: ");
// var artis = Convert.ToInt32(Console.ReadLine()); 
// var toplam1 = 0;
// for(var i = baslangic; i < bitis; i = i + artis) {
//     toplam1 += i;
// }
// Console.WriteLine(toplam1);
 // // FOR APP3
// string[] isimler = {"ali","ahmet","yelda"};
// for(var i = 0; i < isimler.Length; i++) {
//     Console.WriteLine(isimler[i]);
// }
 // // FOR APP4
//  int [] sayilar = {1,3,4,36,41,56};
//  for (int i = 0; i < sayilar.Length; i++) {
//     if(sayilar[i] % 3 == 0) {
//         Console.WriteLine(sayilar[i]);
//     }
//  }

  // WHİLE
// koşul
// var i = 0;
// while(i < 10) {
//     Console.WriteLine(i);
//     i++;
// }
// string[] isimler = {"ali","ahmet"};
// var i = 0;
// while(i < isimler.Length) {
//     Console.WriteLine(isimler[i]);
//     i++;
// }
// var secim = "e";
// var sayac = 1;
// var toplam2 = 0;
// while (secim == "e") {
//     Console.Write($"{sayac}. sayı: ");
//     toplam2 += Convert.ToInt32(Console.ReadLine());
//     Console.Write("DEVAM ETMEK İSTİYOR MUSUNUZ? (e/h)");
//     secim = Console.ReadLine();
//     sayac++;
// } 
// Console.WriteLine($"{sayac-1} ADET SAYININ TOPLAMI: {toplam2}");

 // BREAK & CONTİNUE
// FOR DA 
// string isim = "monalisa";
// for(var i = 0; i < isim.Length; i++) {
//         if(isim[i] == 'h')
//         continue;
//         Console.WriteLine(isim[i]);
// }
//  Console.WriteLine("DĞNGÜ BİTTİ");
// string isim = "rapçi hakan";
// for(var i = 0; i < isim.Length; i++) {
//         if(isim[i] == 'h')
//         break;
//         Console.WriteLine(isim[i]);
// }
//  Console.WriteLine("DÖNGÜ BİTTİ");
// WHİLE DA
// int x = 0;
// while (x < 5){
//    x++;
//    if(x == 3)
//         continue;
//    Console.WriteLine(x);      
// }
// int x = 0;
// while (x < 5){
//    if(x == 3)
//         break;
//    x++;
//    Console.WriteLine(x);      
// }

  // WHİLE-APP1
// class Program
// {
//     static void Main(string[] args)
//     {
// var rnd = new Random();
// int tutulan = rnd.Next(1,100);
// int hak = 3;
// while(hak > 0) {
//   Console.WriteLine(tutulan);
//   Console.Write("TAHMİNİN SAYI: ");
//   int tahmin = Convert.ToInt32(Console.ReadLine());
//   hak--;
//   if(tahmin == tutulan) {
//     Console.WriteLine("TEBRİKLER BİLDİNİZ.");
//     break;
//   }else
//   {if (hak == 0){
//       Console.WriteLine("BİLEMEDİNİZ.");
//       break; }
//     if (tutulan > tahmin) {
//     if (tutulan > tahmin / 3) {
//       Console.WriteLine("ÇOK YUKARI"); }else
//     {
//       Console.WriteLine("YUKARI");
//     }}else {if(tahmin / 3 < tutulan) {
//       Console.WriteLine("ÇOK AŞAĞI");}else{
//       Console.WriteLine("AŞAĞI");
//       }}}}}}

  // do-while döngüsü
int i = 1;
do {
    Console.WriteLine(i);
    i++;
} while(false);
//+
Console.WriteLine("ADET : ");
int adet = Convert.ToInt32(Console.ReadLine());

String[] urunler = new string[adet];

int a = 0;

do {
  Console.Write("ÜRÜN ADI TANIMLYIN: ");
  urunler[a] = Console.ReadLine() ?? "";
  a++;
} while (adet != a);

Console.WriteLine("ÜRÜNLER LİSTELENİYOR...");

for (int b = 0; b < urunler.Length; b++)
{
  Console.WriteLine(urunler[b]);
}

  // forEach döngüsü
string ad = "ahmet";

for (int c = 0; c < ad.Length; c++) {
     Console.WriteLine(ad[c]);
}
//+
foreach (var harf in ad) {
    Console.WriteLine(harf);
}
//+  
int[] sayilar = {10,20,30};

foreach (var sayi in sayilar) {
    if (sayi == 20)
          continue;
    Console.WriteLine(sayi);
    }    

