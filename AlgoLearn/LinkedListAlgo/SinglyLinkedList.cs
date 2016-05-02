using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public SinglyLinkedList()
        {
            this.Head = new Node<T>();
        }
        public void Add(Node<T> Item)
        {
            Node<T> tmp = this.Head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }
            tmp.Next = Item;
        }

        public void RemoveFirst()
        {
            Node<T> tmp = this.Head;
            if (tmp.Next == null)
                throw new Exception("Empty List");
            else
            {
                if (tmp.Next.Next == null)
                    tmp.Next = null;
                else
                    tmp.Next = tmp.Next.Next;
            } 
        }

        public void RemoveLast()
        {
            Node<T> tmp = this.Head;
            Node<T> current = this.Head;

            while (tmp.Next != null)
            {
                current = tmp;
                tmp = tmp.Next;
            }
            current.Next = null;
        }


        public void Print()
        {
            Node<T> tmp = this.Head.Next;
            while (tmp != null && tmp.Next != null)
            {
                System.Console.Write(tmp.Value + "-> ");
                tmp = tmp.Next;
            }
            System.Console.Write(tmp.Value);
        }
    }
}
