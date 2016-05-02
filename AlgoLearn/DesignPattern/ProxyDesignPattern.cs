using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public abstract class Compute
    {
        public abstract int Calculate();
    
    }
    public class ComputeProcess : Compute
    {
        public override int Calculate()
        {
            return 100;
        }
    }
    public class ProxyCompute
    {
        public int Calculate()
        {
            return new ComputeProcess().Calculate();
        }
    }
}
