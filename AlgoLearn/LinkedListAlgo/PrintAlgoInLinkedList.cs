using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAlgoInLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    public enum PrintType
    {
        Odd, Even
    }

    public class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {
            this.Head = new Node();
        }
        public void AddNode(Node Item)
        {
            Node tmp = this.Head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }
            tmp.Next = Item;
        }
        private int ReturnLength()
        {
            int Count = 0;
            if (this.Head.Next != null)
            {
                Node tmp = this.Head.Next;
                while (tmp != null)
                {
                    Count += 1;
                    tmp = tmp.Next;
                }
            }
            return Count;            
        }
        public void PrintRiverse()
        {
            List<int> items = new List<int>();
            Node tmp = this.Head;
            while (tmp != null)
            {
                items.Add(tmp.Value);
                tmp = tmp.Next;
            }
            for (int i = items.Count -1 ; i >= 0; i--)
                Console.Write(items[i] + "->");
        }
        public void PrintOddOrEven(PrintType Print)
        {
            if (Print == PrintType.Odd)
            {
                Node tmp = this.Head.Next;
                while (tmp != null)
                {
                    System.Console.Write(tmp.Value + "->");

                    if (tmp.Next != null && tmp.Next.Next != null)
                        tmp = tmp.Next.Next;
                    else
                        tmp = null;
                }
            }
            else if (Print == PrintType.Even)
            {
                Node tmp = null;

                if (this.Head.Next != null && this.Head.Next.Next != null)
                {
                    tmp = this.Head.Next.Next;
                    while (tmp != null)
                    {
                        System.Console.Write(tmp.Value + "->");
                        if (tmp.Next != null && tmp.Next.Next != null)
                            tmp = tmp.Next.Next;
                        else
                            tmp = null;
                    }
                }
            }
            else
                throw new Exception("Invalid Argument");
        }
        public void PrintOnlyOddOrEvenItems(PrintType Print)
        {
            Node tmp = this.Head.Next;
            while (tmp != null)
            {
                if (Print == PrintType.Even && tmp.Value % 2 == 0)
                {
                    System.Console.Write(tmp.Value + "->");
                }
                else if(Print == PrintType.Odd && tmp.Value % 2 != 0)
                {
                    System.Console.Write(tmp.Value + "->");
                }
                tmp = tmp.Next;
            }
        }
        public int PrintSumOfAllItems()
        {
            Node tmp = this.Head.Next;
            int Sum = 0;
            while (tmp != null)
            {
                Sum += tmp.Value;
                tmp = tmp.Next;
            }
            return Sum;
        }
        public void PrintFromIndex(int Index)
        {
            if(Index < ReturnLength())
            {
                int Count = 0;
                Node tmp = this.Head;
                while (tmp != null)
                {
                    if (Count > Index)
                        System.Console.Write(tmp.Value + "->");
                    tmp = tmp.Next;
                    Count += 1;
                }
            }
            else
                throw new Exception("Invalid Argument");
        }

        //1) Initialize both pointer @ head
        //2) Increase ref pointer by n 
        //3) Increment both pointer by one 
        //4) Once Ref pointer reaches end, start printing 
        //main pointer until reaches to end

        public void PrintLastNItems(int PrintCount)
        {
            if (PrintCount > ReturnLength())
                throw new Exception("Invalid Argument");
            else
            {
                Node mainPtr = this.Head;
                Node refPtr = this.Head;
                int Count = 0;

                while (Count < PrintCount)
                {
                    refPtr = refPtr.Next;
                    Count += 1;
                }
                while (refPtr != null)
                {
                    refPtr = refPtr.Next;
                    mainPtr = mainPtr.Next;
                }

                while (mainPtr != null)
                {
                    Console.Write(mainPtr.Value + "->");
                    mainPtr = mainPtr.Next;
                }


            }
        }
        public void PrintList()
        {
            Node tmp = this.Head;
            while (tmp != null)
            {
                Console.Write(tmp.Value + "->");
                tmp = tmp.Next;
            }
            
        }
        
        public void PrintMiddleItem()
        {
            int length = ReturnLength();
            int middle = 0;
            int Count = 0;

            Boolean IsEvenCount = false;

            if (length % 2 == 0)
                IsEvenCount = true;
            middle = length / 2;

            Node tmp = this.Head;
            while (tmp != null)
            {
                Count += 1;
                tmp = tmp.Next;
            }

        }


    }
}
