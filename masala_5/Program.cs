System.Console.Write("Son kiriting: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Son kiriting: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Arifmetik amal kiriting:(+,-,*,/)");
string? amal = Console.ReadLine();

switch (amal)
{
    case "+":
        System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case "-":
        System.Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case "/":
        System.Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;
    case "*":
        System.Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
}