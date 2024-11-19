# C# Tech WorkShop #1

This repo is for a techworkshop only. 

Quick introduction on csharp 

## Learning Objectives

- Learn how C# works and how to use Visual Studio (which they should have investigated briefly on their own already)
- Create and run a simple console app
- Learn/refresh some OOP concepts:
    - Polymorphism
    - Encapsulation
    - Abstractions
    - Interfaces


## Relevant links

- DataTypes: [`https://www.w3schools.com/cs/cs_data_types.php`](https://www.w3schools.com/cs/cs_data_types.php)
- Abstraction [`https://www.w3schools.com/cs/cs_abstract.php`](`https://www.w3schools.com/cs/cs_abstract.php`)
- Interfaces [`https://www.w3schools.com/cs/cs_interface.php`](`https://www.w3schools.com/cs/cs_interface.php`)
- Inheritance [`https://www.w3schools.com/cs/cs_inheritance.php`](`https://www.w3schools.com/cs/cs_inheritance.php`)
- Type Casting [`https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions`](`https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions`)
- Method Overloading [`https://www.w3schools.com/cs/cs_method_overloading.php`](`https://www.w3schools.com/cs/cs_method_overloading.php`)

## Exercise

- Create a new commandline Project. (Add to existing Solution)
- Create a folder in that project called Models
- Create a good example of OOP using Shapes as classes


- Program.cs
```csharp
Shape myShape = new Circle(5);
myShape.DisplayType(); 
Console.WriteLine($"Area: {myShape.CalculateArea()}");
```

Other files
```csharp
public abstract class Shape
{
    public abstract double CalculateArea();

    public void DisplayType()
    {
        Console.WriteLine("This is a shape calss.");
    }
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius; 
    }
}

public class Square : Shape
{
    //Implement this class.
}
```

