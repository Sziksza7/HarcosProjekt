using System;
using System.IO;
using System.Collections.Generic;

namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Harcosok.csv");
            List<Harcos> lista = new List<Harcos>();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] splitsor = sor.Split(";");
                Harcos j = new Harcos(splitsor[0], int.Parse(splitsor[1]));
                lista.Add(j);
            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine( lista[i]);
            }
        }
    }
}
