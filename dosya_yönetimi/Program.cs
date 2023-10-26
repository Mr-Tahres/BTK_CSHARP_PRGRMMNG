
// StreamReader sr = File.OpenText("deneme.txt");
// Console.WriteLine(sr.ReadLine());
// Console.WriteLine(sr.ReadLine());
//+   
// var s = "";
// while ((s = sr.ReadLine()) != null) {
// Console.WriteLine(s);
// }
//+
// string sonuc1 = File.ReadAllText("deneme.txt");
// Console.WriteLine(sonuc1);
//+
// string[] sonuc = File.ReadAllLines("deneme.txt");
// Console.WriteLine(sonuc[0]);
// Console.WriteLine(sonuc[1]);

// DOSYA YAZMA VE EKLEME
// using (StreamWriter sw = File.CreateText("deneme.txt")) {
//     sw.WriteLine("AYLARDAN");
//     sw.WriteLine("AĞUSTOS");
//     sw.WriteLine("GÜNLERDEN");
//     sw.WriteLine("CUMA");
// } 

// using (StreamWriter sw = File.AppendText("deneme.txt")) {
//     sw.WriteLine("GÜN");
//     sw.WriteLine("DOĞMADAN");
//     sw.WriteLine("EVVEL");
//     sw.WriteLine("İKLİMİ");
//     sw.WriteLine("RÜMA");
// } 



// File.WriteAllText("deneme.txt", "merabalar");
// File.AppendAllText("deneme.txt", " merabana meraba");

     // KLASÖRLERLE ÇALIŞMA
    // Directory.CreateDirectory("temp");
    // Directory.CreateDirectory("temp/deneme");

    // if (Directory.Exists("temp/deneme1")) {
    //     Directory.Delete("temp/deneme");
    // } else{
    //     Console.WriteLine("BÖYLE BİR DOSYA BULUNMUYOR.");
    // }

    // // string path = @"c:\temp";
    // string path = Directory.GetCurrentDirectory() + "/temp";

    // Console.WriteLine(path);

    // Directory.CreateDirectory(path);

      //DOSYA VE KLASÖRLERLE ÇAILŞMA
    // String rootPath = Directory.GetCurrentDirectory();
    // string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
    
    // foreach (var dir in dirs) {
    //     Console.WriteLine(dir);
    // }
    // string source_path = "";
    // string dest_path = "";
    // string[] dirs = Directory.GetDirectories(source_path, "*", SearchOption.AllDirectories);

    // foreach (var dir in dirs) {
    //     Console.WriteLine(dir);
    //     Console.WriteLine(Path.GetExtension(dir));
    //     Console.WriteLine(Path.GetFileNameWithoutExtension(dir));
    //     Console.WriteLine(Path.GetFileName(dir));

    //     var info = new FileInfo(dir);
    //     Console.WriteLine($"{Path.GetFileName(dir)}: {info.Length}");

    //     string name = Path.GetRandomFileName() + Path.GetExtension(dir);
    
    //     File.Copy(dir, $"{dest_path}{name}");
    // }