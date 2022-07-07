Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "элена")
{
    Console.WriteLine("Ура, это же ЭЛЕНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
} 