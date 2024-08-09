namespace EstruturaDados.Pilha
{
    internal class StackGenerica
    {
        internal static void TesteStackGenerica()
        {
            Stack<string> vagas = new Stack<string>();
            vagas.Push("Bê Eme");
            vagas.Push("Hb20 da odonto");
            vagas.Push("Uno que corre mais que carro novo");
            vagas.Push("Opalão que bebe");
            vagas.Push("Fusca que anda na enchente");

            Console.WriteLine("Pilha genérica: ");
            Console.WriteLine("Carros que chegaram no estacionamento bem estreito: ");
            foreach (var carro in vagas)
                Console.WriteLine(carro);

            Console.WriteLine("Carro que sairá primeiro do estacionamento:");
            Console.WriteLine(vagas.Pop());
        }
    }
}