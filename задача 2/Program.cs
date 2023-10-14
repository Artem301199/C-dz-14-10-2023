//написать программу , где пользователь вводит два числа , а на выходе получает значение (мин) и (макс) !
System.Console.WriteLine("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (a>b) max =a;
if (b>a) max = b;
if (a<b) min = a;
if(b<a)  min= b;
{
    System.Console.Write("max = ");
    System.Console.WriteLine(max);
    System.Console.Write("min = ");
    System.Console.WriteLine(min);
}