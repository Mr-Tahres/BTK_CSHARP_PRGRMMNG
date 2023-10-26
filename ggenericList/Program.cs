using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;

namespace BTK_AKADEMİ {

    class Program {
        
        static void Main(string[] args) 
        {
            // Generic List

            List<int> sayilar = new List<int>();

            sayilar.Add(10);
            sayilar.Add(20);

            List<String> isimler = new List<string>() { "ali", "b", "c"};

            List<Product> urunler = new List<Product>();

            urunler.Add(new Product(){Id=1, Title="a", Price=1});
            urunler.Add(new Product(){Id=2, Title="b", Price=2});
            urunler.Add(new Product(){Id=3, Title="c", Price=3});

            urunler.Insert(urunler.Count, new Product() { Id=4, Title="d(NEW)", Price=4});

            // urunler.RemoveAt(2);
            // urunler.Remove(urunler[0]);

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Title + " " + urun.Price);
            }
        }
        class Product
        {
            public int Id { get; set; }
            public string? Title { get; set; }
            public double Price { get; set; }
        }
    }
}