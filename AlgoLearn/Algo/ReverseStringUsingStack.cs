using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class ReverseStringUsingStack
    {
        public string Value { get; set; }
        private Char []Stack { get; set; }

        private int Sp;

        public ReverseStringUsingStack(String Value)
        {
            if (Value.Length > 100) throw new Exception("String is too large. We can handle only 100 characters");
            this.Value = Value;
            this.Stack = new Char[100];
            Sp = 0;
        }

        private void Push(Char Item)
        {
            Stack[Sp] = Item;
            Sp++;
        }
        private IEnumerable<char> Pop()
        {
            if (Stack.Length <= 0)
                throw new Exception("No Item in STACK");

            for (int i = Sp -1 ; i >= 0; i--)
            {
                yield return Stack[i];
            }
        }

        public void Reverse()
        {
            foreach (var item in this.Value)
            {
                Push(item);
            }
            this.Value = String.Empty;

            foreach (var item in Pop())
            {
                this.Value = this.Value + item;
            }
        } 
    }
}
