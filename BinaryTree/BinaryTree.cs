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
        Insert(Root, value);
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

    public override string ToString()
    {
        return getElementsAsString(Root);
    }
    string getElementsAsString(Node element)
    {
        if (element == null)
            return "";
        if (element.IsLeaf())
            return element.ToString();
        return getElementsAsString(element.LeftChild)
            + element.ToString()
            + getElementsAsString(element.RightChild);

    }

}