using System;

class Geeks
{

    // data members
    public string name;
    public string subject;

    // public method
    public void details(string name, string subject)
    {
        this.name = name;
        this.subject = subject;
        Console.WriteLine("Myself: " + name);
        Console.WriteLine("My Favorite Subject is: " + subject);
    }
}

// Driver class
class GFG
{

    // Main Method
    static void Main1(string[] args)
    {

        // creating object of Geeks class
        Geeks g = new Geeks();

        // Calling the method of Geeks class
        g.details("Ankita", "C#");

        // Calling "mymethod()" gives error
        // because this method does not 
        // belong to class Geeks or compiler 
        // does not know mymethod() at compile time
        //g.mymethod();
    }
    
    // Dynamic Binding
    static void Main()
    {
        // Dynamic objects
        dynamic obj = 4;
        dynamic obj1 = 5.678;

        // Display the type of objects
        Console.WriteLine("The type of the objects are :");

        // GetType() method is 
        // used to get the type
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj1.GetType());
    }

}