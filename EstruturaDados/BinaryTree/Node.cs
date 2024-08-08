using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaDados.BinaryTree
{
    public class Node
    {
        public Node(string value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}