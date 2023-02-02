using ChallengeApp;

User user1 = new User("Alojzy", "Pietruszka", 18);
User user2 = new User("Baltazar", "Gąbka", 46);
User user3 = new User("Mieszko", "Pierwszy", 148);

user1.AddPoint(1);
user1.AddPoint(2);
user1.AddPoint(5);
user2.AddPoint(6);
user2.AddPoint(3);
user2.AddPoint(1);
user3.AddPoint(21);
user3.AddPoint(1);
user3.AddPoint(4);

var result = user1.Result;

var result2 = user2.Result;

var result3 = user3.Result;

if (result > result2)
{
    Console.WriteLine("Najwyższy zdobyty wynik to " + result + ". Należy do pracownika " + user1.Name + " " + user1.Surname + ", lat " + user1.Age);
}
else if (result2 > result3 )
    {
    Console.WriteLine("Najwyższy zdobyty wynik to " + result2 + ". Należy do pracownika " + user2.Name + " " + user2.Surname + ", lat " + user2.Age);
    }
else
{ 
    Console.WriteLine("Najwyższy zdobyty wynik to " + result3 + ". Należy do pracownika " + user3.Name + " " + user3.Surname + ", lat " + user3.Age); 
}
