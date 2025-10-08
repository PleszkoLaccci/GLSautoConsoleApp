using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlsautoConsole
{
    internal class AutoAdatok
    {
        string datum { get; set; }
        string sofornev { get; set; }
        int kilometer { get; set; }
        int csomagszam { get; set; }
        int fogyasztas { get; set; }

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

        public override string ToString()
        {
            return $"{datum} {sofornev} {kilometer} {csomagszam} {fogyasztas}";
        }
    }
}
