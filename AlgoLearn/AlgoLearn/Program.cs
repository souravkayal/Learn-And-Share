using Matrix;
using System;
namespace AlgoLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array =  {
                                {0 , 1 , 0}, 
                                {0 , 1 , 0}, 
                                {0 , 0 , 0}
                            };

            // 1 1 1
            // 1 1 1
            // 0 1 0

            ModifyAllRowColumnByOne Obj = new ModifyAllRowColumnByOne();
            Obj.ModifyMatrix(Array, 3, 3);




            Console.ReadLine();
        }
    }
}
