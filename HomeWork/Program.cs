Console.WriteLine("Введите число 1");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32 (Console.ReadLine());

if (a == b)
{
Console.WriteLine(" Числа равны ");
}
 else
 {
if (a > b)
{
     Console.WriteLine("Большее число - " + a );
     Console.WriteLine("Меньшее число - " + b );
}
else
{
     Console.WriteLine("Большее число - " + b);
     Console.WriteLine("Меньшее число - " + a);
}
}



