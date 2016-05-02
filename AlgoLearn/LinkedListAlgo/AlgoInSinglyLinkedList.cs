using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListAlgo
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class AlgoInSinglyLinkedList
    {
        public Node Head { get; set; }
        public AlgoInSinglyLinkedList()
        {
            this.Head = new Node();
        }

        public void AddNode(Node item)
        {
            Node tmp = this.Head;
            while (tmp != null)
            {
                tmp = tmp.Next;
            }

            tmp.Next = item;
        }
        public void Print()
        {
            Node tmp = this.Head;
            while (tmp != null)
            {
                System.Console.Write(tmp.Value);
                tmp = tmp.Next;
            }
        }
        public int SumOfAllItem()
        {
            int Sum = 0;
            Node item = this.Head;
            while (item != null)
            {
                Sum = Sum + item.Value;
                item = item.Next;
            }
            return Sum;
        }

        public void 



    }
}
