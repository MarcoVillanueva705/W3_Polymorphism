using System;

namespace W3_Polymorphism
{
    //**Polymorphism and Overriding Methods**
    //Inheritance lets us inherit fields 
    //and methods from another class. 
    //Polymorphism uses those methods to perform different tasks.
    //This allows us to perform a single action in different ways.
    class Program
    {
        class Animal//Base class (Parent class)
        {
            //without the virtual keyword applied to the Base class method
            //THIS animal sound will override the Derived class methods
            public virtual void AnimalSound()
            {
                Console.WriteLine("The animal makes this sound!");
            }
        }

        class Cow : Animal//Derived class (Child class)
        {
            //adding the override keyword to Derived class methods
            //OUTPUT would be 'The cow goes, Shazoooo!'
            //without the override keyword, the OUTPUT would be
            //'The animal makes this sound' from the Base class method
            public override void AnimalSound()
            {
                Console.WriteLine("The cow goes, Shazoooo!");
            } 
        }

        class Duck : Animal//Derived class (Child class)
        {
            public override void AnimalSound()
            {
                Console.WriteLine("The duck..goes quack...and quackity quack...");
            }
        }

        static void Main(string[] args)
        {
            //Now we can create Cow and Duck objects and call the 
            //AnimalSound() method on both

            Animal myDuck = new Duck();
            Animal myCow = new Cow();
            myCow.AnimalSound();
            myDuck.AnimalSound();
        }
        //C# provides an option to override the base class method, by adding the virtual 
        //keyword to the method inside the base class, and by using the override keyword 
        //for each derived class methods:
    }
}
