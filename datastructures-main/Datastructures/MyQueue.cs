using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    public class MyQueue : ISubject
    {
        private SingleLinkedList prvList = new SingleLinkedList();
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; } = -0;
        private List<IObserver> _observers = new List<IObserver>();

        public Node Enqueue(int newElement)
        {
            var AddNode = new Node(newElement, null);
            prvList.insertLastNode(AddNode);
            Notify();
            return AddNode;
        }

        public Node Dequeue()
        {
            var cur = prvList.GetFirst();
            prvList.RemoveFirstElement();
            Notify();
            return cur;
        }

        public override string ToString()
        {
            return prvList.ToString();
        }

         public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
