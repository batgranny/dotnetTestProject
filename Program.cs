 // Set up the game
Random randomPlayer1 = new Random();
Random randomPlayer2 = new Random();
int player1Total = 0;
int player2Total = 0;
List<int> rounds = new List<int>();
string playAgain = "y";

do
{
    int player1Score = randomPlayer1.Next(1,11);
    int player2Score = randomPlayer1.Next(1,11);
    Console.WriteLine("Player One: " + player1Score);
    Console.WriteLine("Player Two: " + player2Score);

    if (player1Score > player2Score)
    {
        Console.WriteLine("Player One wins!");
        player1Total ++;
        rounds.Add(player1Score);
    }
    else if (player1Score < player2Score)
    {
        Console.WriteLine("Player Two Wins");
        player2Total ++;
        rounds.Add(player2Score);
    }
    else
    {
        Console.WriteLine("It's a draw!");
    }

    Console.WriteLine("Would you like to play again? (y/n)");
    playAgain = Console.ReadLine(); 
}
while (playAgain == "y");

Console.WriteLine("Player one won " + player1Total + " games");
Console.WriteLine("Player one won " + player2Total + " games");

Console.WriteLine("total rounds played: " + rounds.Count);

if (player1Total > player2Total)
{
    Console.WriteLine("Congratulations player 1, you are the overall winner!");
}
else if (player1Total < player2Total)
{
    Console.WriteLine("Congratulations player two, you are the overall winner!");
}
else
    Console.WriteLine("well played all, it was a draw!");

int index = 1;
foreach (int round in rounds)
{
    Console.WriteLine($"Round {index}: {round}");
    index ++;
}

//new
string carReg = "ABC-123";

if (carReg.Length != 7)
{
    return false;
}

int i = 0;
do
{
    if (char.IsLetter(carReg[i]));
    {
        return true
        i++;
    }
}
while (i < 3);

if (carReg[4] != '-');
{
    return false
}

