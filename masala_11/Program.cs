System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i <= num; i++)
{
    if(i % 5 == 0)
    {
        System.Console.Write(i + " ");       
    }
}