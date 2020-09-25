using System;
using System.Collections.Generic;
using System.Text;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public Harcos(string nev, int szint, int tapasztalat, int eletero, int alapEletero, int alapSebzes)
        {
            this.Nev = nev;
            this.Szint = szint;
            this.Tapasztalat = tapasztalat;
            this.Eletero = eletero;
            this.AlapEletero = alapEletero;
            this.AlapSebzes = alapSebzes;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; set => alapEletero = value; }
        public int AlapSebzes { get => alapSebzes; set => alapSebzes = value; }
        public int Sebzes { get => Sebzes; set => Sebzes = alapSebzes*szint; }
        public int SzintLepeshez{ get => SzintLepeshez; set => SzintLepeshez = 10+(szint*5); }
        public int MaxEletero{ get => MaxEletero; set => MaxEletero = AlapEletero+(szint*3); }
    }
}
