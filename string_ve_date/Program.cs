// Console.Write("isim: ");
// var isim = Console.ReadLine();
// Console.Write("soyad: ");
// var soyad = Console.ReadLine();
// Console.Write("yaş: ");
// var yas = Console.ReadLine();
// //string concat
// string mesaj = isim + " " + soyad +" isimli kişi " + yas + " yaşındadır."; 
// //string interpolation
// string mesaj2 = $"{isim} {soyad} isimli kişi {yas} yaşındadır.";
// Console.WriteLine(mesaj);

// //String Metods mesaj.Leght=kaç karakter olduğudur.
// string mesaj = "dk     fdfk  dfl";
// var sonuc = mesaj.Leght; //karakter yazısını yadırma.
// var sonuc = mesaj.ToLower(); //harferi küçültür.
// var sonuc = mesaj.ToUpper(); //harfleri büyütür.
// var sonuc = mesaj.Trim(); //boşluk karakterleri sayar.
// var sonuc = mesaj.Split(" ")[0];
// var sonuc = mesaj[0];
// var sonuc = mesaj.StartsWith("d"); //Bu bilgi ile mi başllıyor?
// var sonuc = mesaj.EndsWith("."); //Bu bilgi ile mi bitiyor?
// var sonuc = mesaj.Contains("dk"); //Böyle bir string var mı?
// var sonuc = mesaj.IndexOf("abc"); //girilen değerin index numarasını verir.
// var sonuc = mesaj.Substring(6, 5); //Aralıkları verir
// Console.WriteLine(sonuc);

// string kursadi = ".NET 7 ile C# Programlama Dİli";
// var sonuc = kursadi.Length;
// Console.WriteLine(sonuc);
// var sonuc4 = kursadi.ToLower();
// Console.WriteLine(sonuc4);
// var sonuc1 = kursadi.StartsWith(".");
// Console.WriteLine("String . ile başlıyor: " + sonuc1);
// var sonuc2 = kursadi.IndexOf("C#");
// Console.WriteLine("Konum: " + sonuc2);
// var sonuc3 = kursadi.Contains("C#");
// Console.WriteLine("C# içeriyor mu: " + sonuc3);
// var sonuc5 = kursadi.Replace("dili", "Dersleri");
// Console.WriteLine("Güncellendi: " + sonuc5);

var simdi = DateTime.Now;
Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.DayOfYear);
Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.Minute);
Console.WriteLine(simdi.Second);

DateTime dt = new DateTime(2018, 6, 10, 14,30, 45); //Zamanı kendin oluşturma.
DateTime dt2 = dt.AddYears(1);
DateTime dt3 = dt.AddYears(2);
Console.WriteLine(dt2.Year);
Console.WriteLine(dt3.Hour);

var fark = simdi - dt;
Console.WriteLine(fark.TotalDays);