Console.Write("Enter your name ");
string username = Console.ReadLine();

if (username.ToLower() == "mary")
{
    Console.WriteLine("Wow, it is Mary!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}