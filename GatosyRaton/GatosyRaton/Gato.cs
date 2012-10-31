using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GatosyRaton
{
    //macaneando
    class Gato
    {
        public int Posicionx
        {
            get;
            set;
        }
        public int Posiciony
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public Gato(int x, int y, string name)
        {
            Posicionx = x;
            Posiciony = y;
            Name = name;
        }

        public Gato(int x, int y)
        {
            Posicionx = x;
            Posiciony = y;
            Name = "Raton";
        }
        public int[] GetPos()
        {
            return new int[2]{Posicionx,Posiciony};
        }

        public bool MoveForward(bool Left)
        {
            if (Left && Posiciony < 8)
            {Posiciony++;return true;}
            else if (Posiciony < 8 && Posicionx < 4 && Posicionx > 1)
            { Posicionx++; Posiciony++; return true; }
            else
                return false;
        }

        public int[,] WritePos(int[,] posmat)
        {
            if (Name != "Raton")
                posmat[Posicionx, Posiciony] = 1;
            else
                posmat[Posicionx, Posiciony] = 2;
            return posmat;
        }
    }
}
