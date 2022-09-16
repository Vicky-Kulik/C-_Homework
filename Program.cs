// Задача на вывод всех четных чисел от 1 до N
// введение чисел
Console.Write("Введите число: ") ;
int num = int.Parse(Console.ReadLine ()) ;
int result = num;

if (num %2 == 0)
{   
    while (result > 0) {
    Console.WriteLine(result);
    result = result-2 ;
    }
}
else
{   result = num-1;
    while (result > 0) {
    Console.WriteLine(result);
    result = result-2 ;
    }
}