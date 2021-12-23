using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Animal cat = new Animal(7.5);
            Animal dog = new Animal(25.2);*/

            Cat cat = new Cat();
            Dog dog = new Dog(10);
           /* Bird bird1 = new Bird(1.2);

            dog.Eat(bird1);*/

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                animal.Eat(new Grass(0.5));
                animal.Eat(new Bird(1));
                Console.WriteLine(animal.Weight);
            }
        }
    }

    class Grass : IEdible
    {
        public Grass(double weight)
        {
            Weight = weight;
        }
        public double Weight { get; set; }
    }

    interface IEdible
    {
        public double Weight { get; }
    }

    //can't be instatiated..only inherited
    abstract class Animal : IEdible
    {
        public Animal(double weight)
        {
            Weight = weight;
            MakeSound();
        }

        public virtual void Eat(IEdible edible)
        {
            this.Weight += edible.Weight;
        }

        public abstract void MakeSound();

        public double Weight { get; set; }

    }

    class Cat : Animal
    {
        public Cat() :  base(4.5)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Purr...");
        }
    }

    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {

        }
        public override void Eat(IEdible edible)
        {
            this.Weight += edible.Weight * 0.8;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Bird : Animal
    {
        public Bird(double weight) : base(weight)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Chirp");
        }
    }
}
