using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GlsautoConsole
{
    internal class Program
    {
        static List<AutoAdatok> adatok = new List<AutoAdatok>();
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("GLS.txt");

            while (!sr.EndOfStream)
            { 
                adatok.Add(new AutoAdatok(sr.ReadLine()));
               
            }
            sr.Close();

            //Feladat 2
            int ossz = 0;
            foreach(var item in adatok)
            {
                ossz++;
            }
            Console.WriteLine("Az autó használatban töltött napjainak száma: "+ossz);

            //Feladat 3

            foreach(var item in adatok)
            {
                
            }


            //Feladat 4
            int km = 0;
            foreach(var item in adatok)
            {
                km += item.kilometer;
            }
            Console.WriteLine("Az összes megtett kilométer: "+km);

            //Feladat 6

            int AtlagFogyasztas()
            {
                int osszFogyasztas = 0;
                foreach(var item in adatok)
                {
                    osszFogyasztas += item.fogyasztas;
                }

                if(osszFogyasztas < 0)
                {
                    Console.WriteLine("Hiba történt az adatok beolvasása során");
                }
                return (osszFogyasztas * 100) / km;
                
            }
            Console.WriteLine("Atlagfogyasztas:" +AtlagFogyasztas() + "L/100km");

            


        }
    }
}
