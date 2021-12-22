using System;

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
        }
    }

    //can't be instatiated..only inherited
    abstract class Animal
    {
        public Animal(double weight)
        {
            Weight = weight;
        }
        public double Weight { get; set; }

    }

    class Cat : Animal
    {
        public Cat() :  base(4.5)
        {

        }
    }

    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {

        }
    }
}
