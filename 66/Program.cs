// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

PrintInfo();
Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
int sum = 0;
Console.Write($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна ");
SumNaturalNumbers(numberM,numberN,sum);

void PrintInfo(){
    Console.WriteLine("Программа находит сумму натуральных элементов ");
    Console.WriteLine("в промежутке от M до N. Выполнено с помощью рекурсии");
}

void SumNaturalNumbers(int numberM, int numberN, int sum){
    if (numberM > numberN){
        Console.WriteLine($"{sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNaturalNumbers(numberM, numberN, sum);
}