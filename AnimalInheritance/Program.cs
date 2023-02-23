using System.Runtime.CompilerServices;

class Animal
{
    private string name; 
    protected string type; 
    public string color; 

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}

class Raven : Animal
{
    public string appendage;  
    protected string speed;  

    public void setSpeed(string speed)
    {
        this.speed = speed;
    }
    public void setAppendage(string appendage)
    {
        this.appendage = appendage;
    }
    public virtual int getAppendage(int appendage)
    {
        return appendage;
    }

    public override string getName()
    {
        return base.getName();
    }

    public override string getType()
    {
        return type;
    }

}
class Program
{

    static void Main(string[] args)
    {

        Animal horse = new Animal();
        horse.setName("Jessie");
        horse.setType("Horse");
        horse.color = "Brown";

        Console.WriteLine("Animal Information...");
        Console.WriteLine($"My name is {horse.getName()}");
        Console.WriteLine($"I am a {horse.getType()}");
        Console.WriteLine($"I am a lovely {horse.color} color");
        Console.WriteLine();


        Raven piggy = new Raven();
        piggy.setName("Davito");
        piggy.setType("Raven");
        piggy.color = "Black";
        piggy.setAppendage("Talons");
        piggy.setSpeed("15Mph");

        Console.WriteLine("Raven Information");
        Console.WriteLine($"My name is {piggy.getName()}");
        Console.WriteLine($"I am a {piggy.getType()}");
        Console.WriteLine($"I can travel at {piggy.setSpeed}");
        Console.WriteLine($"I am a lovely {piggy.color} color");
        Console.WriteLine($"I am {piggy.getAppendage} years old");

        Console.ReadLine();
    }

}
