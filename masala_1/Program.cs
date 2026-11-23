System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0)
{
    System.Console.WriteLine("Kiritilgan son musbat\n");
}else if(num < 0)
{
    System.Console.WriteLine("Kiritilgan son manfiy");
}
else
{
    System.Console.WriteLine("Kiritilgan son nolga teng");
}