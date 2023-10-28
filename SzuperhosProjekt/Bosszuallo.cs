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
            //if (szuperhos is Batman && (this.szuperero*2) > szuperhos.MekkoraAzEreje())
            //{
            //    return true;
            //}
            //else if (szuperhos.MekkoraAzEreje()>this.Szuperero && szuperhos.)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            if (szuperhos is Bosszuallo)
            {
                return ((Bosszuallo)szuperhos).vanEGyengesege && szuperhos.MekkoraAzEreje() < this.MekkoraAzEreje();
            }
            else
            {
                return szuperhos.MekkoraAzEreje() * 2 <= this.MekkoraAzEreje();
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
