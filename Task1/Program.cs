// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = InputText("Введите число больше 1: ");
while (N < 1) N = InputText("Введите число больше 1: ");

Console.WriteLine(NumbersFor(N));

int InputText(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

string NumbersFor(int N)
{
    if (N == 1) return "1";
    else return N + "," + NumbersFor(N - 1);
}

