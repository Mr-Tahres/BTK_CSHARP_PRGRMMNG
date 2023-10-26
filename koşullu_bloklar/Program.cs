// KOŞULLU BLOKLAR
 // if/else bloğu
// string username = "serhat";
// string password = "123";
// if (username == "serhat"){
//     if(password == "123"){
//         Console.WriteLine("Merhaba BTK Akademi");
//     } else {
//         Console.WriteLine("PAROLA YANLIŞ");
//     }
//     } else{
//         Console.WriteLine("KULLANICI İSMİ YANLIŞ");   
//     }
 // // if/elseif
// string username = "serhat";
// string password = "123";
// if (username != "serhat"){
//     Console.WriteLine("KULLANICI İSMİ YANLIŞ");
//     } else if(password != "123"){
//         Console.WriteLine("PAROLA YANLIŞ");
//     }
//     else{
//         Console.WriteLine("Merhaba BTK Akademi");  
//     }
 // //APP İF/ELSE - 1
// Console.Write("1.sayı: ");
// var sayi = Convert.ToInt32(Console.ReadLine());
// Console.Write("2.sayı: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Toplam için:  +");
// Console.WriteLine("Çıkarma için: -");
// Console.WriteLine("Çıkarma için: *");
// Console.WriteLine("Bölme için:   /");
// Console.Write("Seçiminiz: ");
// var secim = Console.ReadLine();
// Double sonuc = 0;
// bool ok = true;
// if(secim == "+"){
//     sonuc = sayi + sayi1;
// }else if(secim == "-"){
//     sonuc = sayi - sayi1;
// }else if(secim == "*"){
//     sonuc = sayi * sayi1;
// }else if(secim == "/"){
//     if(sayi1 == 0) {
//         ok = false;
//         Console.WriteLine("İŞLEMİNİZ TANIMSIZDIR");
//     }else {
//         sonuc = sayi / sayi1;
//     }
// }else {
//     ok = false;
//     Console.WriteLine("İŞLEM BAŞARISIZ");
// }
// if (ok){
//     Console.WriteLine($"İşlem: {sayi} {secim} {sayi1} = {sonuc}");
// }
 // //APP İF/ELSE - 2
//     Console.WriteLine("1.YAZILI NOTU: ");
//     int yazılı = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("2.YAZILI NOTU: ");
//     int yazılı2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("SÖZLÜN NOTU: ");
//     int sozlu = Convert.ToInt32(Console.ReadLine());
//     var ortalama = (yazılı + yazılı2 + sozlu) / 3;
//     int not = -1;
//     bool ok =  true;
//     if(ortalama >= 0 && ortalama <25){
//         not = 0;
//     }else if(ortalama >= 25 && ortalama < 45){
//         not = 1;
//     }else if(ortalama >= 45 && ortalama <= 55){
//         not = 2;
//     }else if(ortalama >= 55 && ortalama <= 70){
//         not = 3;
//     }else if(ortalama >= 70 && ortalama < 80){
//         not = 4;
//     }else if(ortalama >= 80 && ortalama < 100){
//         not = 5;
//     }else {
//         ok = false;
//         Console.WriteLine("YANLIŞ NOT GİRDİNİZ.");
//     }
//     if(ok){
//     Console.WriteLine($"Not ortalamanız: {ortalama} ve notunuz: {not}");
//     }
 // //APP İF/ELSE - 3
//     Console.WriteLine("x: ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("y: ");
//     int y = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("z: ");
//     int z = Convert.ToInt32(Console.ReadLine());
//     var enbuyuk = 0;
//     if(x > y && x > z) {
//         enbuyuk = x;
//     }else if(y > x && y > z) {
//         enbuyuk = y;
//     }else {
//         enbuyuk = z;
//     }
//     Console.WriteLine("En büyük sayı: " + enbuyuk);
  // // SWİTCH/CASE/DEFAULT
// //int gun = 0; //0 PAZAR, 1 PAZARTESİ,...
// int gun = (int)DateTime.Now.DayOfWeek;
// switch(gun) {
//     case 0:
//         Console.WriteLine("PAZAR");
//         break;
//     case 1:
//         Console.WriteLine("PAZARTESİ");
//         break;
//     case 2:
//         Console.WriteLine("SALI");
//         break;
//     case 3:
//         Console.WriteLine("ÇARŞAMBA");
//         break;                
//     case 4:
//         Console.WriteLine("PERŞEMBE");
//         break;
//     case 5:
//         Console.WriteLine("CUMAR");
//         break;        
//     case 6:
//         Console.WriteLine("CUMARTESİ");
//         break;
//     default:
//         Console.WriteLine("HATA");
//         break;    
// }
// int ay = 12;
// switch (ay)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("KIŞ");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("İLKBAHAR");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("YAZ");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("SONBAHAR");
//         break;
//     default:
//         Console.WriteLine("HATA");
//         break;    
// }
  // // TERNARY
// int sayi = -9;
// var yazdır = (sayi % 2 == 0) ?
//                     (sayi > 0) ? "SAYI POZİTİF ÇİFT" : "SAYI NEGATİF ÇİFT":
//                     (sayi > 0) ? "SAYI POZİTİF TEK" : "SAYI NEGATİF TEK";
// Console.WriteLine(yazdır);
