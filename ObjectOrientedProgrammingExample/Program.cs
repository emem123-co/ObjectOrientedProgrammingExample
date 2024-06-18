namespace ObjectOrientedProgrammingExample;

internal class Program
{
    static void Main(string[] args)
    {
    SUV suv = new SUV();
    suv.Print();
    }
}

public class Vehicle
    {
    public int NbrOfWheels {get; set;} = 4;
    public bool SlidingDoor {get; set;} = true;
    public int NbrOfPassagers {get; set;} = 7;
    public void Print(int nbr, string message) {}
    public void Print(string message) {} 

    public Vehicle() //when you have a constructor in the inherited class 
        {
        Console.WriteLine("Vehicle Constructor");
        }
    }

public class SUV : Vehicle //this will hold all properties of the above class, the one that is referenced here. In other words, everything in the inherited class is going to be relevent in this class. use this to not have to recreate an entirely new class for SUV. 
{
    public SUV()
    {
        Print("ABC"); //knows to use the one that only calls for a string.
    }

    public SUV() : base() 
    {
        Console.WriteLine("SUV Constructor"); //vhicle constructor will happen first, then the SUV constructor. Make sure you include the constructor from the inherited class or else it will not deploy. 
    }
}

//whne you are inheriting from one class to a new class, all things that are not private in the inherited class will appear in the new class.