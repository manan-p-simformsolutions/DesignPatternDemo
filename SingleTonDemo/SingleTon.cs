using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDemo
{
    public sealed class SingleTon
    {
        private static int counter = 0;
        private static SingleTon instance = null;
        public static SingleTon GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SingleTon();
                }
                return instance;
            }
        }
        private SingleTon()
        {
            counter++;
            Console.WriteLine("Counter value is " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
