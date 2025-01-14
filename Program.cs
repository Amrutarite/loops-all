//integrated functionality
//for loop,foreach loop ,while loop ,do-while loop ,switch cases.etc.
//(changes need to do it: 1)dont use true in while loop 2)user should go into main menu insted of break 3)try to add more database in quiz section )
using System;
using System.Collections.Generic;


public class CombinedFunctionality
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Combined Functionality Program!");
        Console.WriteLine("1. Quiz Game");
        Console.WriteLine("2. Student Grading System");
        Console.WriteLine("3. User Email System");
        Console.WriteLine("Choose an option (1-3): ");

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

            default:
                Console.WriteLine("Invalid choice. Exiting the program.");
                break;
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

            for (int i = 0; i < options.GetLength(1); i++)
            {
                Console.WriteLine(options[currentQuestion, i]);
            }

            Console.Write("\nEnter your choice (1-4): ");
            string userAnswer = Console.ReadLine();

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
            string? continueGame = Console.ReadLine();
            if (continueGame?.ToLower() != "y")
            {
                break;
            }
            //remove true 
        } while (true);

        Console.WriteLine($"\nYour Final Score: {score}/{questions.Length}");
        Console.WriteLine("Thank you for playing!");
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

        for (int i = 0; i < students.Count; i++)
        {
            totalGrade += students[i].Grade;
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
