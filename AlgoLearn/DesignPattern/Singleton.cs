using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public static class Singleton
    {
        public static int Data { get; set; }
        
        public static int ReturnSingleton()
        {
            return Data;
        }
    }

    public class SingletonPattern
    {
        private SingletonPattern() { }
        public static int Value { get; set; }
        private static SingletonPattern Object;

        public static SingletonPattern Instance()
        {
            if (Object == null)
                Object = new SingletonPattern();
            return Object;
        }
    }

 }
