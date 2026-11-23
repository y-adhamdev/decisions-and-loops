System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 0; i <= num; i++)
{
   sum += i;
}
System.Console.WriteLine(sum);