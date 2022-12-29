using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolejProjesi.Entity
{
    internal class KolejListesi
    {
        private static List<Kolej> _kolej = new List<Kolej>();

        public void Add(Kolej kolej)
        {
            _kolej.Add(kolej);
        }

        public List<Kolej> GetAll()
        {
            return _kolej;
        }

        public void Remove(Kolej kitap)
        {
            _kolej.Remove(kitap);
        }
    }
}
