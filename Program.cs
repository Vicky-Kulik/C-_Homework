// Задача на нахождение наибольшего из двух чисел
// введение чисел
Console.Write("Введите первое число: ") ;
int number1 = int.Parse(Console.ReadLine ()) ;

Console.Write("Введите второе число: ") ;
int number2 = int.Parse(Console.ReadLine ()) ;

if (number1 > number2)
{
    Console.WriteLine($"Наибольшее число {number1}") ;
}
else
{
    Console.WriteLine($"Наибольшее число {number2}") ;
}

// Задача на нахождение наибольшего из трех чисел
// введение чисел
Console.Write("Введите первое число: ") ;
int num1 = int.Parse(Console.ReadLine ()) ;

Console.Write("Введите второе число: ") ;
int num2 = int.Parse(Console.ReadLine ()) ;

Console.Write("Введите третье число: ") ;
int num3 = int.Parse(Console.ReadLine ()) ;

int Mmax = 0;

if (num1 > num2) 
{
    Mmax = num1;
}
else
{
    Mmax = num2;
}
if ( num3 > Mmax)
{
    Mmax = num3;
}

Console.WriteLine($"Наибольшее число {Mmax}") ;