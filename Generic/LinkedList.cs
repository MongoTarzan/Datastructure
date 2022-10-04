using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class LinkedList
    {
        public Node head;

        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }

        public void insert(int newdata)
        {
            Node first = new Node(newdata);
            first.next = head;
            head = first;
        }

        public int count()
        {
            return 0;
        }
    }
}
