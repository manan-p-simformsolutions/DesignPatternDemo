using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    public class Snack: IAnimal
    {
        public string speak()
        {
            return "Shhhh...";
        }
    }
}
