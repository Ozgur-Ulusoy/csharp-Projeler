using System;
using System.Collections.Generic;

namespace SEHIR_BULMA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> iller = new List<string>()
            {
                "adana", "adiyaman", "afyonkarahisar", "agri", "aksaray", "amasya", "ankara", "antalya", "ardahan", "artvin", "aydin", "balikesir", "bartin", "batman", "bayburt", "bilecik", "bingol", "bitlis", "bolu", "burdur", "bursa", "canakkale", "cankiri", "corum", "denizli", "diyarbakir", "duzce", "edirne", "elazig", "erzincan", "erzurum", "eskisehir", "gaziantep", "giresun", "gumushane", "hakkari", "hatay", "igdir", "isparta", "istanbul", "izmir", "kahramanmaras", "karabuk", "karaman", "kars", "kastamonu", "kayseri", "kilis", "kirikkale", "kirklareli", "kirsehir", "kocaeli", "konya", "kutahya", "malatya", "manisa", "mardin", "mersin", "mugla", "mus", "nevsehir", "nigde", "ordu", "osmaniye", "rize", "sakarya", "samsun", "sanliurfa", "siirt", "sinop", "sivas", "sirnak", "tekirdag", "tokat", "trabzon", "tunceli", "usak", "van", "yalova", "yozgat", "zonguldak"
            }; // Türkiye'nin 81 ilini liste içine aldım

            Random rnd = new Random();


            for (int a = 0; a < 100000; a++) // 100.000 deneme hakkı
            {
                string s1 = (iller[rnd.Next(iller.Count)]); // 5 şehri iller listesinden rastgele olarak seçiyor
                string s2 = (iller[rnd.Next(iller.Count)]);
                string s3 = (iller[rnd.Next(iller.Count)]);
                string s4 = (iller[rnd.Next(iller.Count)]);
                string s5 = (iller[rnd.Next(iller.Count)]);

                Console.WriteLine(s1);
                Console.WriteLine(s2);
                Console.WriteLine(s3);
                if (s1.Length == 3 && s1[1] == s2[0] && s1[2] == s3[0]) 
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Aranan Şehir Bulundu ! ");
                    Console.WriteLine(@"
Bulunan Şehir {0}

{1}
{2}
{3}

Deneme Sayısı = {4}", s1, s1, s2, s3, a); break;
                }
                Console.WriteLine(s4);
                if (s1.Length == 4 && s1[1] == s2[0] && s1[2] == s3[0] && s1[3] == s4[0])
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Aranan Şehir Bulundu ! ");
                    Console.WriteLine(@"
Bulunan Şehir {0}

{1}
{2}
{3}
{4}

Deneme Sayısı = {5}", s1, s1, s2, s3, s4, a); break;
                }
                Console.WriteLine(s5);

                if (s1.Length == 5 && s1[1] == s2[0] && s1[2] == s3[0] && s1[3] == s4[0] && s1[4] == s5[0])
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Aranan Şehir Bulundu !");
                    Console.WriteLine(@"
Bulunan Şehir {0}

{1}
{2}
{3}
{4}
{5}

Deneme Sayısı = {6}", s1, s1, s2, s3, s4, s5, a); break;

                }
            }
        }
    }
}
