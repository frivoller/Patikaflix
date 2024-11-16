using System;
using System.Collections.Generic;
using System.Linq;

public class Dizi
{
    public string DiziAdi { get; set; }
    public int YapimYili { get; set; }
    public string Turu { get; set; }
    public int YayinaBaslamaYili { get; set; }
    public string Yonetmen { get; set; }
    public string Platform { get; set; }
}

public class KomediDizisi
{
    public string DiziAdi { get; set; }
    public string Turu { get; set; }
    public string Yonetmen { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // kullanicidan dizi bilgilerini alma ve listeye ekleme
        List<Dizi> diziler = new List<Dizi>();
        bool devamMi = true;

        while (devamMi)
        {
            Console.WriteLine("Yeni bir dizi ekleyin:");

            Console.Write("Dizi Adı: ");
            string diziAdi = Console.ReadLine();

            Console.Write("Yapım Yılı: ");
            int yapimYili = int.Parse(Console.ReadLine());

            Console.Write("Türü: ");
            string turu = Console.ReadLine();

            Console.Write("Yayınlanmaya Başlama Yılı: ");
            int yayinaBaslamaYili = int.Parse(Console.ReadLine());

            Console.Write("Yönetmen: ");
            string yonetmen = Console.ReadLine();

            Console.Write("Yayınlandığı İlk Platform: ");
            string platform = Console.ReadLine();

            diziler.Add(new Dizi
            {
                DiziAdi = diziAdi,
                YapimYili = yapimYili,
                Turu = turu,
                YayinaBaslamaYili = yayinaBaslamaYili,
                Yonetmen = yonetmen,
                Platform = platform
            });

            Console.WriteLine("Başka bir dizi eklemek ister misiniz? (E/H)");
            string cevap = Console.ReadLine();
            devamMi = cevap.Equals("E", StringComparison.OrdinalIgnoreCase);
        }

        // komedi dizilerinden yeni bir liste olusturma
        List<KomediDizisi> komediDizileri = diziler
            .Where(d => d.Turu.Contains("Komedi"))
            .Select(d => new KomediDizisi
            {
                DiziAdi = d.DiziAdi,
                Turu = d.Turu,
                Yonetmen = d.Yonetmen
            })
            .OrderBy(d => d.DiziAdi)
            .ThenBy(d => d.Yonetmen)
            .ToList();

        // komedi dizilerini ekrana yazdirma
        Console.WriteLine("\nKomedi Dizileri:");
        foreach (var komediDizi in komediDizileri)
        {
            Console.WriteLine($"Dizi Adı: {komediDizi.DiziAdi}, Türü: {komediDizi.Turu}, Yönetmen: {komediDizi.Yonetmen}");
        }
        Console.ReadKey();
    }
}
