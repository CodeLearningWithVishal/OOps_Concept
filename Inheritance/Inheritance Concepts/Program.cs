// See https://aka.ms/new-console-template for more information
using Inheritance_Concepts.Multiple_inheritances_using_Interfaces;
using Inheritance_Concepts.Single_inheritance;

Console.WriteLine("1. Single inheritance");
Console.WriteLine("It is the type of inheritance in which there is one base class and one derived class.\n");
Debit debit = new Debit();
Console.WriteLine("Output: "+debit.Credit());
Console.WriteLine("\n");

Console.WriteLine("2. Hierarchical inheritance");
Console.WriteLine("This is the type of inheritance in which there are multiple classes derived from one base class.\n");
Console.WriteLine("");
Inheritance_Concepts.Hierarchical_inheritance.B b = new Inheritance_Concepts.Hierarchical_inheritance.B();
Console.WriteLine("Output: "+b.Information());
Inheritance_Concepts.Hierarchical_inheritance.C c = new Inheritance_Concepts.Hierarchical_inheritance.C();
Console.WriteLine("Output: " + c.Information());
Console.WriteLine("\n");

Console.WriteLine("3. Multilevel inheritance");
Console.WriteLine("When one class is derived from another, this type of inheritance is called multilevel inheritance.\n");
Inheritance_Concepts.Multilevel_inheritance.B bb = new Inheritance_Concepts.Multilevel_inheritance.B();
Console.WriteLine("Output: " + bb.MessageB());

Inheritance_Concepts.Multilevel_inheritance.C cc = new Inheritance_Concepts.Multilevel_inheritance.C();
Console.WriteLine("Output: " + cc.MessageC());
Console.WriteLine("\n");


Console.WriteLine("4. Multiple inheritances using Interfaces");
Console.WriteLine("C# does not support multiple inheritances of classes. To overcome this problem, we can use interfaces.\n");

Employee employee = new Employee();
Console.WriteLine("Output: " + employee.Name());
Console.WriteLine("Output: " + employee.Salary());
Console.WriteLine("\n");

Console.ReadLine();

