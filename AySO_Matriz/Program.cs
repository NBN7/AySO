using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AySO_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int tlA, teA, tlB, teB, tlC, teC, tlD, teD, tlE, teE;
            String[,] matrizProcesos = new String[6, 30];

            ClsUtilities.mostrarTabla(matrizProcesos);
            Console.Clear();

            tlA = 0;
            teA = 3;

            tlB = 2;
            teB = 6;

            tlC = 4;
            teC = 4;

            tlD = 6;
            teD = 5;

            tlE = 8;
            teE = 2;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (i > 1)
                    {
                        matrizProcesos[2, tlB+1] = "i";
                        matrizProcesos[2, teA+teB+2] = "t";

                        matrizProcesos[3, tlC + 1] = "i";
                        matrizProcesos[3, teA + teB + teC + 2] = "t";

                        matrizProcesos[4, tlD + 1] = "i";
                        matrizProcesos[4, teA + teB + teC + teD + 2] = "t";

                        matrizProcesos[5, tlE + 1] = "i";
                        matrizProcesos[5, teA + teB + teC + teD + teE + 2] = "t";

                        if (matrizProcesos[1,tlB+i] == "x")
                        {
                            for (int k = 0; k < teB-1; k++)
                            {
                                matrizProcesos[2, tlB + k] = "e";                               
                            }                           
                        }
                        else
                        {
                            for (int k = teA + 1; k <= teA + teB; k++)
                            {
                                matrizProcesos[2, k+1] = "x";
                            }
                        }

                        if (matrizProcesos[2, tlB + tlC + i] == "x")
                        {
                            for (int k = 0; k < teB + teC - 1; k++)
                            {
                                matrizProcesos[3, tlB + tlC + k] = "e";
                            }
                        }
                        else
                        {
                            for (int k = teA + teB + 1; k <= teA + teB + teC; k++)
                            {
                                matrizProcesos[3, k + 1] = "x";
                            }
                        }

                        if (matrizProcesos[3, tlB + tlC + tlD + i] == "x")
                        {
                            for (int k = 0; k < teB + teC + teD - 1; k++)
                            {
                                matrizProcesos[4, tlB + tlC + tlD + k] = "e";
                            }
                        }
                        else
                        {
                            for (int k = teA + teB + teC + 1; k <= teA + teB + teC + teD; k++)
                            {
                                matrizProcesos[4, k + 1] = "x";
                            }
                        }

                        if (matrizProcesos[4, tlB + tlC + tlD + tlE + i] == "x")
                        {
                            for (int k = 0 ; k < teB + teC + teD + teE - 1; k++)
                            {
                                matrizProcesos[5, tlB + tlC + tlD + tlE +k] = "e";
                            }
                        }
                        else
                        {
                            for (int k = teA + teB + teC + teD + 1; k <= teA + teB + teC + teD + teE; k++)
                            {
                                matrizProcesos[5, k + 1] = "x";
                            }
                        }


                    }
                    else
                    {
                        matrizProcesos[1, 1] = "i";
                        matrizProcesos[1, teA+2] = "t";
                        for (int k = 1; k <= teA; k++)
                        {
                            matrizProcesos[1, k + 1] = "x";
                        }
                    }
                }
            }

            for (int i = 0; i < 6; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 22; j++)
                {
                    Console.Write("[{0}]", matrizProcesos[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
