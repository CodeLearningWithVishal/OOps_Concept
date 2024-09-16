// See https://aka.ms/new-console-template for more information
using Abstraction;

Console.WriteLine("Abstration: ");
Console.WriteLine("the process of hiding unnecessary details from the user and only revealing the essential features of an application.");
Console.WriteLine("abstraction class is incomplete, we have to complete by inheriting it to child class. \n");
Dog mydog = new Dog();
Console.WriteLine("Output: ");
mydog.eat();
mydog.sound();

Animal thePet = mydog;
thePet.eat();

Console.ReadLine();
