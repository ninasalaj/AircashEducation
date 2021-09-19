using System;
using System.IO;

namespace ConsoleAppAbon
{
    class Program
    {
        static void Main(string[] args)
        {
            //var abon = new Abon();

            //1. dovrošiti klasu A-bon
            //2. učitati datoteku a-bon.json u varijablu abonContent.
            //3. deserijalizirati sadržaj datoteke A-bon u objekt klase A-bon
            // var abon = JsonConvert.DeserializeObject<Abon>(abonContent)
            //4. prikazati A-bon na ekran (kao na slici)

            string json = File.ReadAllText(@"D:\json\bon3.txt");
            var abon =Newtonsoft.Json.JsonConvert.DeserializeObject<Abon>(json);
            Console.SetCursorPosition((Console.WindowWidth - 30) / 2, Console.CursorTop);
            Console.WriteLine("Datum/Vrijeme: {0:g}", abon.HeaderData.Date);
            Console.SetCursorPosition((Console.WindowWidth - (9 + abon.HeaderData.Shop.Length)) / 2, Console.CursorTop);
            Console.WriteLine("Trgovac: {0}", abon.HeaderData.Shop);
            Console.SetCursorPosition((Console.WindowWidth - (16+abon.HeaderData.Location.Length)) / 2, Console.CursorTop);
            Console.WriteLine("Prodajno mjesto: {0}", abon.HeaderData.Location);
            Console.WriteLine();
            Console.SetCursorPosition((Console.WindowWidth - 12) / 2, Console.CursorTop);
            Console.WriteLine("Iznos a-bona");
            Console.SetCursorPosition((Console.WindowWidth - 8) / 2, Console.CursorTop);
            Console.WriteLine("{0}kn",abon.Amount);
            Console.SetCursorPosition((Console.WindowWidth - 18) / 2, Console.CursorTop);
            Console.WriteLine("16-znamenkasti kod");
            Console.SetCursorPosition((Console.WindowWidth - 16) / 2, Console.CursorTop);
            Console.WriteLine(abon.CouponCode);
            Console.WriteLine("Upute za korištenje:");
            foreach (var i in abon.InstructionsForUse)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nPodaci o bonu:");
            Console.WriteLine("Serijski broj bona: {0}",abon.SerialNumber);
            Console.WriteLine("Trajanje neiskoristenog bona: {0:d}", abon.ExpirationDate);
            Console.WriteLine("\nDodatni podaci");
            foreach (var i in abon.AdditionalInformation)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nNapomene:");
            foreach (var i in abon.Warning)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nKontakt:");
            Console.WriteLine("E-mail: {0}",abon.Contact.Email);
            Console.WriteLine("Tel: {0}", abon.Contact.PhoneNumber);
        }
    }
}
