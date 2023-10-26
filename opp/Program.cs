using System;

namespace BTK_AKADEMİ {

    class Program {
        
        static void Main(string[] args) {            
            // class => object (ogr1, ogr2)
            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrSube = "1";
            ogr1.OgrenciNo = "1";
            ogr1.OgrAdSoyad = "100";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.OgrSube = "1";
            ogr2.OgrenciNo = "1";
            ogr2.OgrAdSoyad = "100";

            Ogrenci ogr3 = new Ogrenci();
            ogr3.OgrSube = "1";
            ogr3.OgrenciNo = "1";
            ogr3.OgrAdSoyad = "100";

            Ogrenci[] ogrenciler = new Ogrenci[3];

            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            ogrenciler[2] = ogr3;

            foreach (var ogrenci in ogrenciler) {
               Console.WriteLine(ogrenci.BilgileriYazdir());
               //Console.WriteLine($"{ogrenci.OgrenciNo} numaralı öğrencinin adı {ogrenci.OgrAdSoyad} ve şubesi {ogrenci.OgrSube}");
            }
        } 
    }

        class Ogrenci {
            // property => string, int 
            public string OgrenciNo { get; set; }
            public string OgrAdSoyad { get; set; }
            public string OgrSube { get; set; }

            // methods
            public string BilgileriYazdir()
            {
                return $"{this.OgrenciNo} numaralı öğrencinin adı {this.OgrAdSoyad} ve şubesi {this.OgrSube}";
            }
    }
}