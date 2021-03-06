﻿using System;
using System.IO;
using System.Collections.Generic;

namespace HarcosProjekt
{
    class Program
    {
        public static List<Harcos> lista;
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Harcosok.csv");
             lista= new List<Harcos>();
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
            Jatek();
        }
        public static void Jatek()
        {
            Console.WriteLine("Adja meg a harcos nevet:");
            string harnev = Console.ReadLine();
            Console.WriteLine("Adja meg a harcos státuszát(1,2,3):");
            int statusz = int.Parse(Console.ReadLine());
            Harcos felhasznalo = new Harcos(harnev, statusz);
            Console.WriteLine("Az ön harcosainak adatai: " + felhasznalo);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine((i+1)+"."+lista[i]);
            }
            Console.WriteLine("Mit szeretne tenni?");
            Console.WriteLine("a.) Megküzdeni egy harcossal");
            Console.WriteLine("b.) Gyógyulni");
            Console.WriteLine("c.) Kilépni");
            string dontes = "";
            while (!dontes.Equals("c"))
            {
                dontes = Console.ReadLine();
                if (dontes.Equals("a"))
                {
                    Console.WriteLine("Kivel szeretne harcolni?");
                    int valasztott = int.Parse(Console.ReadLine());
                    felhasznalo.megKuzd(lista[valasztott - 1]);
                    if (felhasznalo.Eletero <= 0)
                    {
                        Console.WriteLine("Meghaltál");
                        dontes = "c";
                    }
                    else
                    {
                        Console.WriteLine("Győztél");
                    }
                }
                else if (dontes.Equals("b"))
                {
                    felhasznalo.Gyogyul();
                }
                else if (dontes.Equals("c"))
                { Environment.Exit(0); }
                Console.WriteLine("Az ön harcosainak adatai: " + felhasznalo);
                Console.WriteLine("Mit szeretne tenni?");
                Console.WriteLine("a.) Megküzdeni egy harcossal");
                Console.WriteLine("b.) Gyógyulni");
                Console.WriteLine("c.) Kilépni");
            }
        }

    }
}
