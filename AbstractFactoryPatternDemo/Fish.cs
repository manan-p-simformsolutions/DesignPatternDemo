using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    public class Fish : IAnimal
    {
        public string speak()
        {
            return "Don't speak(Not human understandable)";
        }
    }
}
