using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GatosyRaton
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(matriz[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
