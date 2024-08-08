using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.Aula2
{
    internal class Arrays_Loops
    {
        static string[] arrDiasSemana = new string[] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo" };

        //variavel global - toda a classe enxerga
        static int[] arrayWhile = new int[] { 1, 2, 3, 4, 5 };

        /// <summary>
        /// Foreach
        /// </summary>
        internal static void TesteForEach()
        {
            foreach (var item in arrDiasSemana)
            {
                if (item == "Sabado")
                {
                    Console.WriteLine("Sabado é dia de dar banho no cachorro.");
                }
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// For
        /// </summary>
        internal static void TesteFor()
        {
            try
            {
                for (int indice = 0; indice <= arrayWhile.Length; indice++)
                {
                    //if (arrayWhile[indice] == 3)
                    //{
                    //    Console.WriteLine("achei meu numero!");
                    //    break;
                    //}
                    Console.WriteLine(arrayWhile[indice]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("O limite do array é de 4 posições!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("For finalizado!");
            }
        }

        /// <summary>
        /// continue
        /// </summary>
        internal static void TesteContinue()
        {
            int indice = 0;
            while (arrayWhile[indice] <= 5)
            {
                if (arrayWhile[indice] == 3)
                    break;
                if (arrayWhile[indice] < 4)
                {
                    indice++;
                    Console.WriteLine(arrayWhile[indice]);
                    continue;
                }
            }
        }

        /// <summary>
        /// Break
        /// </summary>
        internal static void TesteBreak()
        {
            int indice = 0;
            while (arrayWhile[indice] < 5)
            {
                if (arrayWhile[indice] == 3)
                    break;
                Console.WriteLine(arrayWhile[indice]);
                indice++;

            }
        }

        /// <summary>
        /// Do While
        /// </summary>
        internal static void PercorreDOWhile()
        {
            int indice = 0;
            do
            {
                Console.WriteLine(arrayWhile[indice]);
                indice++;

            } while (arrayWhile[indice] < 5);
        }

        /// <summary>
        /// Whilie
        /// </summary>
        internal static void PercorreWhile()
        {
            int indice = 0;
            while (arrayWhile[indice] < 5)
            {
                Console.WriteLine(arrayWhile[indice]);
                indice++;//indice = indice + 1;
            }
        }

        //Apenas exemplo para mostrar as formas de inicializar um array
        private static void InicializarArray()
        {
            // Array unidimensional de 5 inteiros .
            int[] array1 = new int[5];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;
            array1[3] = 40;
            array1[4] = 50;

            // Declarar e setar valores nos array.
            int[] array2 = new int[] { 10, 20, 30, 40, 50 };

            // sintaxe alteranativa
            int[] array3 = { 10, 20, 30, 40, 50 };

            // Array de 2 dimensões - matriz.
            int[,] multiDimensionalArray1 = new int[2, 3];
            multiDimensionalArray1[0, 0] = 10;
            multiDimensionalArray1[0, 1] = 20;
            multiDimensionalArray1[0, 2] = 30;

            multiDimensionalArray1[1, 0] = 40;
            multiDimensionalArray1[1, 1] = 50;
            multiDimensionalArray1[1, 2] = 60;

            // Declarar e setar elementos no array .
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declarar um jagged array (array de array).
            int[][] jaggedArray = new int[6][];

            // Setar valores no primeiro array de um jagged array.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = array1;
        }
    }
}
