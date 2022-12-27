using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubPatternDemo
{
    public class Pub
    {
        public Action OnChange { get; set; }

        public void Raise()
        {
            if (OnChange != null)
            {
                OnChange();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();

            p.OnChange += () => Console.WriteLine("Hello, Customer 1!");

            p.OnChange += () => Console.WriteLine("Hello, Customer 2!");

            p.Raise();

            Console.WriteLine("Press enter to close!");
            Console.ReadLine();
        }
    }
}