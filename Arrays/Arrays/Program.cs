using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type[] nombreArreglo;

            int[] _array = new int[5]; //inicializar arreglo y declarar cuantos elementos puede contener
            
            int[] _array2 = new int[] {99,88,12,33,55}; //arreglo de 5 elementos
            /*
             Matriz Unidimencional
            [0] = 99
            [1] = 88
            [2] = 12
            [3] = 33
            [4] = 55
            */
            for (int i = 0; i < _array2.Length; i++)
            {
                Console.WriteLine(_array2[i]);
            }


            /* Matriz multimencional
                  [0]   [1]  [2]
            [0] = 99    12   21
            [1] = 88    21   30
            [2] = 12    45   40
            [3] = 33    66   99
            [4] = 55    22   77
             */
            int[,] _multidimensionalArray1 = new int[2, 3];

            int[,] _multidimensionalArray2 =
            {
                {1,2,3},
                {4,5,6},
            };

            string[,] _multidimensionalArray3 ={
                {"Nombre" , "Apellido" },
                {"Manuel" , "Aldana" },
              //  {"Aida" , "Perdomo" },

            };

            for(int i = 0; i < _multidimensionalArray3.Length; i++)
            {
                for(int j = 0; j < _multidimensionalArray3.Length; j++)
                {
                    Console.WriteLine(i , j,);
                }
            }

            Console.Read();
        }
    }
}
