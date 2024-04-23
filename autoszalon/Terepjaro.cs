using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoszalon
{
    public class Terepjaro : Jarmu
    {
        public string Hajtas {  get; set; }
        public bool OffroadKepessegek {  get; set; }
        public int Vontatoképességek {  get; set; }

        public Terepjaro(string gyarto, string modell, int evjarat, int alapAr, int kilometeroraAllas, string hajtas, bool offroadKepessegek, int vontatokepessegek)
            : base(gyarto, modell, evjarat, alapAr, kilometeroraAllas)
        {
            Hajtas = hajtas;
            OffroadKepessegek = offroadKepessegek;
            Vontatoképességek = vontatokepessegek;
        }

        public void OffroadCsomagFelszerelés()
        {
            if (!OffroadKepessegek)
            {
                AlapAr += 1000000;
                OffroadKepessegek = true;
            }
        }

        public void VontatasiKepessegekBeallitasa(int kepessegek)
        { 
            Vontatoképességek = kepessegek;
        }
    }
}
