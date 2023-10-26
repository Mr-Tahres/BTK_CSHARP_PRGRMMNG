using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;

namespace BTK_AKADEMİ {

    class Program {
        
        static void Main(string[] args) 
        {
            // Dictionary
            // Key-Value => plaka -şehir

            Dictionary<int,string> plakalar = new Dictionary<int, string>();

            plakalar.Add(41, "Kocaeli");
            plakalar.Add(34, "İstanbul");
            plakalar.Add(53, "Rize");


            Dictionary<int,string> sayilar = new Dictionary<int, string>()
            {
                {1, "bir"},
                {2, "iki"},
                {3, "üç"}
            };

            Console.WriteLine(plakalar[41]);

            if (plakalar.ContainsKey(34)) {
                Console.WriteLine(plakalar[34]);
            }

            foreach (var plaka in plakalar)
            {
                Console.WriteLine(plaka.Key + " " + plaka.Value);
            }

            // update
            sayilar[1] = "one";
            //sayilar.Remove(1);
            //sayilar.Clear();

            Console.WriteLine(sayilar[1]);
            {
                
            }
        }
    }
}