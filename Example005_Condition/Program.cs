Console.WriteLine("Introduceti numele utilizatorului: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Ura, MASHA!");
}
else
{
    Console.Write("Salut, ");
    Console.WriteLine(username);
}