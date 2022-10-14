using NUnit.Framework;
using SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleLinkedList
{
    internal class SingleLinkedListTest
    {
        [SetUp]
        public void Setup()
        {
            var testlist = new SimpleLinkedList();
            testlist.InsertFirst(2);
            testlist.InsertFirst(3);
            testlist.InsertFirst(4);
            testlist.InsertFirst(5);
        }

        [Test]
        public void singleLinkedListInsertFirstTest()
        {
            
        }
    }
}
