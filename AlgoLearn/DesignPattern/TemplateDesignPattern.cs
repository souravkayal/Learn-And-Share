using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern
{
    public abstract class AccountTemplate
    {
        public abstract void Deposit();
        public abstract void Withdraw();
    }

    public class SavingAccount : AccountTemplate
    {
        public override void Withdraw()
        {
            System.Console.Write("Withdraw..");
        }
        public override void Deposit()
        {
            System.Console.Write("Deposit..");
        }
    }

    public class CurrentAccount : AccountTemplate
    {
        public override void Withdraw()
        {
            System.Console.Write("Withdraw..");
        }
        public override void Deposit()
        {
            System.Console.Write("Deposit..");
        }
    }

}
