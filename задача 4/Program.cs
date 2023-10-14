// напишите программу , которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N 
System.Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int x = 1;

    while(x<N )
    {
        if (x%2==0)
        {
            Console.Write (x);
        
        }
        x++;
       
   }
    
System.Console.WriteLine("");