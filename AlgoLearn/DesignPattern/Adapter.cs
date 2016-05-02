using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter
    {
        private Adaptee adap;
        public Adapter()
        {
            adap = new Adaptee();
        }
        public void CallAdaptee()
        {
            //Call to Adaptee Function
            adap.Execute(); 
        }
    }
    public class Adaptee
    {
        public void Execute()
        {
            System.Console.WriteLine("Adaptee Called");
        }
    }

}
