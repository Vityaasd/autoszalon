using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoszalon
{
    public class Szemelyauto : Jarmu
    {
        public int UlesekSzama { get; set; }
        public double Fogyasztas { get; set; }
        public string Szin { get; set; }

        public Szemelyauto(string gyarto, string modell, int evjarat, int alapAr, int kmAllas, int ulesekSzama, double fogyasztas, string szin)
            : base (gyarto, modell, evjarat, alapAr, kmAllas)
        {
            UlesekSzama = ulesekSzama;
            Fogyasztas = fogyasztas;
            Szin = szin;
        }

        public void SzinFrissitese(string ujSzin)
        {
            Szin = ujSzin;
        }
    }
}
