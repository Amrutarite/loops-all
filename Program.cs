//updated code with better optimization and time complexity

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
        "What is 2 + 2?",
        "Who is the founder of Microsoft?",
        "What is the largest ocean in the world?"
    };

    string[,] options = {
        {"1. Berlin", "2. Madrid", "3. Paris", "4. Rome"},
        {"1. Python", "2. C#", "3. Java", "4. JavaScript"},
        {"1. 3", "2. 4", "3. 5", "4. 6"},
        {"1. Steve Jobs", "2. Bill Gates", "3. Mark Zuckerberg", "4. Elon Musk"},
        {"1. Atlantic", "2. Indian", "3. Arctic", "4. Pacific"}
    };

    string[] correctAnswers = { "3", "2", "2", "2", "4" };

    int currentQuestion = 0;
    int score = 0;

    while (currentQuestion < questions.Length)
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

        Console.WriteLine("Do you want to continue to the next question? (y/n): ");
        string? continueGame = Console.ReadLine();
        if (continueGame?.ToLower() != "y")
        {
            break;
        }
    }

    Console.WriteLine($"\nYour Final Score: {score}/{questions.Length}");
    Console.WriteLine("Thank you for playing!");
    Console.WriteLine("\nReturning to the main menu...");
    // Wait for user input before returning to the menu
    Console.ReadKey();
}
