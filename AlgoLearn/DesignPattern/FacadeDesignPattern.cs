using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class SubClass1
    {
        public void Function1()
        {
            System.Console.Write("Function 1");
        }
    }

    public class SubClass2
    {
        public void Function2()
        {
            System.Console.Write("Function 2");
        }
    }

    public class SubClass3
    {
        public void Function3()
        {
            System.Console.Write("Function 3");
        }
    }



    public class FacadeDesignPattern
    {
        SubClass1 Obj1 = new SubClass1();
        SubClass2 Obj2 = new SubClass2();
        SubClass3 Obj3 = new SubClass3();

        public void Fun1()
        {
            Obj1.Function1();
            Obj2.Function2();
        }
        public void Fun2()
        {
            Obj2.Function2();
            Obj3.Function3();
        }
    }


}
