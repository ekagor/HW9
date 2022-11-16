// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все чётные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

PrintInfo();
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());
PrintEvenNumbersInterval(number);

void PrintInfo(){
    Console.WriteLine("Программа выводит все чётные числа в промежутке от N до 1");
    Console.WriteLine("Выполнено с помощью рекурсии");
}

void PrintEvenNumbersInterval(int number){
    if (number % 2 != 0)
    number = number-1;
    if (number == 0)
    return;
Console.Write($"{number}, ");
PrintEvenNumbersInterval(number - 2);  
}