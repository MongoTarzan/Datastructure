using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class SingleLinkedListTest
    {
        [SetUp]
        public void Setup()
        {
            LinkedList<int> testlist = new LinkedList<int>();
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
