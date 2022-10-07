using Generic;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_TestSingleLinkedListTest
{
    internal class SingleLinkedListTest
    {
        [Test]
        
        public void LinkedList_test()
        {
            var newList = new LinkedList<int>();

            Node first = new Node(1);
            Node second = new Node(2);
            Node third = new Node(3);

            Assert.AreEqual(first.data, 1);

        }

    }
}
