using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion13
{
    class ClsArregloSimple
    {
      public void mostraArreglo()
        {
            //arreglos
            int[] Arreglo = new int[7];
            int i;
            //mostras lo que yo digite
            string cadena;
            for (i = 0; i < 7; i++)
            {
                cadena = Console.ReadLine();
                Arreglo[i] = Convert.ToInt32(cadena);
            }

            //mostrar contenido del arreglo
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine("El valor es: {0}", Arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
