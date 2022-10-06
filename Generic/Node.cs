using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int argData)
        {
            data = argData;
            next = null;
        }
    }

}
