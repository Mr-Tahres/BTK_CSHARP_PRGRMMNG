using System;

namespace BTK_AKADEMİ {

    class Program {
        
        static void Main(string[] args) 
        {
            var soru1 = new Soru(1, "hangisi yukarıda dır?", new string[4] {"a", "b", "c", "d"}, "a");   
        
            var soru2 = new Soru(2, "hangisi ortada dır?", new string[4] {"a", "b", "c", "d"}, "b");

            var soru3 = new Soru(3, "hangisi aşağıda dır?", new string[4] {"a", "b", "c", "d"}, "d");

            Console.WriteLine(soru1.SoruYazdir());
            Console.WriteLine(soru1.cevapKontrol("c"));

            Console.WriteLine(soru2.SoruYazdir());
            Console.WriteLine(soru2.cevapKontrol("b"));

            Console.WriteLine(soru3.SoruYazdir());
            Console.WriteLine(soru3.cevapKontrol("d"));
            // var sorular = new Soru[] { soru1, soru2, soru3};

            // foreach (var soru in sorular)
            // {
            //     Console.WriteLine(soru.SoruMetni);
            //     foreach (var secenek in soru.Secenekler)
            //     {
            //         Console.WriteLine(secenek);
            //     }

            //     Console.WriteLine("CEVABINIZ: ");
            //     var Cevap = Console.ReadLine();

            //     if (soru.cevapKontrol(Cevap))
            //     {
            //         Console.WriteLine("DOĞRU");
            //     } else {
            //         Console.WriteLine("YANLIŞ");
            //     }
            // }
        }
    }
            class Soru {           
            public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
            {
                   this.SoruId = soruId; 
                   this.SoruMetni = soruMetni;
                   this.Secenekler = secenekler;
                   this.Cevap = cevap;
            }
            private int SoruId { get; set; }
            private string SoruMetni { get; set; }
            private string[] Secenekler { get; set; }
            private string Cevap { get; set; }
            //methods
            public string SoruYazdir()
            {
                string soru = "";
                
                soru += this.SoruMetni +"\n";

                foreach (var secenek in this.Secenekler)
                {
                    soru += secenek + "\n";
                }

                return soru;
            }
            public bool cevapKontrol(string cevap)
            {
                return this.Cevap.ToLower() == cevap.ToLower();
            }
        }
}

            // public Soru()
            // {
            //     Console.WriteLine("constructor 1");
            //     this.SoruId = (new Random()).Next(11111,99999);
            // }

            // public Soru(int SoruId)
            // {
            //     Console.WriteLine("constructor 2");
            //     this.SoruId = soruId;
            // } 