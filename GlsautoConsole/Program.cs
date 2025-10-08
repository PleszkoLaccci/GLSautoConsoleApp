using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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


        }
    }
}
