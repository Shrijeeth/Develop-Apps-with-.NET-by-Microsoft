Console.Write("What's your name? ");
string? name = Console.ReadLine();
string greeting = $"Welcome, {name?.ToUpper()}!";
Console.WriteLine(greeting);
