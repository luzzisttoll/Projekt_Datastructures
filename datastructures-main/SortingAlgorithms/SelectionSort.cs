using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            var cur = list.GetFirst();
            while (cur != null)
            {
                var nextSmallest = getNextSmallest(cur);
                if (nextSmallest != cur)
                {
                    list.SwitchNode3(cur, nextSmallest);
                }
            }
            Console.WriteLine("SelectionSorted List ");
        }

        private Node getNextSmallest (Node startNode)
        {
            Node smallest = startNode;
            for (var comparer = startNode.next; comparer.next != null; comparer = comparer.next)
            {
                if (comparer.data < smallest.data)
                {
                    smallest = comparer;
                }
            }
            return smallest;
        }
    }
}
