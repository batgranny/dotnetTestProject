// See https://aka.ms/new-console-template for more information
// to run this application in the console, use the command: dotnet run
Console.WriteLine("Hello, World!");

int damage = 0;

while (damage < 10)
{
    Console.WriteLine($"Current damage: {damage}");
    damage += 2;
}

Console.WriteLine("Damage threshold reached!");

