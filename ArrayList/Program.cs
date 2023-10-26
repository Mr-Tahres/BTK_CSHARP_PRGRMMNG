using System;
using System.Collections;

namespace BTK_AKADEMİ {

    class Program {
        
        static void Main(string[] args) 
        {
            // ArrayList

            // non-generic => object
            // dinamik

            ArrayList liste = new ArrayList();

            liste.Add(10);
            liste.Add("10");
            liste.Add("ali");
            liste.Add(null);
            liste.Add(true);

            ArrayList liste2 = new ArrayList() {
            10,
            "ahmet",
            false,
            null,
            4.5
            };

            int[] sayilar ={10, 20, 30};

            liste.AddRange(sayilar);

            var eleman = (int)liste[0];
            var isim = liste[2].ToString();
            
            // insert
            liste.Insert(1, "sadık");
            liste.InsertRange(2, liste2);

            // remove
            liste.Remove(10);
            liste.Remove(2);
            liste.RemoveRange(2, 3);
            
            //containsi indecof
            Console.WriteLine(liste.Contains(100));
            Console.WriteLine(liste.IndexOf(10));
            
            // foreach (var item in liste)
            // {
            //     Console.WriteLİne(item);
            // }
        }
    }
        }
