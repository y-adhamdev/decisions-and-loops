System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for(int i = 2; i <= num; i++)
{
    if(i % 2 == 0)
    {
        System.Console.Write(i+ " ");
        sum += i;
    }
}
if(sum == 0)
{
    System.Console.WriteLine("Juft son mavjud emas");
    System.Console.WriteLine("Yig'gindi: 0");
}
else
{
    System.Console.WriteLine("\nYig'indi: "+ sum);
}