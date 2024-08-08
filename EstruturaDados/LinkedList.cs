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
    }
}