using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marge2LinkedListAlgo
{
    public class Node
    {
        public int Value { get; set; }

        public Node Next { get; set; }
    }

    public class Marge2LinkedList
    {
        public Node Head { get; set; }

        public Node NewHead { get; set; }

        public Marge2LinkedList()
        {
            this.Head = new Node();
            this.NewHead = new Node();
        }
        public void AddNode(Node node)
        {
            Node temp = this.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
        }

        public void Marge(Node list1 , Node list2)
        {
            Node temp1 = list1.Next;
            Node temp2 = list2.Next;
            Node tmp = this.NewHead;

            while (temp1 != null)
            {
                if (this.NewHead.Next == null)
                {
                    this.NewHead.Next = new Node { Value = temp1.Value + temp2.Value };
                }
                else
                {
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Next = new Node { Value = temp1.Value + temp2.Value };
                }
                
                temp1 = temp1.Next;
                temp2 = temp2.Next;
            }
        }

        public void Print()
        {
            Node temp = this.NewHead.Next;
            while (temp != null)
            {
                System.Console.Write(temp.Value + "->");
                temp = temp.Next;
            }
        }


    }
}
