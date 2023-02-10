using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree;

public class BinaryTree
{
    public Node Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        Root = Insert(Root, value);
    }

    private Node Insert(Node node, int value)
    {
        if (node == null)
        {
            node = new Node(value);
        }
        else
        {
            if (value <= node.Value)
            {
                node.Left = Insert(node.Left, value);
            }
            else
            {
                node.Right = Insert(node.Right, value);
            }
        }

        return node;
    }

}