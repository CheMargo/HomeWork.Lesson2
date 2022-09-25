/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет./

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int NumberEntry ()
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void SliceNumber(int num)
{
    string a = Convert.ToString(num);
    if (a.Length<3) 
    {
    Console.WriteLine("третьей цифры нет");
    }      
    else
    {
        string b = Convert.ToString(a[2]);
        int result = Convert.ToInt32(b);
        Console.WriteLine("Третья цифра - " + result);
    }
}


int number = NumberEntry();
SliceNumber(number);