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
                Bird bird = new Bird(1.5);
                animal.Eat(bird);
                Console.WriteLine(animal.Weight);
            }
        }
    }

    //can't be instatiated..only inherited
    abstract class Animal
    {
        public Animal(double weight)
        {
            Weight = weight;
            MakeSound();
        }

        public virtual void Eat(Animal animalToEat)
        {
            this.Weight += animalToEat.Weight;
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
        public override void Eat(Animal animalToEat)
        {
            this.Weight += animalToEat.Weight * 0.8;
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
