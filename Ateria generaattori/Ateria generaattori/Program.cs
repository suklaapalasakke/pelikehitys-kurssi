namespace ateria
{
    enum Pääraakaaine
    {
        Nautaa,
        Kanaa,
        Kasviksia
    }

    enum Lisuke
    {
        Perunaa,
        Riisiä,
        Pastaa
    }

    enum Kastike
    {
        Curry,
        Hapanimela,
        Pippuri,
        Chili

    }

   internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ravintolaan!");

            Ateria tilaus = new Ateria();

            while (true)
            {
                Console.WriteLine("Valitse pääraaka-aine");
                string[] aineet = Enum.GetNames<Pääraakaaine>();
                for (int i = 0; i < aineet.Length; i++)
                {
                    Console.WriteLine(aineet[i]);
                }

                string valinta = Console.ReadLine();

                Pääraakaaine päävalinta;
                bool Onnistui = Enum.TryParse<Pääraakaaine>(valinta, out päävalinta);
                if (Onnistui)
                {
                    tilaus.paaraaka_aine = päävalinta; break;
                }
                else
                {
                    Console.WriteLine("Ei ole tälläistä pääraaka-ainetta");
                }
            }
            while (true)
            {
                Console.WriteLine("Valitse lisuke");
                string[] aineet = Enum.GetNames<Lisuke>();
                for (int i = 0; i < aineet.Length; i++)
                {
                    Console.WriteLine(aineet[i]);
                }

                string valinta = Console.ReadLine();

                Lisuke lisukevalinta;
                bool Onnistui = Enum.TryParse<Lisuke>(valinta, out lisukevalinta);
                if (Onnistui)
                {
                    tilaus.lisuke = lisukevalinta; break;
                }
                else
                {
                    Console.WriteLine("Ei ole tälläistä lisuketta.");
                }
            }
            while (true)
            {
                Console.WriteLine("Valitse Kastike");
                string[] aineet = Enum.GetNames<Kastike>();
                for (int i = 0; i < aineet.Length; i++)
                {
                    Console.WriteLine(aineet[i]);
                }

                string valinta = Console.ReadLine();

                Kastike Kastikevalinta;
                bool Onnistui = Enum.TryParse<Kastike>(valinta, out Kastikevalinta);
                if (Onnistui)
                {
                    tilaus.kastike = Kastikevalinta; break;
                }
                else
                {
                    Console.WriteLine("Ei ole tälläistä kastiketta.");
                }

            }
                tilaus.Tulosta();
        }
    }
}