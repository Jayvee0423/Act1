using System;

namespace Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowHeader();

            Console.WriteLine("Feature 1: Base setup with header only.");
        }

        static void ShowHeader()
        {
            Console.WriteLine("===== Student Grading System =====\n");
        }
       
        string name = GetStudentName();
        Console.WriteLine($"Student: {name}");

        static string GetStudentName()
        {
            Console.Write("Enter student name: ");
            return Console.ReadLine();
        }

    }
}
