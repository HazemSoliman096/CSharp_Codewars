# Kata 7

## Vectors #1

### Let's make this short!

    Remember, this is a kata which focuses on object oriented programming

    Task: Create a class Vector3D

    Properties: X, Y, Z and Length as double and public scope and accessors

    X, Y and Z will be set by test methods

    Length should only have an get-accessor which calculates the vector's length

    ##Some references, to get into the topic

    The length or magnitude or norm of the vector a is denoted by ‖a‖ or, less commonly, |a|, which is not to be confused with the absolute value (a scalar "norm").

    The length of the vector a can be computed with the Euclidean norm

    How to calculate a vector's length - Link created 2016/11/15
### Tests

    Final tests include 2 fixed and 125 random tests. They will look like this:
``` CSharp
    double length = new Vector3D()
    {
    X = 0,
    Y = 0,
    Z = 2
    }.Length;
    length == 2 // true
```

[Vectors #1](https://www.codewars.com/kata/582b079bbbbc74bed7000095)

---------------------------------------------------------------------------------------------

## Fun with ES6 Classes #2 - Animals and Inheritance

### Overview

    Preloaded for you in this Kata is a class Animal:

```CSharp
public class Animal
{
  public int Age;
  public int Legs;
  public string Name;
  public string Species;
  public string Status;
  
  public Animal(string name, int age, int legs, string species, string status)
  {
    this.Name = name;
    this.Age = age;
    this.Legs = legs;
    this.Species = species;
    this.Status = status;
  }
  
  public virtual string Introduce()
  {
    return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
  }
}
```
### Task
    Define the following classes that inherit from Animal.

1. Shark  

        The constructor function for Shark should accept 3 arguments in total in the following order: name, age, status. All sharks should have a leg count of 0 (since they obviously do not have any legs) and should have a species of "shark".

2. Cat  

        The constructor function for Cat should accept the same 3 arguments as with Shark: name, age, status. Cats should always have a leg count of 4 and a species of "cat".

        Furthermore, the introduce/Introduce method for Cat should be identical to the original except there should be exactly 2 spaces and the words "Meow meow!" after the phrase. For example:

    ```CSharp
    Cat example = new Cat("Example", 10, "Happy);
    example.Introduce() => "Hello, my name is Example and I am 10 years old.  Meow meow!"; // Notice the TWO spaces - very important.
    ```

3. Dog  

        The Dog constructor should accept 4 arguments in the specified order: name, age, status, master. master is the name of the dog's master which will be a string. Furthermore, dogs should have 4 legs and a species of "dog".

        Dogs have an identical introduce/Introduce method as any other animal, but they have their own method called greetMaster/GreetMaster which accepts no arguments and returns "Hello (insert_master_name_here)" (of course not the literal string but replace the (insert_master_name_here) with the name of the dog's master).

[Fun with ES6 Classes #2 - Animals and Inheritance](https://www.codewars.com/kata/56f935002e6c0d55fa000d92)
---------------------------------------------------------------------------------------------