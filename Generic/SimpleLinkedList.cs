using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class SimpleLinkedList
    {
        public Node head;
        public int index = 0;

        public void InsertFirst(Object newFirst)
        {
            if (head == null)
            {
                head = new Node(newFirst);
                index++;
            }
            else
            {
                Node node = new Node(newFirst);
                node.next = head;
                head = node;
                index++;
            }
        }

        public void _InsertLast(Object newLast)
        {
            Node node = new Node(newLast);

            if (head == null)
            {
                head = node;
                index++;
            }
            else
            {
                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                index++;
            }
        }

        public bool _DeleteAtX(int _index)
        {
            if (_index > index)
            {
                return false;
                Console.WriteLine("this Object doesn't exist in the list");
            }
            else
            {
                Node previous = head;
                Node _next;

                for (int i = 0; i < _index; i++)
                {
                    previous = previous.next;
                }
                _next = previous.next.next;
                previous.next = _next;

                return true;
                Console.WriteLine("Obeject was successfully deleted!");
            }
        }

        public void InsertAfterX(Node _newValue, int _index)
        {
            if (_index > index)
            {
                Console.WriteLine("this Object doesn't exist");
            }
            else
            {
                Node previous = head;
                Node _next;

                for (int i = 0; i < _index; i++)
                {
                    previous = previous.next;
                }

                Node newNode = new Node(_newValue);
                _next = previous.next;      //_next bekommt den werd vom next der vorherigen Node
                previous.next = newNode;    //der neue nextWert der vorherigen Node wird auf diese Node gezeigt
                newNode.next = _next;       //der nextWert unserer Neuen Node wird auf den damaligen nextWert der alten Node gezeigt
                                           
                index++;
            }
        }

        public void getNode(int _value)
        {
            Node temp = new Node();
            temp = this.head;

            int found = 0;
            int i = 0;

            if (temp != null)
            {
                while (temp != null)
                {
                    i++;
                    if (temp.data == _value)
                    {
                        found++;
                        break;
                    }
                    temp = temp.next;
                }
                if (found == 1)
                {
                    Console.WriteLine(_value + " is found at index " + i);
                }
                else
                {
                    Console.WriteLine("the object is not in the list");
                }
            }
            else
            {
                Console.WriteLine("This list is empty");
            }
           
        }

        public void _printNodes()
        {
            Node current = head;
            String printedNodes = "";
            while (current != null)
            {
                printedNodes += current.data + "\n";
                current = current.next;
            }
            Console.WriteLine(printedNodes);
        }

        public object _First()
        {
            return head.data;
        }

        public object _Last()
        {
            Node last = head;

            while (last.next != null)
            {
                last = last.next;
            }

            return last.data;
        }
    }
}
