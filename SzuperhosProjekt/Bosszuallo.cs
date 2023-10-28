using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.Szuperero = szuperero;
            this.VanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }
        public abstract bool MegmentiAVilagot();

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos is Batman && (this.szuperero*2) > szuperhos.MekkoraAzEreje())
            {
                return false;
            }
            else if (vanEGyengesege && szuperhos.MekkoraAzEreje()>this.Szuperero)
            {
                return true;
            }
            else
            {
                return true;
            }
        }

        public double MekkoraAzEreje()
        {
            return szuperero;
        }
        public override string ToString()
        {
            if (this.VanEGyengesege)
            {
                return $"Szupererő: {this.szuperero}; van gyengesége";
            }
            else
            {
                return $"Szupererő: {this.szuperero}; nincs gyengesége";
            }
        }
    }
}
