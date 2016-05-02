using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public interface IService
    {
        void Execute();
    }

    public class SmsService : IService
    {
        public void Execute()
        {
            System.Console.Write("SMS Service");
        }
    }
    public class MailService : IService
    {
        public void Execute()
        {
            System.Console.Write("Mail Service");
        }
    }

    public class ExecuteService
    {
        IService _Obj;
        //Property injetion
        public IService SetObjectByProperty
        {
            get { return _Obj; }
            set { _Obj = value; }
        }
        //Function Injection
        public void SetObjectByFunction(IService Obj)
        {
            this._Obj = Obj;
        }
        //Constructor injection
        public ExecuteService(IService Obj)
        {
            this._Obj = Obj;
        }
        public void CallService()
        {
            this._Obj.Execute();
        }
    }
}
