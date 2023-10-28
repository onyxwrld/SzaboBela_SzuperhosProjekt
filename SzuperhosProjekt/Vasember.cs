using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        private Random RND;
        public Vasember() : base(150, true)
        {

        }

        public void KutyutKeszit()
        {
            RND = new Random();
            this.Szuperero += RND.NextDouble()*9+1;
        }

        public override bool MegmentiAVilagot()
        {
            if (this.Szuperero>1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            if (this.VanEGyengesege)
            {
                return $"Vasember: Szupererő: {this.Szuperero}; van gyengesége";
            }
            else
            {
                return $"Vasember: Szupererő: {this.Szuperero}; nincs gyengesége";
            }
        }
    }
}
