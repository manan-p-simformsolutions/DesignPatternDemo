using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    public class Tiger:IAnimal
    {   
        public string speak()
        {
            return "Roar...";
        }
    }
}
