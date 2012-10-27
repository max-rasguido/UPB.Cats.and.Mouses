using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GatosyRaton
{
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
        void Gato(int x, int y)
        {
            Posicionx = x;
            Posiciony = y;
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
    }
}
