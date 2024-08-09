
namespace EstruturaDados.BinaryTree
{
    internal class BinaryTree
    {
        internal static void TestBinaryTree()
        {
            //geração atual
            BinarySearchTree tree = new BinarySearchTree("Baby Shark tchurchurutchutchuru");

            // Segunda geração
            tree.AddLeft(tree.Root, "Mommy Shark tchurchurutchutchuru");
            tree.AddRight(tree.Root, "Daddy Shark tchurchurutchutchuru");

            // Terceira geração
            tree.AddLeft(tree.Root.Left, "Grandma Shark tchurchurutchutchuru");
            tree.AddRight(tree.Root.Left, "Grandpa Shark tchurchurutchutchuru");

            // Travessia da árvore
            Console.WriteLine("Arvore genealogica do baby shark:");

            //tree.PreOrderTraversal(tree.Root);

            Console.WriteLine(tree.Root.Value);
            Console.WriteLine(tree.Root.Left.Value);
            Console.WriteLine(tree.Root.Right.Value);
            Console.WriteLine(tree.Root.Left.Left.Value);
            Console.WriteLine(tree.Root.Left.Right.Value);
        }
    }
}