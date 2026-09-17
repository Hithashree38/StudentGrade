using System;
class Program
{
    static void Main()
    {
        Student student1 = new Student(
            1,
            "Rahul",
            new int[] { 85, 90, 78, 87, 94 }
        );
        Student student2 = new Student(
            2,
            "Ananya",
            new int[] { 70, 81, 75, 80, 77 }
        );
        Student student3 = new Student(
            2,
            "Anu",
            new int[] { 55, 80, 61, 58, 77 }
        );
        student1.DisplayDetails();
        student2.DisplayDetails();
        student3.DisplayDetails();
    }


}