using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertionAlgo
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {
            this.Head = new Node();
        }
        public void Print()
        {
            Node tmp = this.Head;
            while (tmp != null)
            {
                System.Console.Write(tmp.Value + "->");
                tmp = tmp.Next;
            }
        }
        public void InsertFirst(Node Item)
        {
            Item.Next = Head.Next;
            this.Head.Next = Item;
        }
        public void InsertLast(Node Item)
        {
            Node tmp = this.Head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }
            tmp.Next = Item;
        }

        public void InsertAt(Node Item, int Index)
        {
            int c = -1;
            Node tmp = this.Head;
            while (tmp != null)
            {
                c++;
                if (c == Index)
                    break;
                tmp = tmp.Next;
            }
            Node buffer = tmp.Next; 
            tmp.Next = Item;
            Item.Next = buffer;
        }
        public void InsertAfter(Node Item, int Value)
        {
            Node tmp = this.Head;
            Boolean found = false;
            while (tmp != null)
            {
                if (tmp.Value == Value)
                {
                    found = true;
                    break;
                }
                tmp = tmp.Next;
            }
            if (found)
            {
                Node buffer = tmp.Next;
                tmp.Next = Item;
                Item.Next = buffer;
            }
            else
                throw new Exception("Item not found in linked list");
        }





    }
}
