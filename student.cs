using System;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int[] Marks { get; set; }
    public Student(int id, string name, int[] marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public double CalculateAverage()
    {
        int total = 0;
        foreach (int mark in Marks)
        {
            total += mark;
        }

        return (double)total / Marks.Length;

    }
    public string GetGrade()

    {
        double average = CalculateAverage();

        if (average >= 90)
            return "A+";
        else if (average >= 80)
            return "A";
        else if (average >= 70)
            return "B";
        else if (average >= 60)
            return "C";
        else if (average >= 50)
            return "D";
        else
            return "F";

    }

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Average Marks: {CalculateAverage():F2}");
        Console.WriteLine($"Grade: {GetGrade()}");
        Console.WriteLine("------------");
    }




}