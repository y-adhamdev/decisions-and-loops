System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int sum = 0;
for(int i = 3; i <= num; i++)
{
   if(i % 3 == 0)
    {
        count++;
        sum += i;
    }
}
System.Console.WriteLine(count);
System.Console.WriteLine(sum);