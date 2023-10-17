using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_de_matrices_bidimencionales_DGGR
{
    public class Ejercicios
    {
        public void Ejercicio1()
        {
            int[,] ejercicio1 = new int[,]
            { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int f = 0; f < ejercicio1.GetLength(0); f++)
            {
                Console.WriteLine($"Elemento de la fila {f}");
                for (int c = 0; c < ejercicio1.GetLength(1); c++)
                {
                    Console.Write(ejercicio1[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Ejercicio2()
        {
            string[,] ejercicio2 = new string[,]
            { { "Rojo", "verde" }, { "Azul", "Amarillo" } };

            for (int f = 0; f < ejercicio2.GetLength(0); f++)
            {
                Console.WriteLine($"Elemento de fila {f}");
                for (int c = 0; c < ejercicio2.GetLength(1); c++)
                {
                    Console.Write(ejercicio2[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void  Ejercicio3()
        {
            double[,] ejercicio3 = new double[,] 
            { { 1.1, 1.2, 1.3 }, { 1.4, 1.5, 1.6 }, { 1.7, 1.8, 1.9 }, { 2.1, 2.2, 2.3 } };

            double suma = 0;

            for (int f = 0; f < ejercicio3.GetLength(0); f++)
            {
                for (int c = 0; c< ejercicio3.GetLength(1); c++)
                {
                    suma += ejercicio3[f, c];
                }
            }
            Console.WriteLine("La suma de todos los numeros es: " + suma);
        }

        public void Ejercicio4 ()
        {
            String [,] ejercicio4 = new string[,] { { "A", "B", "C" }, { "D", "E","F" } };

            for (int f = 0; f < ejercicio4.GetLength(0); f++)
            {
                for (int c = 0; c < ejercicio4.GetLength(1); c++)
                {
                    Console.Write(ejercicio4[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
