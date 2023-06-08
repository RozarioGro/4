/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();
Console.WriteLine("Enter number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"сумму цифр в числе ->{num} равно {GetSum(num)}");

int GetSum(int n){
    int sum = 0;
    for (int i = 0; i <= n; i++){
        sum += n%10;
        n/=10;
    }
    return sum;

}
