namespace EstruturaDados.BinaryTree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(string rootValue)
        {
            Root = new Node(rootValue);
        }

        public void AddLeft(Node parent, string value)
        {
            parent.Left = new Node(value);
        }

        public void AddRight(Node parent, string value)
        {
            parent.Right = new Node(value);
        }

        // Método para realizar uma travessia em pré-ordem na árvore
        //TODO:corrigir
        public void PreOrderTraversal(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }
    }
}
