// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
/*
Console.Write("Введи число: ");
int N  = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N,1));

// ------------------Метод 1 задача ------------------
string PrintNumbers(int start, int end){
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
} 
*/

// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите певрое (минимальное) число диапазона");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите втророе (масимальное) число диапазона");

int N = int.Parse(Console.ReadLine()!);

if (M > N)
    Console.WriteLine($"Первое число {M} не меньше второго {N}, попробуйте снова");
else
{
    Console.WriteLine($"Сумма чисел от {M} до {N}  равна {SummOf(N)}");
}

// ------------------Метод 1 задача ------------------

int SummOf(int N)
{
    if (M == N) return M;
    return (N + (SummOf(N - 1)));
}