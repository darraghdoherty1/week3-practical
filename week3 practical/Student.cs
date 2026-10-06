using System;
using System.Collections.Generic;
using System.Text;

namespace week3_practical
{
    public class Student
    {
        private int studentID;
        private string studentName;
        private int age;
        private static int studentCount = 0;

        public int StudentID
        {
            get { return studentID; }
            private set { studentID = value; }
        }
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Student()
        {
            studentID = studentCount++;
            studentName = "John Doe";
            age = 16;
        }

        public Student(int id, string name, int age)
        {
            this.studentID = studentCount++;
            this.studentName = name;
            this.age = age;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Age: {age}");
        }
        public int GetOlder(int age)
        {
            age++;
            return age;
        }
    }
}
