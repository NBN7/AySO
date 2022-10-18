using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AySO_Matriz
{
    class ClsUtilities
    {
        public static void mostrarTabla(String[,] matrizProcesos)
        {
            String[] letras = { "A", "B", "C", "D", "E" };

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 22; j++)
                {
                    if (j > 10)
                    {
                        matrizProcesos[i, j] = "  ";
                    }
                    else
                    {
                        matrizProcesos[i, j] = " ";
                    }
                }
            }

            for (int i = 0; i < letras.Length; i++)
            {
                matrizProcesos[i + 1, 0] = letras[i];
            }

            for (int i = 0; i < 21; i++)
            {
                matrizProcesos[0, i + 1] = i.ToString();
            }

            for (int i = 0; i < 6; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 22; j++)
                {
                    Console.Write("[{0}]", matrizProcesos[i, j]);
                }
            }
        }
    }
}
