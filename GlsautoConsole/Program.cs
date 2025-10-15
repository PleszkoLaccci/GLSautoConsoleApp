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
            //elso megoldas nehezebb 
            List<string> nevek = new List<string>();
            for (int j = 0; j < adatok.Count; j++) 
            {
                bool van = false;

                for(int i = 0; i < nevek.Count; i++)
                {
                    if (adatok[j].sofornev == nevek[i])
                    {
                        van = true;
                    }
                }
                if (van == false)
                {
                    nevek.Add(adatok[j].sofornev);
                    Console.Write(adatok[j].sofornev + ", ");
                }
            }

            //Feladat 3 masik megoldas konnyebb 
            foreach (var item in adatok)
            {
                if (!nevek.Contains(item.sofornev))
                {
                    nevek.Add(item.sofornev);
                }
            }
            Console.WriteLine("A különböző sofőrök száma: " + nevek.Count);

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


            //Feladat 7


            List<string> legtobbetvezetosofor = new List<string>();
            int napok = 0;
            foreach (var item in adatok) {
                if (item.kilometer == adatok.Max(x => x.kilometer))
                {
                    legtobbetvezetosofor.Add(item.sofornev);

                }
             
            }
            foreach(var item in adatok)
            {
                if(legtobbetvezetosofor.Contains(item.sofornev))
                {
                    napok++;
                }
            }
            Console.WriteLine($"A legtöbbet vezető sofőr: " + string.Join(" , ", legtobbetvezetosofor) + ", " + "napok száma: " + napok);

        }
    }
}
