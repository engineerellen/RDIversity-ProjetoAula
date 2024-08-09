
namespace EstruturaDados
{
    internal class QueueClass
    {
        internal static void TestQueue()
        {
            Queue<string> filaAtendimento = new Queue<string>();

            filaAtendimento.Enqueue("Margarida");
            filaAtendimento.Enqueue("Florinda");
            filaAtendimento.Enqueue("Josefa");
            filaAtendimento.Enqueue("Geraldo");
            filaAtendimento.Enqueue("José");

            Console.WriteLine("Fila do banco ás 7 da manhã\n");
            Console.WriteLine($"\tQuantidade :\t {filaAtendimento.Count}");
            Console.Write("\tQuem já chegou: ");

            foreach (var pessoa in filaAtendimento)
                Console.WriteLine($"\t{pessoa}");

            Console.WriteLine("O primeiro a ser atendido às 10h da manhã: ");
            Console.WriteLine(filaAtendimento.Dequeue());
        }
    }
}