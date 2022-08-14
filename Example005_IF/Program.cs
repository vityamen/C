Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "slava")
{
    Console.WriteLine("Добро пожаловать повелитель");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}