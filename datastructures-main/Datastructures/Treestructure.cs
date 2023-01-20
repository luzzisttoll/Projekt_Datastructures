using Common;
using Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class BinaryTree
    {

        Node newNode = new Node(0, null);
        public Node Root { get; set; }

        public bool Insert(int value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                //Is new node in left tree?
                if (value < after.data)
                    after = after.LtNode;
                //Is new node in right tree?
                else if (value > after.data)
                    after = after.RtNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }
            
            newNode.data = value;
            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value < before.data)
                    before.LtNode = newNode;
                else
                    before.RtNode = newNode;
            }
            return true;
        }

        public void PostOrder(Node parent)
        {
            if (parent != null)
            {
                PostOrder(parent.LtNode);
                PostOrder(parent.RtNode);
                Console.Write(parent.data + " ");
            }
        }

        public int GetDepth()
        {
            return this.GetDepth(this.Root);
        }

        public int GetDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetDepth(parent.LtNode), GetDepth(parent.RtNode)) + 1;
        }

        public void Delete(int value)
        {
            this.Root = Delete(this.Root, value);
        }

        private Node Delete(Node parent, int key)
        {
            if (parent == null)
                return parent;

            if (key < parent.data) 
                parent.LtNode = Delete(parent.LtNode, key);
            else if (key > parent.data)
                parent.RtNode = Delete(parent.RtNode, key);

            // if the value is the same as the parent's value, then this node is to be deleted  
            else
            {
                // the node with one or no child  
                if (parent.LtNode == null)
                    return parent.RtNode;
                else if (parent.RtNode == null)
                    return parent.LtNode;
                // node with two children: Get the inorder successor (smallest in the right subtree)  
                
                parent.data = MinValue(parent.RtNode);
                // Delete the inorder successor  
                parent.RtNode = Delete(parent.RtNode, parent.data);
            }
            return parent;
        }

        private int MinValue(Node node)
        {
            int minv = node.data;
            
            while (node.LtNode != null)
            {
                minv = node.LtNode.data;
                node = node.LtNode;
            }
            return minv;
        }

        public override string ToString()
        {
            return newNode.ToString();
        }
    }
}

