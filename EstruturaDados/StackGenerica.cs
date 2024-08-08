
using System.Collections.Generic;

namespace EstruturaDados
{
    internal class StackGenerica
    {
        internal static void TesteStackGenerica()
        {
            Stack<string> carros = new Stack<string>();
            carros.Push("Bê Eme");
            carros.Push("Hb20 da odonto");
            carros.Push("Uno que corre mais que carro novo");
            carros.Push("Opalão que bebe");
            carros.Push("Fusca que anda na enchente");

            Console.WriteLine("Pilha genérica: ");
            Console.WriteLine("Carros que chegaram no estacionamento bem pequeno: ");
            foreach (var carro in carros)
            {
                Console.WriteLine(carro);
            }
        }
    }
}