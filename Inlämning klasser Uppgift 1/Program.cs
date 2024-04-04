using System;
namespace Inlämning_klasser_Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilinfo bil1 = new Bilinfo();
            bil1.Märke = "volvo";
            bil1.Färg = "röd";
            bil1.Registreringsnummer = "HEJ123";
            bil1.Modell = "142";
            bil1.Årsmodell = 1984;

            bil1.SkrivBilinfo();
        }
    }
}
/*Övning 1
Skapa en klass som representerar en bil. Förutom märke och modell så lägger du
själv till ytterligare 3 egenskaper som beskriver en bil.
Skriv sedan ett kort exempel där du skapar en ny bil, fyller objektet med data och
sedan skriver ut datan.*/