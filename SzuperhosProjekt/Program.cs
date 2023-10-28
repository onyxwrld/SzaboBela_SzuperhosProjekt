using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                string path = "C:\\Users\\B3CI\\Source\\Repos\\SzaboBela_SzuperhosProjekt\\TestSzuperhosProjekt\\szuperhos.txt";
                Kepregeny.Szereplok(path);
            }
            catch (IOException e)
            {
                Console.WriteLine("Hiba történt az IO művelet során: " + e.Message);
            }
            Kepregeny.Szuperhosok();
            Console.ReadKey();
        }
    }
}
