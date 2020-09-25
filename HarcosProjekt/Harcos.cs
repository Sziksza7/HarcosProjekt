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
            this.nev = nev;
            this.szint = szint;
            this.tapasztalat = tapasztalat;
            this.eletero = eletero;
            this.alapEletero = alapEletero;
            this.alapSebzes = alapSebzes;
        }
    }
}
