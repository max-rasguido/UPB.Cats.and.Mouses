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
        public Gato(int x, int y, string name)
        {
            Posicionx = x;
            Posiciony = y;
            Name = name;
        }
        public string Name
        {
            get;
            set;
        }
        public int[] GetPos()
        {
            return new int[2]{Posicionx,Posiciony};
        }

        public bool MoveForward(bool Left)
        {
            if (Left && Posiciony < 7)
            {Posiciony++;return true;}
            else if (Posiciony < 7 && Posicionx < 7 && Posicionx > 0)
            { Posicionx++; Posiciony++; return true; }
            else
                return false;
        }
    }
}
