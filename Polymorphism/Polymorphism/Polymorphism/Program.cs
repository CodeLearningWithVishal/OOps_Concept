// See https://aka.ms/new-console-template for more information
using Polymorphism.Dynamic_RunTime_Polymorphism;
using Polymorphism.Static_CompileTime_Polymophism;

Console.WriteLine("Compile time polymorphism Started");

TestData dataClass = new TestData();
int add2 = dataClass.Add(45, 34, 67);
int add1 = dataClass.Add(23, 34);

Console.WriteLine("add1 Output: " + add1.ToString());
Console.WriteLine("add2 Output: " + add2.ToString());

Console.WriteLine("Compile time polymorphism End");

Console.WriteLine("Runtime polymorphism Started");

Drawing circle = new Circle();
Console.WriteLine("Area :" + circle.Area());

Drawing square = new Square();
Console.WriteLine("Area :" + square.Area());

Drawing rectangle = new Rectangle();
Console.WriteLine("Area :" + rectangle.Area());

Console.WriteLine("Runtime polymorphism End");
