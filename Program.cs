string username;
string password;


Console.WriteLine("Enter an username");
username = Console.ReadLine();

Console.WriteLine("Enter a password (It must contain at least 8 digits): ");
password = Console.ReadLine();

if (password.Length >= 8)
{
    Console.WriteLine("Login successful!");
}

else
{
    Console.WriteLine("Invalid password!");
}