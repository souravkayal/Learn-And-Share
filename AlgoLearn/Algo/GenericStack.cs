using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class GenericStack<T>
    {
        List<T> Items;
        int Top;
        public GenericStack()
        {
            Items = new List<T>();
            Top = -1;
        }

        public void Push(T Item)
        {
            Top++;
            Items.Add(Item);
        }

        public T Pop()
        {
            if (Items.Count > 0)
            {
                T data = Items[Top];
                Items.RemoveAt(Top);
                Top--;
                return data;
            }
            throw new Exception("Stack Underflow");
        }

        public void Print()
        {
            for (int i = Top; i >= 0; i--)
            {
                System.Console.WriteLine(Items[i]);
            }
        }

    }
}
