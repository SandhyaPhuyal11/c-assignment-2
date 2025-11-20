namespace task1;

using System;

class Student
{
    //three instance filed of student details
    public string Name;
    public int Age;
    public string Major;

    //static field for sharing all object of student
    public static string School = "IIC";
}

class ProgramTask1
{
    static void Main()
    {
        //two objects of students according to questions with two simple data
        Student s1 = new Student { Name = "Sandhya", Age = 21, Major = "IT" };
        Student s2 = new Student { Name = "Bhawana", Age = 22, Major = "Bsc Nursing" };


        Console.WriteLine("Student 1: {0}, Age: {1}, Major: {2}", s1.Name, s1.Age, s1.Major);
        Console.WriteLine("Student 2: {0}, Age: {1}, Major: {2}", s2.Name, s2.Age, s2.Major);

        //display school name(with shared static field)
        Console.WriteLine("School:" + Student.School);
    }
}
