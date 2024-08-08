
using System.Collections;

namespace EstruturaDados
{
    internal class QueueClass
    {
        internal static void TestQueue()
        {
            Queue filaAtendimento = new Queue();
            filaAtendimento.Enqueue("Margarida");
            filaAtendimento.Enqueue("Florinda");
            filaAtendimento.Enqueue("Josefa");
            filaAtendimento.Enqueue("Geraldo");
            filaAtendimento.Enqueue("José");

            Console.WriteLine("Fila do banco ás 7 da manhã\n");
            Console.WriteLine($"\tQuantidade :\t {filaAtendimento.Count}");
            Console.Write("\tQuem já chegou: ");

            foreach (Object obj in filaAtendimento)
                Console.Write($"\t{obj}");
        }
    }
}
