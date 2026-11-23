System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for(int i = 1; i <= num; i++)
{
   sum *= i;
}
System.Console.WriteLine(sum);