
// Mini Login

string username, password;
// Start
Console.WriteLine("Enter an username");
username = Console.ReadLine() ?? "";


// Checks if password checks the requirements and it repeats until password >= 8
do
{
    Console.WriteLine("Enter a password (It must contain at least 8 digits): ");
    password = Console.ReadLine() ?? "";

    if (password.Length < 8)
    {
        Console.WriteLine("Invalid password");
    }

} while (password.Length < 8);

Console.WriteLine("Login successful!");
