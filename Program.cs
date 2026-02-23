using System;

namespace Ovi
{
    internal class Program
    {
        enum OvenTila
        {
            Auki,
            Kiinni,
            Lukossa
        }

        enum Toiminto
        {
            Avaa,
            Sulje,
            Lukitse,
            AvaaLukko
        }

        static void Main(string[] args)
        {
            OvenTila ovenTila = OvenTila.Auki;

            while (true)
            {
                Console.WriteLine($"\nOvi on {ovenTila.ToString().ToLower()}.");
                Console.WriteLine("Mitä haluat tehdä?");

                foreach (var t in Enum.GetNames<Toiminto>())
                {
                    Console.WriteLine($"- {t}");
                }

                string vastaus = Console.ReadLine();

                if (!Enum.TryParse<Toiminto>(vastaus, true, out Toiminto toiminto))
                {
                    Console.WriteLine("Virheellinen toiminto.");
                    continue;
                }

                bool onnistui = false;

                switch (ovenTila)
                {
                    case OvenTila.Auki:
                        if (toiminto == Toiminto.Sulje)
                        {
                            ovenTila = OvenTila.Kiinni;
                            onnistui = true;
                        }
                        break;

                    case OvenTila.Kiinni:
                        if (toiminto == Toiminto.Avaa)
                        {
                            ovenTila = OvenTila.Auki;
                            onnistui = true;
                        }
                        else if (toiminto == Toiminto.Lukitse)
                        {
                            ovenTila = OvenTila.Lukossa;
                            onnistui = true;
                        }
                        break;

                    case OvenTila.Lukossa:
                        if (toiminto == Toiminto.AvaaLukko)
                        {
                            ovenTila = OvenTila.Kiinni;
                            onnistui = true;
                        }
                        break;
                }

                if (onnistui)
                {
                    Console.WriteLine("Toiminto onnistui.");
                }
                else
                {
                    Console.WriteLine("Toiminto ei ole mahdollinen tässä tilassa.");
                }
            }
        }
    }
}
