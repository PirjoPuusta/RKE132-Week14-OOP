// Dog section
Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");


Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHappiness != 5) //Dog barks until it becomes happy
{
    myDog.Bark();
}

myDog.WagTail();
Console.WriteLine($"{myDog.Name} is now happy!");
Console.WriteLine(); // Empty line after dog section

// Visual separator
Console.WriteLine(new string('-', 30));
Console.WriteLine(); //Another empty line for clarity


// Cat section
Cat newCat = new Cat("Garfield", "ginger");

Console.WriteLine($"{newCat.Name} wants a rub on its belly.");

while (newCat.BellyFull > 0) // The cat sleeps until its belly gets empty
{
    newCat.Sleep();
}

newCat.Meow();
Console.WriteLine($"{newCat.Name} is now awake and hungry!");
Console.WriteLine("---- Cat Data ----");
newCat.ShowCatData();

// Dog class
class Dog
{
    private string _name; // Field for dog's name
    private int _levelOfHappiness; // Field for happiness level

    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHappiness = 0; //Happiness starts at 0
    }

    //Getter for the dog's name
    public string Name
    {
        get { return _name; }
    }

    // Getter for the dog's happiness level
    public int LevelOfHappiness
    {
        get { return _levelOfHappiness; }
    }

    // Method to rename the dog
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    // Method to make the dog bark and increase happiness
    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHappiness++;
    }

    // Method to make the dog wag its tail because the dog is happy now
    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }

}

// class Cat
class Cat
{
    private string _name; // Field for cat's name
    private string _color; // Field for cat's color
    private int _bellyFull; // Field for fullness level

    //Constructor
    public Cat(string name, string color)
    {
        _name = name;
        _color = color;
        _bellyFull = 10;
        Console.WriteLine($"A {_color} cat {_name} has been created.");
    }

    // Getter for the cat's name
    public string Name
    {
        get { return _name; }
    }

    // Getter for the cat's fullness level
    public int BellyFull
    {
        get { return _bellyFull; }
    }

    // Method to make the cat sleep and decrease fullness
    public void Sleep()
    {
        _bellyFull--;
        Console.WriteLine($"{_name} says: Z-z-z-z-z-z...");
    }

    // Method to make the cat meow because the cat is awake and hungry
    public void Meow()
    {
        Console.WriteLine($"{_name} says: Meow!");
    }

    // Method to display the cat's data
    public void ShowCatData()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Fullness level: {_bellyFull}");
    }

}