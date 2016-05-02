using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Model
    {
        public String Name { get; set; }
        public String Surname { get; set; }
    }

    public class PrototypeModel : Model
    {
        public Model ReturnModel()
        {
            return (Model) this.MemberwiseClone();
        }
    }
}
