using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListAlgo
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
    }

    public class BoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public BoublyLinkedList()
        {
            this.Head = new Node<T>();
        }
        public void AddInLast(Node<T> node)
        {
            Node<T> tmp = this.Head;
            Node<T> current = this.Head;
            while (tmp.Next != null)
            {
                current = tmp;
                tmp = tmp.Next;
            }
            tmp.Next = node;
            tmp.Previous = current;
        }

        public void AddFirst(Node<T> node)
        {
            //if (this.Head.Next == null)
            //{
            //    this.Head.Next = node;
            //}
            //else
            //{
            //    var tmp = this.Head.Next;
            //    tmp.Previous = node;
            //    node.Next = tmp;
            //}
        }
        public void Print()
        {
            Node<T> tmp = this.Head;
            while (tmp.Next != null)
            {
                System.Console.Write(tmp.Value);
                tmp = tmp.Next;
            }
            System.Console.Write(tmp.Value);
        }
    }
}
