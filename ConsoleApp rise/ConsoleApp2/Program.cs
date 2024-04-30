using System;

// Base class
class A
{
    public void ()
    {
        Console.WriteLine("it is class A.");
    }
}


class B: A
{
    public void B()
    {
        Console.WriteLine("it is class B");
    }
}

// Derived class inheriting from Mammal
class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();

        // Accessing methods from Animal class
        myDog.Eat();

        // Accessing methods from Mammal class
        myDog.Walk();

        // Accessing methods from Dog class
        myDog.Bark();
    }
}

