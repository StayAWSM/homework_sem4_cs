//---------Используемые методы------------
int Task(int arg1, int arg2) //Метод возведения в степень. Аналог Math.Pow
{
    int sum = 1;
    int i = 1;
    for (i = 1; i <= arg2; i++)
    {
        sum *= arg1;
    }
    return sum;
}
int Summer(int num) //Метод сложения цифр в числе
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
//ВАРИАНТ 2
// int Summer(int num)
// {
//     int result = 0;
//     for (; num > 0; num /= 10) result += num % 10;
//     return result;
// }

// Console.Write("Введите число N: "); //заменяем часть кода во второй задаче
// int num = Convert.ToInt32(Console.ReadLine() ?? "0");
// Console.WriteLine("Сумма цифр в числе: " + Summator(num));

void PrintArray(int[] array) //Метод печати массива
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + " ");
    Console.Write("]");
}
int[] FillArray() //Метод наполнения массива
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(1, 9)];

    int len = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }

    return array;
}
int[] Sorter(int[] array)
{
    int len = array.Length;
    int temp = 0;
    for (int i = 0; i < len; i++)
        for (int j = i; j < len; j++)
            if (array[j] < array[i])
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
    return array;
}


//------------Задачи---------------
void task1()
{
    //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16
    Console.Clear();
    Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.Write("Ввести число: ");
    int a = int.Parse(Console.ReadLine() ?? "0");
    int pow = 0;
    while (true)
    {
        Console.Write("Ввести степень для возведения: ");
        pow = Convert.ToInt32(Console.ReadLine());
        if (pow > 0)
            break;
        else
            Console.WriteLine("Степень должна быть целочисленной и больше 0");
    }

    // int b = Math.Abs(int.Parse(Console.ReadLine() ?? "0")); - как вариант для pow, при котором он сам делает отрицательные степени - положительными

    int sum = Task(a, pow);
    Console.WriteLine($"Результат равен {sum}");
}

void task2()
{
    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12
    //ВАРИАНТ 1

    Console.Clear();
    Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.Write("Введите число: ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    int sumNum = Summer(num);
    Console.WriteLine("Сумма цифр в числе: " + sumNum);
}

void task3()
{
    // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]
    Console.Clear();
    Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

    int[] anyArr = FillArray();

    PrintArray(anyArr);
    Console.WriteLine();
    PrintArray(Sorter(anyArr));
}


//------------Выполнение программы---------------
Console.WriteLine("Введите от 1 до 3: ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1: 
        task1();
        break;
    case 2:
        task2();
        break;
    case 3:
        task3();
        break;
}