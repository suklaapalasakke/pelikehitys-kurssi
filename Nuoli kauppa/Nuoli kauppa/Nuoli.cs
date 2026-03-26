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
        Teräs,
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
        private KarkiTyyppi karki;
        private PeraTyyppi pera;
        private double pituus;

        public Nuoli(KarkiTyyppi k, PeraTyyppi p, double pit)
        {
            karki = k;
            pera = p;
            pituus = pit;
        }

        public KarkiTyyppi GetKarki()
        {
            return karki;
        }

        public PeraTyyppi GetPera()
        {
            return pera;
        }

        public double GetPituus()
        {
            return pituus;
        }

        public double PalautaHinta()
        {
            double hinta = 0;

            if (karki == KarkiTyyppi.Puu)
                hinta += 3;
            else if (karki == KarkiTyyppi.Teräs)
                hinta += 5;
            else if (karki == KarkiTyyppi.Timantti)
                hinta += 50;

            if (pera == PeraTyyppi.Lehti)
                hinta += 0;
            else if (pera == PeraTyyppi.KananSulka)
                hinta += 1;
            else if (pera == PeraTyyppi.KotkanSulka)
                hinta += 5;

            hinta += pituus * 0.05;

            return hinta;
        }
    }
}
