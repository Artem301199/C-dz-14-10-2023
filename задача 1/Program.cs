// напишите программу , где пользователь вводит 3  числа ,а на выходе показывает максимальное и минимальное
System.Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число : ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (a>b && a>c ) max = a;
if ( b>a && b>c ) max = b;
if (c>a && c>b) max=c;
if (a<b && a<c ) min = a;
if ( b<a && b<c ) min = b;
if (c<a && c<b) min =c;
{
    System.Console.Write("max = ");
    System.Console.WriteLine(max);
    System.Console.Write("min = ");
    System.Console.WriteLine(min);
}
