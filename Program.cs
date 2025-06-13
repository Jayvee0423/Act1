using System;
using System.Collections.Generic;

namespace Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowHeader();

            string choice = "Y";

            while (choice.ToUpper() == "Y")
            {
                string name = GetStudentName();
                List<int> scores = GetStudentScores();

                double average = CalculateAverage(scores);
                string remarks = GetRemarks(average);

                DisplayResult(name, average, remarks);

                Console.Write("\nDo you want to enter another student? (Y/N): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Program ended. Press any key to close.");
            Console.ReadKey();
        }

        static void ShowHeader()
        {
            Console.WriteLine("===== Student Grading System =====\n");
        }

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

        static double CalculateAverage(List<int> scores)
        {
            int total = 0;
            foreach (int score in scores)
            {
                total += score;
            }
            return (double)total / scores.Count;
        }

        static string GetRemarks(double average)
        {
            if (average >= 90) return "Excellent";
            else if (average >= 75) return "Passed";
            else return "Failed";
        }

        static void DisplayResult(string name, double average, string remarks)
        {
            Console.WriteLine("\n--- Result ---");
            Console.WriteLine($"Student: {name}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Remarks: {remarks}");
        }
    }
}
