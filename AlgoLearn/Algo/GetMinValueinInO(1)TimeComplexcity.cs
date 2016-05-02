using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class GetMinValueinInO_1_TimeComplexcity
    {
        List<int> Stack = new List<int>();
        List<int> MinStack = new List<int>();
        public void Push(int Item)
        {
            Stack.Add(Item);
            if (Stack.Count > 0)
            {
                MinStack.Add(Stack.Min());
            }
            else
                MinStack.Add(Item);
        }
        public int Pop()
        {
            if (Stack.Count == 0)
            {
                throw new Exception("Stack underflow");
            }
            else
            {
                var Item = Stack[Stack.Count - 1];
                Stack.RemoveAt(Stack.Count - 1);
                return Item;
            }
        }

        public int GetMinValue()
        {
            if (MinStack.Count > 0)
                return MinStack[MinStack.Count - 1];
            else
                throw new Exception();
        }


        public void Print()
        {
            for (int i = Stack.Count -1 ; i >= 0; i--)
            {
                System.Console.WriteLine(i);
            }
        }


    }
}
