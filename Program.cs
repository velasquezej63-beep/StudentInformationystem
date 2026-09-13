using System;

class Program
{
    static void Main()
    {
        string name;
        int age;
        string course;
        string studentNumber;

        Console.WriteLine("===== STUDENT INFORMATION SYSTEM =====");

        Console.Write("Enter student number: ");
        studentNumber = Console.ReadLine();

        Console.Write("Enter student name: ");
        name = Console.ReadLine();

        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter course: ");
        course = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("===== STUDENT INFORMATION =====");
        Console.WriteLine("Student Number: " + studentNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Course: " + course);

        Console.WriteLine();
        Console.WriteLine("Student information saved successfully!");
    }
}
