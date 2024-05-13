
int points = 0;

string userInput = "";

bool running = true;

void Run()
{
    Console.WriteLine("Welcome to the crocodile game!");

    while (running)
    {
        Random rand = new Random();

        int num1 = rand.Next(0, 12);
        int num2 = rand.Next(0, 12);

        Console.WriteLine("Please write the correct sign( <, > or =)");
        Console.WriteLine($"{num1}_{num2}");
        userInput = Console.ReadLine();
        CheckInput(num1, num2);
        CheckPoints();
    }
}

void CheckInput(int num1, int num2)
{
    if (userInput == "<" && num1<num2 ||
        userInput == "=" && num1==num2 ||
        userInput == ">" && num1> num2)
    {
        points++;
        Console.WriteLine($"Correct! Your new score is: {points}");
    }
    else if (userInput != "<" &&
             userInput != "=" &&
             userInput != ">")
    {
        Console.WriteLine("Not valid symbol, game over!");
        running = false;
    }
    else if (points > 0)
    {
        points--;
        Console.WriteLine($"Incorrect! Your new score is: {points}");
    }
}

void CheckPoints()
{
    
    if (points < 0)
    {
        Console.WriteLine("Your score is below zero. Game over!");
        running = false;
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Next round!");
        running = true;
    }
}

Run();

