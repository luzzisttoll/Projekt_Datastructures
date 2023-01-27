using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Node
    {
        public int data;
        public Node next;
        public Node LtNode;
        public Node RtNode;
        // Constructor to create a new node
        public Node(int d, Node _next)
        {
            data = d;
            next = _next;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
    }
}