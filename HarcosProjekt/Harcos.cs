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
            if (statuszSablon == 1) { this.alapEletero = 15; this.alapSebzes = 3; }
            else if (statuszSablon == 2) { this.alapEletero = 12; this.alapSebzes = 4; }
            else if (statuszSablon == 3) { this.alapEletero = 8; this.alapSebzes = 5; }
            this.Eletero = MaxEletero;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Tapasztalat { get => tapasztalat; set => tapasztalat = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        public int AlapEletero { get => alapEletero; }
        public int AlapSebzes { get => alapSebzes; }
        public int Sebzes { get => alapSebzes+szint; }
        public int SzintLepeshez{ get => 10+szint*5; }
        public int MaxEletero{ get => alapEletero+(szint*3);  }

        public void megKuzd(Harcos Kihivott)
        {
            bool kihivoTamad = true;
            if (this.nev == Kihivott.nev)
            {
                Console.WriteLine("A két harcos neve megyezik!");
            }
            else if (this.eletero == 0 || Kihivott.eletero == 0)
            {
                Console.WriteLine("A harcos életereje 0!");
            }
            
            else {
                while (this.eletero > 0 && Kihivott.eletero > 0)
                {
                    if (kihivoTamad)
                    {
                        Kihivott.eletero = Kihivott.eletero - this.Sebzes;
                    }
                    else
                    {
                        this.eletero = this.eletero - Kihivott.Sebzes;
                    }
                    kihivoTamad = !kihivoTamad;
                    if (this.eletero != 0)
                    {
                        this.tapasztalat = this.Tapasztalat + 5;
                    }
                    if (Kihivott.eletero != 0)
                    {
                        Kihivott.tapasztalat = Kihivott.Tapasztalat + 5;
                    }
                    if (this.eletero == 0)
                    {
                        Kihivott.tapasztalat = Kihivott.Tapasztalat + 10;
                    }
                    if (Kihivott.eletero != 0)
                    {
                        this.tapasztalat = this.Tapasztalat + 10;
                    }
                }
            }

        }

        public void Gyogyul() 
        {
            if (this.Eletero <= 0)
            {
                this.Eletero = MaxEletero;
            }
            else if (this.Eletero< this.MaxEletero)
            {
                this.Eletero = this.Eletero+(3+szint);
            }
            else if (this.eletero>this.MaxEletero)
            {
                this.eletero = this.MaxEletero;
            }
           


        }
        public override string ToString()
        {
            return String.Format(Nev + "LVL:" + Szint + " EXP:" + Tapasztalat + " HP:" + Eletero + " DMG:" + Sebzes);
        }

        
    }
}
