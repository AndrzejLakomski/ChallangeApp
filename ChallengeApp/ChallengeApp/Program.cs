﻿var name = "Ewa";
bool isWoman = false;
var age = 16;

if (isWoman && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (isWoman && name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (!isWoman && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}