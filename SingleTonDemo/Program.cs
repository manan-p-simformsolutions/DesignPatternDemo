using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDemo
{
    class program
    {
        static void Main(string[] args)
        {
            SingleTon Teacher = SingleTon.GetInstance;
            Teacher.PrintDetails("This message is from Teacher");
            SingleTon Student = SingleTon.GetInstance;
            Student.PrintDetails("This message is from Student");
            Console.ReadLine();
        }
    }
}