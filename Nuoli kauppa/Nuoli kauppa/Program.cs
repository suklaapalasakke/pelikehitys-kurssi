namespace Nuoli_kauppa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minkälainen kärki (Puu, Teräs, Timantti)?");
            string karkiInput = Console.ReadLine();
            KarkiTyyppi karki = Enum.Parse<KarkiTyyppi>(karkiInput);

            Console.WriteLine("Minkälaiset sulat (Lehti, KananSulka, KotkanSulka)?");
            string peraInput = Console.ReadLine();
            PeraTyyppi pera = Enum.Parse<PeraTyyppi>(peraInput);

            Console.WriteLine("Nuolen pituus sentteinä (60-100)?");
            double pituus = Convert.ToDouble(Console.ReadLine());

            Nuoli nuoli = new Nuoli(karki, pera, pituus);

            double hinta = nuoli.PalautaHinta();

            Console.WriteLine("Tämän nuolen hinta on " + hinta + " kultarahaa.");

            Console.ReadLine();
        }
    }
}
