using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek
{
    internal class Dolgozok
    {
        public string nev { get; set; }
        public string neme { get; set; }
        public string reszleg { get; set; }
        public int belepes { get; set; }
        public int ber {  get; set; }

        public override string ToString() =>
            $"Név: {nev}\n" +
            $"Nem: {neme}\n" +
            $"Belépés: {belepes}\n" +
            $"Bér: {ber} Forint";
        public Dolgozok(string sor)
        {
            string[] v = sor.Split(';');
            nev = v[0];
            neme = v[1];
            reszleg = v[2];
            belepes = int.Parse(v[3]);
            ber = int.Parse(v[4]);
        }
        }
}
