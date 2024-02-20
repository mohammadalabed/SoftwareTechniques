// See https://aka.ms/new-console-template for more information
using language_tools;


Student student= new Student();
student.SetName("Mohammad");
Console.WriteLine(student.GetName()); 

//student.Age= 10;
student.Age = -10;
student.Age = 20;
Console.WriteLine(student.Age);
Console.WriteLine(student.YearOfBirht);