﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GatosyRaton
{
    class Raton : Gato
    {
        public Raton(int x, int y):base(x,y)
        {
            Posicionx = x;
            Posiciony = y;
        }

        public bool MoveBackwards(bool Left)
        {
            return MoveForward(Left);
        }

        public bool MoveForwardMouse(bool Left)
        {
            if (Left && Posiciony < 4)
            { Posiciony--; return true; }
            else if (Posiciony < 4 && Posicionx < 4 && Posicionx > 1)
            { Posicionx++; Posiciony++; return true; }
            else
                return false;
        }
    }
}
