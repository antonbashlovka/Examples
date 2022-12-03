Console.Write("Введите ваше имя ");
string username = Console.ReadLine();
if (username.ToLower() == "маша"){
    Console.Write("Ура, это Маша");
}else{
    Console.Write("привет, " + username);
}

