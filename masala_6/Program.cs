System.Console.Write("birinchi tomonni kiriting: ");
double side1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("ikkinchi tomonni kiriting: ");
double side2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("uchinchi tomonni kiriting: ");
double side3 = Convert.ToDouble(Console.ReadLine());

if(side1 + side2 > side3 || side1 < side2 + side3 || side3 + side1 > side2)
{
    if(side1 == side2 && side2 == side3)
    {
        System.Console.WriteLine("Teng tomonli uchburchak");
    }
    else if(side1 == side2 || side2 == side3 || side1 == side3)
    {
        System.Console.WriteLine("Teng yonli uchburchak");
    }
    else
    {
        System.Console.WriteLine("Turli tomonli uchburchak");
    }
}
else
{
    System.Console.WriteLine("Ushbu tomonlardan uchburchak yasab bo'lmaydi.");
}