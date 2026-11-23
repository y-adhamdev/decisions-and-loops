System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
   System.Console.WriteLine($"{num} x {i} = {num * i}");
}