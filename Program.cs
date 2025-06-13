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

        static List<int> GetStudentScores()
        {
            List<int> scores = new List<int>();
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Enter score #{i}: ");
                bool valid = int.TryParse(Console.ReadLine(), out int score);
                if (valid && score >= 0 && score <= 100)
                {
                    scores.Add(score);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    i--; // repeat the same score
                }
            }
            return scores;
        }

    }
}
