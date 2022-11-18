Console.Write("Напиши свое имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "света")
{
   Console.WriteLine("Ура! Привет, Пузз!");
}
else
{
    Console.Write("Привет, душнила - ");
    Console.WriteLine(username);
}