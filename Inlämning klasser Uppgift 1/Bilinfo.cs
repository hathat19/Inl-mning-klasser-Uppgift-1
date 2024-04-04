using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_klasser_Uppgift_1
{
    internal class Bilinfo
    {
        string märke;
        string modell;
        int årsmodell;
        string färg;
        string registreringsnummer;

        //Egenskaper
        public string Märke
        {
            get
            {
                return märke;
            }
            set
            {
                märke = value;
            }
        }
        public string Modell
        {
            get
            {
                return modell;
            }
            set
            {
                modell = value;
            }
        }
        public int Årsmodell
        {
            get
            {
                return årsmodell;
            }
            set
            {
                årsmodell = value;
            }
        }
        public string Färg
        {
            get
            {
                return färg;
            }
            set
            {
                färg = value;
            }
        }
        public string Registreringsnummer
        {
            get
            {
                return registreringsnummer;
            }
            set
            {
                registreringsnummer = value;
            }
        }

        public void SkrivBilinfo()
        {
            Console.WriteLine($"Din bil är en {märke} {modell} från {årsmodell}. Den är {färg} och har registeringsnumret {registreringsnummer}.");
        } 

    }
}
/*Övning 1
Skapa en klass som representerar en bil. Förutom märke och modell så lägger du
själv till ytterligare 3 egenskaper som beskriver en bil.
Skriv sedan ett kort exempel där du skapar en ny bil, fyller objektet med data och
sedan skriver ut datan.*/
