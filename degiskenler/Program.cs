internal class Program
{
    private static void Main(string[] args)
    {
        // var kdvOrani = 1.08;
        // var urunA = 5000;
        // var urunB = 6000;
        // var urunC = 7000;
        // var urunD = 5000;

        // Console.WriteLine(urunA * kdvOrani); // // urunA
        // Console.WriteLine(urunB * kdvOrani); // // urunB
        // Console.WriteLine(urunC * kdvOrani); // // urunC
        // Console.WriteLine(urunD * kdvOrani); // // urunD
        
        // //Değişken Tanımlama,

        // var sayi = 20;
        // var urunAdi = "Anime Girl";
        // Console.WriteLine(sayi);
        // Console.WriteLine(urunAdi);
        // //Büyük-küçük harf duyarlılığı vardır.(var fiyat, var Fiyat)
        // //Boşluk içermez.(var urun adi = "...";
        // //Sayı ile başlayamaz.(var 2sayi = 30;)
       
        // var sayi2 = 30;
        // sayi2 = 50;
        // Console.WriteLine(sayi2);
        // var satistaMi = false;
        // var satistaMi1 = "evet";
        // var ogrenciNo = "1025"; // Sayısal ifadeler matematik işlemlerinde kullanılmayacaksa "" içinde kullanılması uygun olabilir.
        // Console.WriteLine(satistaMi);
        // Console.WriteLine(satistaMi1);
        // Console.WriteLine(ogrenciNo);

        // //Uygulama-> Değişkenler

        // //App1
        var ogrenciAdi = "A";
        var ogrenciSoyadi = "A";
        var ogrenciAdSoyad = ogrenciAdi + " " + ogrenciSoyadi;
        var ogrenciNumarasi = "1";
        var ogrencicinsiyeti = "e";
        var ogrencitcVatandaşiMi = true;
        var ogrencitcKimlik = "1";
        var ogrenciDogumyili = 2002;
        var ogrenciadresbilgisi = "...";
        var simdi = DateTime.Now;
        var ogrenciYasi = simdi.Year - ogrenciDogumyili;
 
        Console.WriteLine(ogrenciAdi);
        Console.WriteLine(ogrenciAdSoyad);
        Console.WriteLine(ogrenciSoyadi);
        Console.WriteLine(ogrenciAdi+ " " + ogrenciSoyadi);
        Console.WriteLine(ogrenciNumarasi);
        Console.WriteLine(ogrencicinsiyeti);
        Console.WriteLine(ogrencitcVatandaşiMi);
        Console.WriteLine(ogrencitcKimlik);
        Console.WriteLine(ogrenciDogumyili);
        Console.WriteLine(ogrenciYasi);
        Console.WriteLine(ogrenciadresbilgisi);

        // //App 2
        var urun1 = 50;
        var urun2 = 60.5;
        var urun3 = 356.45;
        var toplam = urun3 + urun2 + urun1;
        Console.WriteLine(toplam + " TL");
    }
}