using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Payment
    {
        string Provider { get; set; }
        string Number { get; set; }
        double Amount { get; set; }

        public Payment SetProvider(string Provider)
        {
            this.Provider = Provider;
            return this;
        }
        public Payment SetNumber(string Number)
        {
            this.Number = Number;
            return this;
        }
        public Payment SetAmount(double Amount)
        {
            this.Amount = Amount;
            return this;
        }
        public void DoRecharge()
        {

        }

    }
}
