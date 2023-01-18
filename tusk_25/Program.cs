//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

double getUserNumber(string massege)
{
    Console.WriteLine(massege);
    double UserNumber = double.Parse(Console.ReadLine()!);
    return UserNumber;
}

double Degree(double grounds, double index)
{
    double result = Math.Pow(grounds, index);
    return result;
}

double number_A = getUserNumber("Введите число А");
double number_B = getUserNumber("Введите число В");

double Result = Degree(number_A, number_B);
Console.WriteLine($"Число {number_A} в степени {number_B} равно {Result}");
