// See https://aka.ms/new-console-template for more information
// to run this application in the console, use the command: dotnet run
Console.WriteLine("Let's play a game of guess the number! I'm thinking of a number between 1 and 2. Can you guess what it is?");
Random random  = new Random();
int secretNumber = random.Next(1, 3);
string guess = Console.ReadLine();

int guessInt = int.Parse(guess);


if (guessInt == secretNumber)
{
    Console.WriteLine("Congratulations! You guessed the number!");
}
else
{
    Console.WriteLine($"Sorry, the number I was thinking of was {secretNumber}. Better luck next time!");
}
    
