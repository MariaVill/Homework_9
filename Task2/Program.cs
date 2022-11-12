// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int M = InputText("Введите число M: ");
int N = InputText("Введите число N: ");
while (M > N)
{
    Console.WriteLine("Число M должно быть меньше числа N");
    M = InputText("Введите число M: ");
    N = InputText("Введите число N: ");
}

Console.WriteLine($"Сумма чисел от {M} до {N} = {SumElements(M, N)}");

int SumElements(int M, int N)
{
    int sum = 0;
    if (M == N) return N;
    else return sum += M + SumElements(M + 1, N);
}


int InputText(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
