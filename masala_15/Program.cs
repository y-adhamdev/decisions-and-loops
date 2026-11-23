System.Console.Write("Butun son kiriting: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(num > 0){
    sum += num % 10;
    num /= 10;
}
System.Console.WriteLine(sum);