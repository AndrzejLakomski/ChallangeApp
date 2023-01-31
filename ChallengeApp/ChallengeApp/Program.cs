
int number = 112333600;
string numberAsString = number.ToString();
char[] signs = numberAsString.ToArray();

List<char> numbers = new List<char>();

numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

Console.WriteLine("Sprawdzana liczba to " + number);

foreach (var sign in numbers)
{
    var count = 0;
    foreach (var number2 in signs)
    {
        if (sign == number2) count++;
    }
    Console.WriteLine("Cyfra " + sign + " => " + count);
}