using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ateria
{
    internal class Ateria
    {
        public Pääraakaaine paaraaka_aine;
        public Lisuke lisuke;
        public Kastike kastike;

        public void Tulosta()
        {
            Console.WriteLine($"Ateria on {paaraaka_aine}, {lisuke} ja {kastike}");
        }
    }
}
