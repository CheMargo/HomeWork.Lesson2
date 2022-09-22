/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int CreateNumber()
{
    int number = new Random().Next(100,1000);
    return number;
}

int SliceNumber(int number)
{
    int hundred = number/100;
    int Dec = (number % 100)/10;
    int Ed = number%10;
    Console.WriteLine("сотни - " + hundred + " Десятки - " + Dec + " Еденицы - " + Ed);
    return Dec;
   
}

int a = CreateNumber();
Console.WriteLine(a);
int consist = SliceNumber(a);
Console.WriteLine("Ответ - " + consist);