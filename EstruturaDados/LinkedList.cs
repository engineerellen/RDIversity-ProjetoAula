using System;
using System.Collections.Generic;

namespace EstruturaDados
{
    internal class LinkedList
    {
        internal static void TestLinkedList()
        {
            LinkedList<string> meses = new LinkedList<string>();
            meses.AddLast("Março");
            meses.AddFirst("Janeiro");

            var marco = meses.Find("Março");

            meses.AddBefore(marco, "Fevereiro");
            meses.AddAfter(marco, "Abril");

            var node = new LinkedListNode<string>("Maio");
            meses.AddLast(node);

            foreach (string mes in meses)
            {
                Console.WriteLine(mes);
            }
        }

        internal static void PrioridadePostinho()
        {
            LinkedList<string> filaAtendimento = new LinkedList<string>();
            filaAtendimento.AddLast("CidadaoComum1");
            filaAtendimento.AddFirst("Idoso80Anos");

            var cidadaoComum = filaAtendimento.Find("CidadaoComum1");

            filaAtendimento.AddBefore(cidadaoComum, "MulherGravida");
            filaAtendimento.AddAfter(cidadaoComum, "CidadaoComum2");

            var node = new LinkedListNode<string>("CidadaoComum3");
            filaAtendimento.AddLast(node);

            foreach (string mes in filaAtendimento)
            {
                Console.WriteLine(mes);
            }
        }
    }
}