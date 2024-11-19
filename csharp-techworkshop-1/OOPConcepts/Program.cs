using System;

namespace OOPConceptsDemo {
    class Program {
        static void Main(string[] args)
        {
            //// Step 1
            ////Polymorphism
            //Animal dog = new Dog();
            //Animal cat = new Cat();

            //dog.Speak(); 
            //cat.Speak();




            //// Step 2
            //// Encapsulation
            //Person person = new Person();
            //person.SetName("John Doe");
            //Console.WriteLine($"Person's Name: {person.GetName()}");





            //// Step 3
            //// Abstraction and Interfaces
            //IVehicle car = new Car();
            //car.Drive();

            //IVehicle bicycle = new Bicycle();
            //bicycle.Drive();

            Console.ReadKey();
        }
    }

    // Step 1
    // Polymorphism and Abstraction
    abstract class Animal {
        public abstract void Speak(); // Abstract method
    }

    class Dog : Animal {
        public override void Speak()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Cat : Animal {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }

    // Step 2
    // Encapsulation
    class Person {
        private string name; 

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }


    // Step 3
    // Interfaces
    interface IVehicle {
        void Drive(); 
    }

    class Car : IVehicle {
        public void Drive()
        {
            Console.WriteLine("Driving a car...");
        }
    }

    class Bicycle : IVehicle {
        public void Drive()
        {
            Console.WriteLine("Riding a bicycle...");
        }
    }
}
