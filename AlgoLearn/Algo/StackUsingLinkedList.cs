using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Node<T>
    {
        public T  Value { get; set; }
        public Node<T> Next { get; set; }
    }
    public class StackUsingLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public StackUsingLinkedList()
        {
            this.Head = new Node<T>();
        }

        public void Push(Node<T> Item)
        {
            if (this.Head.Next == null)
                this.Head.Next = Item;
            else
            {
                Node<T> tmp = this.Head.Next;
                this.Head.Next = Item;
                Item.Next = tmp;
            }
        }
        public void Pop()
        {
            Node<T> tmp = this.Head.Next;
            if (tmp != null)
            {
                if (tmp.Next != null)
                    this.Head.Next = tmp.Next;
                else
                    this.Head.Next = null;
            }
            else
                throw new Exception("Stack Underflow");
        }

        public void Print()
        {
            Node<T> tmp = this.Head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
                System.Console.WriteLine(tmp.Value);
            }
        }

    }
    
}
