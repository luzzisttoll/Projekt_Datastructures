using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            static Node quickSort(Node head, Node end)
            {
                if (head != end)
                {
                    Node temp = partition(head, end);
                    quickSort(head, temp);
                    quickSort(temp.next, end);
                }
                return head;
            }

            static Node partition(Node head, Node end)
            {
                int pivot = end.data;
                Node i = head;
                for (Node j = head; j != end; j = j.next)
                {
                    if (j.data <= pivot)
                    {
                        i = (i == null) ? head : i.next;
                        int temp = i.data;
                        i.data = j.data;
                        j.data = temp;
                    }
                }
                i = (i == null) ? head : i.next;
                int temp2 = i.data;
                i.data = end.data;
                end.data = temp2;
                return i;
            }


        }
    }
}
