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

        public void Megkuzd(Harcos egy,Harcos ketto) 
        {
            if (egy == ketto) { Console.WriteLine("Hiba, kétszer adta meg ugyanazt a harcost");}
            else if (egy.Eletero==0 && ketto.Eletero==0)
            {
                Console.WriteLine("Az egyeik harcos halott");
            }
            else
            {
                do
                {
                    ketto.Eletero = ketto.Eletero - egy.Sebzes;
                    if (ketto.Eletero != 0)
                    {
                        egy.Eletero = egy.Eletero - ketto.Sebzes;
                        ketto.Tapasztalat = ketto.Tapasztalat + 5;
                    }
                    else if(ketto.Eletero ==0 ) 
                    {
                        egy.tapasztalat = egy.Tapasztalat + 15;
                    }
                    if (egy.Eletero != 0)
                    {
                        egy.Tapasztalat = egy.Tapasztalat + 5;
                    }
                    else if (egy.Eletero == 0)
                    {
                        ketto.tapasztalat = ketto.Tapasztalat + 15;
                    }
                } while (egy.Eletero != 0 && ketto.Eletero != 0);       
            }
        }

        public void Gyogyul(Harcos egy, Harcos ketto) 
        {
            if (egy.Eletero == 0)
            {
                egy.Eletero = MaxEletero;
            }
            else
            {
                egy.Eletero = egy.Eletero+(3+szint);
            }
            if (ketto.Eletero == 0)
            {
                ketto.Eletero = MaxEletero;
            }
            else
            {
                ketto.Eletero = ketto.Eletero + (3 + szint);
            }


        }
        public override string ToString()
        {
            return String.Format(Nev + "LVL:" + Szint + " EXP:" + Tapasztalat + " HP:" + Eletero + " DMG:" + Sebzes);
        }
    }
}
