using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class MyQueue
    {
        private SingleLinkedList prvList = new SingleLinkedList();

        public Node Enqueue(int newElement)
        {
            var AddNode = new Node(newElement, null);
            prvList.insertLastNode(AddNode);
            return AddNode;
        }

        public Node Dequeue()
        {
            var cur = prvList.GetFirst();
            prvList.RemoveFirstElement();
            return cur;
        }

        public override string ToString()
        {
            return prvList.ToString();
        }

    }
}
