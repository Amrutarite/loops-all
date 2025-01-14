//updated code with better optimization and time complexity
using System;
using System.Collections.Generic;

public class CombinedFunctionality
{
    public static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.WriteLine("Welcome to the Combined Functionality Program!");
            Console.WriteLine("1. Quiz Game");
            Console.WriteLine("2. Student Grading System");
            Console.WriteLine("3. User Email System");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option (1-4): ");

            string input = Console.ReadLine();
            int choice = int.TryParse(input, out int result) ? result : 0;

            switch (choice)
            {
                case 1:
                    RunQuizGame();
                    break;

                case 2:
                    RunStudentGradingSystem();
                    break;

                case 3:
                    RunUserEmailSystem();
                    break;

                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RunQuizGame()
    {
        string[] questions = {
            "What is the capital of France?",
            "Which programming language is used in this example?",
            "What is 2 + 2?"
        };

        string[,] options = {
            {"1. Berlin", "2. Madrid", "3. Paris", "4. Rome"},
            {"1. Python", "2. C#", "3. Java", "4. JavaScript"},
            {"1. 3", "2. 4", "3. 5", "4. 6"}
        };

        string[] correctAnswers = { "3", "2", "2" };
        int currentQuestion = 0;
        int score = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("Quiz Game\n");
            Console.WriteLine(questions[currentQuestion]);

            // Print options for the current question
            for (int i = 0; i < options.GetLength(1); i++)
            {
                Console.WriteLine(options[currentQuestion, i]);
            }

            Console.Write("\nEnter your choice (1-4): ");
            string userAnswer = Console.ReadLine();

            // Check the answer and update the score
            if (userAnswer == correctAnswers[currentQuestion])
            {
                Console.WriteLine("\nCorrect Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("\nWrong Answer!");
            }

            Console.WriteLine($"Your current score: {score}\n");
            currentQuestion++;

            if (currentQuestion >= questions.Length)
            {
                Console.WriteLine("\nYou have completed the quiz!");
                break;
            }

            Console.WriteLine("Do you want to continue? (y/n): ");
            string continueGame = Console.ReadLine();
            if (continueGame.ToLower() != "y")
            {
                break;
            }

        } while (true);

        Console.WriteLine($"\nYour Final Score: {score}/{questions.Length}");
        Console.WriteLine("Thank you for playing!");
        Console.WriteLine("\nReturning to the main menu...");
        // Wait for user input before returning to the menu
        Console.ReadKey();
    }

    static void RunStudentGradingSystem()
    {
        List<Student> students = new List<Student>
        {
            new Student("John", 85),
            new Student("Emma", 92),
            new Student("Alex", 70),
            new Student("Sophia", 60),
            new Student("Michael", 95)
        };

        double totalGrade = 0;

        foreach (var student in students)
        {
            totalGrade += student.Grade;
        }

        double averageGrade = totalGrade / students.Count;
        Console.WriteLine($"The average grade of all students is: {averageGrade:N2}\n");

        foreach (var student in students)
        {
            string result = student.Grade >= 70 ? "Passed" : "Failed";
            Console.WriteLine($"{student.Name}: {student.Grade} - {result}");
        }
    }

    static void RunUserEmailSystem()
    {
        List<UserEmailSystem> users = new List<UserEmailSystem>
        {
            new UserEmailSystem("Alice", "alice@example.com"),
            new UserEmailSystem("Bob", "bob@example.com"),
            new UserEmailSystem("Charlie", "charlie@example.com")
        };

        string message = "Hello, this is a notification from our system....";

        foreach (var user in users)
        {
            SendEmail(user, message);
        }
    }

    static void SendEmail(UserEmailSystem user, string message)
    {
        Console.WriteLine($"Sending email to {user.Name} ({user.Email})...");
        Console.WriteLine($"Message: {message}\n");
    }
}

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}

public class UserEmailSystem
{
    public string Name { get; set; }
    public string Email { get; set; }
    public UserEmailSystem(string name, string email)
    {
        Name = name;
        Email = email;
    }
}
