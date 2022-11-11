namespace SingleLinkedList
{
    public class SingleLinkedList
    {
        public Node head;
        public int index = 0;

        public void InsertFirst(int _value)
        {
            if(head == null)
            {
                head = new Node(_value);
                index++;
            }
            else
            {
                Node node = new Node(_value);
                node.next = head;
                head = node;
                index++;
            }
        }

        public void printAllNodes()
        {
            Node current = head;
            String printString = "";
            while (current != null)
            {
                printString += current.data + "\n";
                current = current.next;
            }
            Console.WriteLine(printString);
        }

        public void InsertLast(int _value)
        {
            Node node = new Node(_value);

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


        public void DeleteAt(int _index)
        {
            if(_index > index)
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
                _next = previous.next.next;
                previous.next = _next;

            }
        }

        public void InsertAt(int _value, int _index)
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
                Node newNode = new Node(_value);
                _next = previous.next;
                previous.next = newNode;
                newNode.next = _next;
                index++;
            }
        }

        public Node First()
        {
            return head;
        }

        public Node Last()
        {
            Node last = head;

            while(last.next != null)
            {
                last = last.next;
            }
            return last;
        }

        public int Count()
        {
            Node current = head;

            int count = 1;

            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }

        public Node? GetElement(int element)
        {
            Node current = head;

            while (!current.data.Equals(element))
            {
                if(current.next == null) 
                {
                    Node node = new Node(element);
                    return node; 
                }

                current = current.next;  
            }
            return current;
        }

        public void InsertAfter(int before, int value)
        {
            Node node = new Node(value);
            Node getElement = GetElement(before);
            Node after = getElement.next;   

            getElement.next = node;
            getElement.next.next = after;
        }

        public bool DeleteNode(Node node)
        {
            Node current = head;
            Node next;
            int index = 0;

            while (!current.data.Equals(node.data))
            {
                if (current.next == null)
                {
                    return false;
                }
                current = current.next;
            }

            index++;
            DeleteAt(index);

            return true;
        }

        public bool Exists(Node node)
        {
            Node currentNode = head;
            if (currentNode == node) return true;
            while(currentNode != node)
            {
                 
                if (currentNode.next == node)
                {
                    return true;
                }
                currentNode = currentNode.next;
            }
            return false;
        }
        public override string ToString()
        {
            string retval = "";
            if (head == null)
                return "No elements in List";

            var node = head;
            while (node != null)
            {
                retval += "| " + node.data + " ";
                node = node.next;
            }
            retval += "|";
            return retval;
        }
        public void SwitchNodes(Node node1, Node node2)
        {
            if (!Exists(node1) || !Exists(node2)) return;

            (node1.data, node2.data) = (node2.data, node1.data);
        }

        public void Insertsort()
        {
            var temp = head.next;

            while (temp != null)
            {
                for (var current = head; current.next != null; current = current.next)
                {
                    if (current.data == temp.data && current.next.data == temp.next.data)
                        break;
                    if (current.data <= temp.data)
                        continue;
                    var speicher = current.data;
                    current.data = temp.data;
                    temp.data = speicher;
                }
                temp = temp.next;
            }
        }

        public void InsertionSortInverse()
        {
            var temp = head;

            while (temp != null)
            {
                for (var current = head; current.next != null; current = current.next)
                {
                    if (current.data == temp.data && current.next.data == temp.next.data)
                        break;
                    if (current.data >= temp.data)
                        continue;
                    var speicher = current.data;
                    current.data = temp.data;
                    temp.data = speicher;
                }
                temp = temp.next;
            }
        }

    }
}