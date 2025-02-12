// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("s test");
string myEnvVar = Environment.GetEnvironmentVariable("BRANCH_NAME");

// Display it or use it as needed
Console.WriteLine($"The envirsonment variable BRANCH_NAME is: {myEnvVar}");
Console.WriteLine($"BRANCH_NAME (from environment): {Environment.GetEnvironmentVariable("BRANCH_NAME")}");

Console.ReadLine();