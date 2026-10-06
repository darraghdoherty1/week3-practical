using week3_practical;
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(1, "John Doe", 15);
        Student student2 = new Student(2, "Jane Smith", 16);

        student.DisplayStudentInfo();
        student2.DisplayStudentInfo();

        int GetOlder = student.GetOlder(student.Age);
        student.Age = GetOlder;
        student.DisplayStudentInfo();
        Console.WriteLine($"Student {student.StudentName} is now {GetOlder}.");

    }
}

