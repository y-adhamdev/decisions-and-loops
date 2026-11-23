System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());

bool isValid = true;

for(int i = 2; i < num -1; i++)
{
    if(num % i == 0)
    {
        isValid = false;
        break;
    }
}
if (isValid)
{
    System.Console.WriteLine("Tub son");
}
else
{
    System.Console.WriteLine("Tub son emas");
}