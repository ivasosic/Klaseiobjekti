using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseIObjekti
{
    internal class Zrakoplov
    {
        string naziv;
        int snagamotora, dosegleta;

        public string Naziv1 { get => naziv; set => naziv = value; }
        public int SnagaMotora1 { get => snagamotora; set => snagamotora = value; }
        public int DosegLeta1 { get => dosegleta; set => dosegleta = value; }

        public Zrakoplov(String Naziv, int SnagaMotora, int DosegLeta)
        {
            this.naziv = naziv;
            this.snagamotora=snagamotora;
            this.dosegleta=dosegleta;

        }
        public Zrakoplov(){ }


        public override string ToString()
        {
            string ispis = "Naziv: " + this.Naziv1 + "\n"
                + "Snaga motora: " + this.SnagaMotora1 + " kW\n"
                + "Doseg leta: " + this.DosegLeta1 + " km\n";
            return ispis;
        }
    }
}
