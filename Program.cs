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

/*
Console.WriteLine("Введите первое (минимальное) число диапазона");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе (масимальное) число диапазона");
int N = int.Parse(Console.ReadLine()!);

if (M > N || M == N) Console.WriteLine($"Первое число {M} должно быть строго меньше второго {N}, попробуйте снова");
else
{
    Console.WriteLine($"Сумма чисел от {M} до {N}  равна {SummOf(M,N)}");
}

// ------------------Метод 2 задача ------------------

int SummOf(int M, int N)
{
    if (M == N) return M;
    return (N + (SummOf(M, N - 1)));
}

*/

//Задача 68: Выполнить с помощью рекурсии.
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


Console.WriteLine("Введите первое неотрицательное число ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе неотрицательное число ");
int N = int.Parse(Console.ReadLine()!);

if (M < 0 || N < 0) Console.WriteLine($"Каждое число должно быть положительным");
else {Console.WriteLine($"Функция Аккермана {AckFunction(M,N)}");}

// ------------------Метод 3 задача ------------------

int AckFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckFunction(m - 1, 1);
  else return AckFunction(m - 1, AckFunction(m, n - 1));
}
