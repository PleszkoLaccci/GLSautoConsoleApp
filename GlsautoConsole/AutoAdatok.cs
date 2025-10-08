using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlsautoConsole
{
    internal class AutoAdatok
    {
        public string datum { get; set; }
        public string sofornev { get; set; }
        public int kilometer { get; set; }
        public int csomagszam { get; set; }
        public int fogyasztas { get; set; }

        public AutoAdatok(string datum, string sofornev, int kilometer, int csomagszam, int fogyasztas)
        {
            this.datum = datum;
            this.sofornev = sofornev;
            this.kilometer = kilometer;
            this.csomagszam = csomagszam;
            this.fogyasztas = fogyasztas;
        }
        public AutoAdatok(string sor)
        {
            string[] sorSplit = sor.Split(';');
            this.datum = sorSplit[0];
            this.sofornev = sorSplit[1];
            this.kilometer = int.Parse(sorSplit[2]);
            this.csomagszam = int.Parse(sorSplit[3]);
            this.fogyasztas = int.Parse(sorSplit[4]);
        }

        
    }
}
