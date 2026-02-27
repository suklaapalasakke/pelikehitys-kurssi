using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuoli_kauppa
{
    public enum KarkiTyyppi
    {
        Puu,
        Teras,
        Timantti
    }

    public enum PeraTyyppi
    {
        Lehti,
        KananSulka,
        KotkanSulka
    }

    public class Nuoli
    {
        public KarkiTyyppi karki;
        public PeraTyyppi pera;
        public double pituus;

        public Nuoli(KarkiTyyppi k, PeraTyyppi p, double pit)
        {
            karki = k;
            pera = p;
            pituus = pit;
        }

        public double PalautaHinta()
        {
            double hinta = 0;

            // Kärjen hinta
            if (karki == KarkiTyyppi.Puu)
            {
                hinta = hinta + 3;
            }
            else if (karki == KarkiTyyppi.Teras)
            {
                hinta = hinta + 5;
            }
            else if (karki == KarkiTyyppi.Timantti)
            {
                hinta = hinta + 50;
            }

            // Perän hinta
            if (pera == PeraTyyppi.Lehti)
            {
                hinta = hinta + 0;
            }
            else if (pera == PeraTyyppi.KananSulka)
            {
                hinta = hinta + 1;
            }
            else if (pera == PeraTyyppi.KotkanSulka)
            {
                hinta = hinta + 5;
            }

            // Varren hinta
            hinta = hinta + (pituus * 0.05);

            return hinta;
        }
    }
}
