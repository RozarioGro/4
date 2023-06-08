/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();
Console.Write("Enter number A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
double b = double.Parse(Console.ReadLine());
Console.Write($"число {a} в натуральной степени {b} -> {GetExp(a, b)}");
int GetExp(int n, double s)
{
    int exp = 1;
    for (int i = 0; i < s; i++){
        exp = exp * n;
    }
    return exp;
}