using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class AbstractClass
    {
        public abstract void Method1();
        public abstract void Method2();

        public void Template()
        {
            Method1();
            Method2();
        }
    }

    public class ConcreteClass : AbstractClass
    {
        public override void Method1()
        {
            System.Console.Write("Method1");            
        }
        public override void Method2()
        {
            System.Console.Write("Method2");
        }
    }



}
