﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(Object argData)
        {
            data = (int)argData;
            next = null;
        }
    }

}
