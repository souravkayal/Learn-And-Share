using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
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
    public enum ServiceType
    {
        Sms, Mail
    }

    public class FactoryService
    {
        IService _Obj;
        Dictionary<ServiceType, IService> ObjectRepo = new Dictionary<ServiceType, IService>
        {
            { ServiceType.Mail , new MailService() },
            { ServiceType.Sms , new SmsService() }
        };
        public FactoryService(ServiceType Type)
        {
            this._Obj = ObjectRepo[Type]; 
        }

        public IService ReturnObject()
        {
            return _Obj;
        }

    }

}
