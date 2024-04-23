using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoszalon
{
    public class Autosalon
    {
        public List<Jarmu> Jarmuvek = new List<Jarmu>();

        public void UjJarmuHozzaadasa(Jarmu jarmu)
        {
            Jarmuvek.Add(jarmu);
        }

        public bool JarmuEladasa(string gyarto, string modell)
        {
            var jarmu = Jarmuvek.FirstOrDefault(j => j.Gyarto == gyarto && j.Modell == modell);
            if (jarmu != null)
            {
                Jarmuvek.Remove(jarmu);
                return true;
            }
            return false;
        }

        public Jarmu Jarmukeresese(string gyarto, string modell)
        {
            return Jarmuvek.FirstOrDefault(j => j.Gyarto == gyarto && j.Modell == modell);
        }

        public void JarmuvekListazasa()
        {
            foreach(var jarmu in Jarmuvek)
            {
                jarmu.JarmuInfo();
            }
        }
    }
}
