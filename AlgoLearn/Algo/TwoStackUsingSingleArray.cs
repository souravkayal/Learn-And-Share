using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    /// <summary>
    /// Array size is 100 
    /// so each stack size is 50
    /// </summary>
    /// 
    public enum Stack
    {
        Left, Right
    }

    public class TwoStackUsingSingleArray
    {
        int[] Array;
        int     LeftTop;
        int RightTop;
        public TwoStackUsingSingleArray()
        {
            Array = new int[100];
            LeftTop = -1;
            RightTop = 100;
        }

        public void Push(int Item, Stack Location)
        {
            if (Location == Stack.Left)
            {
                if (LeftTop > 49)
                    throw new Exception("Stack Overflow");
                LeftTop++;
                Array[LeftTop] = Item;
            }
            else if (Location == Stack.Right)
            {
                if(RightTop < 50)
                     throw new Exception("Stack Overflow");
                RightTop--;
                Array[RightTop] = Item;
            }
        }
        public int Pop(Stack Location)
        {
            int Item = 0;
            if (Location == Stack.Left)
            {
                if (LeftTop < 0)
                    throw new Exception("Stack Underflow");
                Item = Array[LeftTop];
                LeftTop--;
            }
            else if (Location == Stack.Right)
            {
                if (RightTop > 99)
                    throw new Exception("Stack Underflow");
                Item = Array[RightTop];
                RightTop++;
            }
            return Item;
        }
        
        public void Print(Stack Location)
        {
            if(Location == Stack.Left)
            {
                for (int i = LeftTop; i >= 0; i--)
                {
                    System.Console.WriteLine(Array[i]);
                }
            }
            else if (Location == Stack.Right)
            {
                int Tmp = RightTop;
                for (int i = 0 ; i <=  (99- RightTop) ; i++)
                {
                    System.Console.WriteLine(Array[Tmp]);
                    Tmp++;
                }
            }
        }

    }
}
