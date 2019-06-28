using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion13
{
    class ClsMatrices : ClsArregloSimple
    {

        //constructor
        public ClsMatrices()
        {
            Matriz = new int[5, 4];
        }

        //crear arreglo
        int[,] Matriz;

        //metodo para inicializar la matriz
        public void inicializarMatriz()
        {
            //5 columnas
            for (int i = 0; i < 5; i++)
            {
                //4 filas
                for (int j = 0;  j< 4;  j++)
                {
                    Matriz[i, j] = 1;
                }
            }
        }

        public void mostrarMatriz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}", Matriz[i,j]);
                }
                //su funcion seria como un separador
                Console.WriteLine();
                //fin
            }

            Console.ReadKey();
        }
    }
}
