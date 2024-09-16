// See https://aka.ms/new-console-template for more information
using Encapsulation;

Console.WriteLine("Hello, World!");

Console.WriteLine("Encapsulation: ");
Console.WriteLine("the practice of bundling data and methods together into a single unit, such as a class.");
Console.WriteLine("We use different access modifier to restrict the access of the classes, methods, or variables as per required.");
Console.WriteLine("These are the access modifiers: Public, Private, Protected, Internal, Protected internal");
Console.WriteLine("\n");
Console.WriteLine("Please Note: In Calculation class, We declared 3 methods, Add with Public access specifier that we can call in Program.cs, other 2 methods have Sub with private, and Div with Protected identifier.");


Calculation cal = new Calculation();
Console.WriteLine("Output:"+ cal.Add(10, 15));
Console.ReadLine();
