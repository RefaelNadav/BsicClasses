// See https://aka.ms/new-console-template for more information

using BsicClasses;

Person person = new Person();
person.SetAge(1);
Console.WriteLine(person.GetAge());

Dog dog = new Dog("Poodle");
Console.WriteLine(dog.species());

MathOperations ops = new MathOperations();
Console.WriteLine(ops.Add(2, 3));

Book book = new Book();
book.SetTitle("Learning c#");
Console.WriteLine(book.GetTitle());
