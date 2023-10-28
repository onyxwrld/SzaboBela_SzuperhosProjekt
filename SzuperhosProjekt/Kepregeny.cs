using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public static class Kepregeny
    {
        public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();
        public static void Szereplok(string file)
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] s = sor.Split(' ');
                if (s[0] == "Batman")
                {
                    Batman batman = new Batman();
                    for (int i = 0; i < Convert.ToInt32(s[1]); i++)
                    {
                        batman.KutyutKeszit();
                    }
                    szuperhosok.Add(batman);
                }
                else if (s[0] =="Vasember")
                {
                    Vasember vasember = new Vasember();
                    for (int i = 0; i < Convert.ToInt32(s[1]); i++)
                    {
                        vasember.KutyutKeszit();
                    }
                    szuperhosok.Add(vasember);
                }
            }
        }
        public static void Szuperhosok()
        {
            foreach (var item in szuperhosok)
            {
                Console.WriteLine(item);
            }
        }
    }
}
