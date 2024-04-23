using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoszalon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Autosalon autosalon = new Autosalon();

            autosalon.UjJarmuHozzaadasa(new Szemelyauto("Toyota", "Corolla", 2021, 8000000, 15000, 5, 6.5, "Fehér"));
            autosalon.UjJarmuHozzaadasa(new Terepjaro("Land Rover", "Defender", 2020, 15000000, 2000, "4WD", true, 3500));
            
            autosalon.JarmuvekListazasa();
            if (autosalon.JarmuEladasa("Toyota", "Corolla"))
            {
                Console.WriteLine("A jármű sikeresen eladva.");
            }
            else
            {
                Console.WriteLine("A járműt már eladták.");
            }
            autosalon.Jarmukeresese("Land Rover", "Defender").JarmuInfo();
        }
    }
}
