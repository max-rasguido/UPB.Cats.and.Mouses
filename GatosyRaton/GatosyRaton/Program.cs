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
            Gato gato1 = new Gato(0, 0,"Felix");
            Gato gato2 = new Gato(2, 0,"Pepe");
            Gato gato3 = new Gato(4, 0,"Jose");
            Gato gato4 = new Gato(6, 0,"Garfield");
            Raton raton = new Raton(1, 7);
            PrintMat(matriz);
            matriz = gato1.WritePos(matriz);
            PrintMat(matriz);
            matriz = gato2.WritePos(matriz);
            PrintMat(matriz);
            matriz = gato3.WritePos(matriz);
            PrintMat(matriz);
            matriz = gato4.WritePos(matriz);
            PrintMat(matriz);
            matriz = raton.WritePos(matriz);
            PrintMat(matriz);
        }

        static void PrintMat(int[,] matrix)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(matrix[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
