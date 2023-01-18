//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int getUserNuber(string massege)
{
    Console.WriteLine(massege);
    int Number = int.Parse(Console.ReadLine()!);
    return Number;
}

int Sum(int number)
{
    int userNumber = number;
    int sum = 0;
    while (userNumber >= 1)
    {
        sum = sum + (userNumber % 10);
        userNumber = userNumber / 10;
    }
    return sum;
}

int num = getUserNuber("Введите число:");
int answer = Sum(num);

Console.WriteLine(answer);