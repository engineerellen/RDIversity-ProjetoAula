using System.Collections;

namespace EstruturaDados.Pilha
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
            Console.WriteLine("\t Minhas Historias em quadrinhos empilhadas: ");

            foreach (var item in hq)
                Console.WriteLine($"\t{item}");

            Console.WriteLine(hq.Pop());
        }
    }
}