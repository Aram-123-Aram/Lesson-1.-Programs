/* Задача: Запросить у пользователья вводить свою имя. Если пользователя завут "Маша",
выводить сообщение: "Ура! Это наша Маша!".
В остольних случаях выводить сообщение: "Привет _имя пользователя_" */
Console.Write("Enter your name: ");
string username = Console.ReadLine()!;
if (username.ToLower() == "маша")
{Console.WriteLine("Ура!Это же наша " + username + "!"); }
else {Console.Write("Привет " + username +"!"); } 
