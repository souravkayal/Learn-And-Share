using AdapterPattern;
using ArrayAndHash;
using ArrayAndHashAlgo;
using DesignPattern;
using FactoryDesignPattern;
using ProxyPattern;
using SinglyLinkedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDesignPattern;

namespace AlgoLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAlgoInLinkedList.LinkedList list = new PrintAlgoInLinkedList.LinkedList();
            list.AddNode(new PrintAlgoInLinkedList.Node { Value = 10 });
            list.AddNode(new PrintAlgoInLinkedList.Node { Value = 11 });
            list.AddNode(new PrintAlgoInLinkedList.Node { Value = 12 });
            list.AddNode(new PrintAlgoInLinkedList.Node { Value = 13 });
            list.AddNode(new PrintAlgoInLinkedList.Node { Value = 14 });

            //System.Console.Write(list.PrintSumOfAllItems());

            //list.PrintOnlyOddOrEvenItems(PrintAlgoInLinkedList.PrintType.Even);
            //list.PrintOnlyOddOrEvenItems(PrintAlgoInLinkedList.PrintType.Odd);

            //list.PrintOddOrEven(PrintAlgoInLinkedList.PrintType.Even); //200 , 400
            //list.PrintOddOrEven(PrintAlgoInLinkedList.PrintType.Odd); // 100 , 300 , 500
            //list.PrintLastNItems(3);
            //list.PrintFromIndex(2);
            //list.PrintRiverse();
            //list.PrintList();

            Console.ReadLine();
        }
    }
}
