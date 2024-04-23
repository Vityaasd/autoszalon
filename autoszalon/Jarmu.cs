using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoszalon
{
    public class Jarmu
    {
        public string Gyarto {  get; set; }
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public int AlapAr {  get; set; }
        public int KilometeroraAllas { get; set; }

        public Jarmu(string gyarto, string modell, int evjarat, int alapAr, int kilometeroraAllas)
        {
            Gyarto = gyarto;
            Modell = modell;
            Evjarat = evjarat;
            AlapAr = alapAr;
            KilometeroraAllas = kilometeroraAllas;
        }

        public void JarmuInfo()
        {
            Console.WriteLine($"{Gyarto} {Modell}, Évjárat: {Evjarat}, Alapár: {AlapAr}, Kilométerora állás: {KilometeroraAllas}");
        }

        public virtual int ArKalkulacio()
        {
            return AlapAr - ((DateTime.Now.Year - Evjarat) * 100000);
        }

        public void KmAllasFrissites(int km)
        {
            KilometeroraAllas += km;
        }

        public void KenyelmiExtraBeszerzese(string extra)
        {
            if (extra == "prémium hangrendszer")
            {
                AlapAr += 500000;
            }
            else if (extra == "napfénytető")
            {
                AlapAr += 300000;
            }
        }
    }
}
