// //Array (Diziler)
// var kursAdi = ".net 7 ile C# programlama dersleri".Split(" ");
// string[] isimler = new string[2];
// isimler[0]="A";
// isimler[1]="GIYASEDDİN EBU'L FETH BİN İBRAHİM EL HAYYAM";
// string[] isimler2= {"A","B"};
// float[] numaralar = new float[2];
// numaralar[0]=1f;
// numaralar[1]=999999999999999999999999999999999999f;
// int[] numaralar2={100,200};
// Console.WriteLine($"{numaralar[0]} numaralı öğrencinin adı {isimler[0]}");
// Console.WriteLine($"{numaralar[1]} numaralı öğrencinin adı {isimler[1]}");
// Console.WriteLine($"{numaralar2[1]} numaralı öğrencinin adı {isimler2[1]}");

// // Dizi Metotları (Array methods)
// string[] sehirler = {"zonguldak","rize","kocaeli"};
// int[] plakalar = {67,53,41};
// sehirler[0] ="sakarya";
// sehirler.SetValue("sakarya",1);
// Console.WriteLine(sehirler.GetValue(1));
// Console.WriteLine(sehirler.Length);
// Console.Write("rize: ", Array.IndexOf(sehirler,"rize"));
// Array.Sort(sehirler);
// Array.Sort(plakalar);
// Array.Reverse(plakalar);
// Array.Clear(sehirler);
// Array.Clear(plakalar, 0, 1);
// Console.WriteLine(plakalar.GetValue(0));
// Console.WriteLine(sehirler.GetValue(1));
// Console.WriteLine(sehirler.GetValue(2));

//Dizi istenilen_bölümü_alma-parçalama(Slicing)
// string[] sehirler = {"zonguldak","rize","kocaeli","ankara"};
// var i = sehirler[1..3];
// Console.WriteLine(i.Length);
// Console.WriteLine(i[2]);
// foreach(var i in sehirler[2..]) {
//     Console.WriteLine(i);
// }
// string il ="Kocaeli";
// Console.WriteLine(il[..5]);

//Dizi Uygulamaları
// string[] ogrenciler = {"A","B","C"};
// int[] notlar = {1,2,3};
// Console.Write(ogrenciler.Length);
// foreach(var i in ogrenciler[..3] notlar[..3]) {
//      Console.WriteLine(i);
// }
// foreach(notlar [1]+[2]+[3]/3)
// {
//   Console.WriteLine();
// }//yapılamadı
//öğretmenin tasarımı

// // Dizi Uygulamarı
// var ogrenciler = new string[3];
// var notlar = new int[3];
// Console.Write("1.öğrencinin adı: ");
// ogrenciler[0] = Console.ReadLine() ?? "";
// Console.Write("1.öğrencinin notu: ");
// notlar[0] = Convert.ToInt32(Console.ReadLine());
// Console.Write("2.öğrencinin adı: ");
// ogrenciler[1] = Console.ReadLine() ?? "";
// Console.Write("2.öğrencinin notu: ");
// notlar[1] = Convert.ToInt32(Console.ReadLine());
// Console.Write("3.öğrencinin adı: ");
// ogrenciler[2] = Console.ReadLine() ?? "";
// Console.Write("3.öğrencinin notu: ");
// notlar[2] = Convert.ToInt32(Console.ReadLine());
// foreach(var ogrenci in ogrenciler[..2]) {
//    Console.WriteLine(ogrenci);
// }
// foreach(var not in notlar[..2]) {
//    Console.WriteLine(not);
// }
// Console.WriteLine("Öğrenciler dizisinin eleman sayısı: " + ogrenciler.Length);
// var not1 = notlar[0];
// var not2 = notlar[1];
// var not3 = notlar[2];
// var ortalama = (not1 + not2 + not3) /3 ;
// Console.Write("Öğrencilerin not ortalaması: " + ortalama);

// // Çok boyutlu diziler
// string[] ogrenciler = {"Ali","Ahmet","Canan"};
// int[,] notlar = new int[3,3];
// // Ali
// notlar[0,0] = 50;
// notlar[0,1] = 60;
// notlar[0,2] = 70;
// // Ahmet
// notlar[1,0] = 50;
// notlar[1,1] = 60;
// notlar[1,2] = 70;
// // Canan 
// notlar[2,0] = 50;
// notlar[2,1] = 60;
// notlar[2,2] = 70;
// var ortalama_1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) /3;
// var ortalama_2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) /3;
// var ortalama_3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) /3;
// Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması: {ortalama_1}");
// Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması: {ortalama_2}");
// Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması: {ortalama_3}");









