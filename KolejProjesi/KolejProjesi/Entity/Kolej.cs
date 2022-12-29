using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejProjesi.Entity
{
    internal class Kolej
    {
        public string KolejAd { get; set; }
        public string KolejSahibi { get; set; }
        public decimal KolejUcret { get; set; }
        public int KolejKapasite { get; set; }

        public override string ToString()
        {
            return $"Kolej Adı:{KolejAd}-Kolej Ücreti{KolejUcret}";
        }
    }
}
