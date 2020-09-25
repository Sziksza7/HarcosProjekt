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

        public Harcos(string nev, int statuszSablon)
        {
            this.Nev = nev;
            this.Szint = 1;
            this.Tapasztalat = 0;
            this.Eletero = MaxEletero;
            if (statuszSablon == 1) { this.alapEletero = 15; this.alapSebzes = 3; }
            else if (statuszSablon == 2) { this.alapEletero = 12; this.alapSebzes = 4; }
            else if (statuszSablon == 3) { this.alapEletero = 8; this.alapSebzes = 5; }
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Sebzes { get => alapSebzes+szint; }
        public int SzintLepeshez{ get => 10+szint*5; }
        public int MaxEletero{ get => alapEletero+szint*3;  }

        public void ToString() { }
        public void Gyogyul() { }
        public void Megkuzd() { }
        
    }
}
