﻿using Generic;

namespace GenerischeKlassen
{
    class Program
    {
        public static void Main(String[] args)
        {
            LinkedList list1 = new LinkedList();

            list1.head = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            list1.head.next = second;
            second.next = third;

            list1._printNodes();
        }
    }
} 