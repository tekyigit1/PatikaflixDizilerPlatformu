
using System;
using System.Collections.Generic;
using System.Linq;

public class Dizi
{
    public string Ad { get; set; }
    public int YapimYili { get; set; }
    public string Tur { get; set; }
    public int BaslamaYili { get; set; }
    public string Yonetmen { get; set; }
    public string Platform { get; set; }
}

// Yeni liste için sadece gerekli özellikleri tutacak class
public class KomediDizi
{
    public string Ad { get; set; }
    public string Tur { get; set; }
    public string Yonetmen { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Dizi> diziler = new List<Dizi>()
        {
            new Dizi { Ad = "Avrupa Yakası", YapimYili = 2004, Tur = "Komedi", BaslamaYili = 2004, Yonetmen = "Yüksel Aksu", Platform = "Kanal D" },
            new Dizi { Ad = "Yalan Dünya", YapimYili = 2012, Tur = "Komedi", BaslamaYili = 2012, Yonetmen = "Gülseren Buda Başkaya", Platform = "Fox TV" },
            new Dizi { Ad = "Jet Sosyete", YapimYili = 2018, Tur = "Komedi", BaslamaYili = 2018, Yonetmen = "Gülseren Buda Başkaya", Platform = "TV8" },
            new Dizi { Ad = "Dadı", YapimYili = 2006, Tur = "Komedi", BaslamaYili = 2006, Yonetmen = "Yusuf Pirhasan", Platform = "Kanal D" },
            new Dizi { Ad = "Belalı Baldız", YapimYili = 2007, Tur = "Komedi", BaslamaYili = 2007, Yonetmen = "Yüksel Aksu", Platform = "Kanal D" },
            new Dizi { Ad = "Arka Sokaklar", YapimYili = 2004, Tur = "Polisiye, Dram", BaslamaYili = 2004, Yonetmen = "Orhan Oğuz", Platform = "Kanal D" },
            new Dizi { Ad = "Aşk-ı Memnu", YapimYili = 2008, Tur = "Dram, Romantik", BaslamaYili = 2008, Yonetmen = "Hilal Saral", Platform = "Kanal D" },
            new Dizi { Ad = "Muhteşem Yüzyıl", YapimYili = 2011, Tur = "Tarihi, Dram", BaslamaYili = 2011, Yonetmen = "Mercan Çilingiroğlu", Platform = "Star TV" },
            new Dizi { Ad = "Yaprak Dökümü", YapimYili = 2006, Tur = "Dram", BaslamaYili = 2006, Yonetmen = "Serdar Akar", Platform = "Kanal D" }
        };

        // Komedi dizilerinden yeni liste oluşturma
        List<KomediDizi> komediListesi = diziler
            .Where(d => d.Tur.Contains("Komedi"))
            .Select(d => new KomediDizi
            {
                Ad = d.Ad,
                Tur = d.Tur,
                Yonetmen = d.Yonetmen
            })
            .OrderBy(d => d.Ad)        // Önce Dizi Adına göre sıralama
            .ThenBy(d => d.Yonetmen)   // Sonra Yönetmene göre sıralama
            .ToList();

        // Listeyi ekrana yazdırma
        Console.WriteLine("Komedi Dizileri Listesi (Ad / Tür / Yönetmen):");
        foreach (var dizi in komediListesi)
        {
            Console.WriteLine($"{dizi.Ad} - {dizi.Tur} - {dizi.Yonetmen}");
        }
    }
}
