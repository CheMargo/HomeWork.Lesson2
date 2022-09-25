/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int DayNumber ()
{
    Console.WriteLine("Введите номер дня недели");
    int day = Convert.ToInt32(Console.ReadLine());
    if (day > 0 && day < 8)
    {
        return day;
    }
    else
    {
        Console.WriteLine("Указано недопустимое значение");
        return -1;
    }
}

bool WeekendCheck(int day)
{
if (day > 5 && day <8)
    {
    return true;
    }
    else
    {
        return false;
    }
}

int dayN = DayNumber ();
if (dayN!=-1)
{
bool isWeekend = WeekendCheck(dayN);
if (isWeekend == true)
{
    Console.WriteLine("Выходной, можешь отдыхать!");
}
else
{
    Console.WriteLine("Иди работать, солнце еще высоко!"); 
}
}
else
{
    Console.WriteLine("Вы ввели не правильное число");
}