using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternDemo
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (AnimalType.Equals("Snack"))
            {
                return new Snack();
            }
            else if (AnimalType.Equals("Tiger"))
            {
                return new Tiger();
            }
            else
                return null;
        }
    }
}
