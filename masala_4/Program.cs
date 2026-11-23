System.Console.Write("Butun son kiriting: ");
int ball = Convert.ToInt32(Console.ReadLine());

if(ball >= 90 && ball <= 100)
{
    System.Console.WriteLine("A'lo!");
}else if(ball >= 70 && ball <= 89)
{
    System.Console.WriteLine("Yaxshi.");
}else if(ball >= 60 && ball <= 69)
{
    System.Console.WriteLine("Qoniqarli.");
}else if (ball >= 0 && ball <= 59)
{
    System.Console.WriteLine("Qoniqarsiz.");
}