using System.Collections;

namespace EstruturaDados
{
    internal class StackSimples
    {

        internal static void TestarStackSimples()
        {
            Stack hq = new Stack();
            hq.Push("Mulher gato");
            hq.Push("Mônica");
            hq.Push("Magali");
            hq.Push("Mulher Maravilha");
            hq.Push("Milena");

            Console.WriteLine("PilhaSimples\n");
            Console.WriteLine($"\tQuantidade :\t {hq.Count}");
            Console.Write("\t Minhas Historias em quadrinhos empilhadas: ");

            foreach (var item in hq)
                Console.Write($"\t{item}");

        }
    }
}