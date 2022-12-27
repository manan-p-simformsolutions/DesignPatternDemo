using System;

namespace AbstractFactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;

            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            animal = animalFactory.GetAnimal("Fish");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");

            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            animal = animalFactory.GetAnimal("Tiger");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();

            animal = animalFactory.GetAnimal("Snack");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.Read();
        }
    }
}