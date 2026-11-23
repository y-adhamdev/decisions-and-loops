System.Console.Write("Son kiriting: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Son kiriting: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    System.Console.WriteLine($"Kattasi: {num1}");
}
else if(num1 < num2)
{
    System.Console.WriteLine($"Kattasi: {num2}");

}
else
{
    System.Console.WriteLine($"Raqamlar teng");
    
}