Console.WriteLine ("введите три числа");
int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());
if (a>b && a>c) 
{Console.WriteLine ("Максиимальное число " +a);}
else if  (b>a&& b>c) 
{Console.WriteLine ("Максиимальное число " +b);}
else
{Console.WriteLine ("Максиимальное число " +c);}



