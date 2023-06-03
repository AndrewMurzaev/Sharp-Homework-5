// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
//  числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// int GetLength()
// {
//     Console.WriteLine("Input a length: ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     return length;
// }

// int SearchEvenNumbers(int[] array)
// {
//     int value = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2==0) value++;
//     }
//     return value;
// }
// int length = GetLength();
// int[] array = GetArray(length);

// string arrayToStr = String.Join(", ", array);
// Console.WriteLine(arrayToStr);
// int value = SearchEvenNumbers(array);
// System.Console.WriteLine(value);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите
//  сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GetArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(0, 10 );
//     }
//     return array;
// }

// int GetLength()
// {
//     Console.WriteLine("Input a length: ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     return length;
// }

// int SumOddsElements(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }
// int length = GetLength();
// int[] array = GetArray(length);

// string arrayToStr = String.Join(", ", array);
// Console.WriteLine(arrayToStr);
// int sum = SumOddsElements(array);
// System.Console.WriteLine(sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] GetArray(int length)
// {
//     double[] array = new double[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(0, 10) + new Random().NextDouble();
//     }
//     return array;
// }

// int GetLength()
// {
//     Console.WriteLine("Input a length: ");
//     int length = Convert.ToInt32(Console.ReadLine());
//     return length;
// }
// double Difference(double [] array)
// {
//     double count = 0;
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max) max = array[i];
//         if(array[i] < min) min = array[i];
//     }
//     count = max - min;
//     return count;
// }
// int length = GetLength();
// double[] array = GetArray(length);

// string arrayToStr = String.Join(", ", array); // Как округлить в массиве?
// Console.WriteLine(arrayToStr);
// double difference = Difference(array);
// Console.WriteLine(Math.Round(difference,3));

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


// int[] array = new int[123];
// void GetArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 1000);
//     }
// }
// int CountNumbersInRange(int[] array, int min, int max)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (min <= array[i] && array[i] <= max)
//         {
//             counter++;
//         }
//     }
//     return counter;
// }
//  GetArray(array);
//  string arrayToStr = String.Join(", ", array);
//  Console.WriteLine(arrayToStr);
// int count = CountNumbersInRange(array, 10, 99);
// Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int GetLength()
{
    Console.WriteLine("Input a length: ");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}
int[] MultiplyPairs(int[] array)
{
    int firstPointer = 0;
    int secondPointer = array.Length - 1;
    int pairPointer = 0;
    int[] pairsMultiply = new int[(array.Length + 1) / 2];

    while (firstPointer < secondPointer)
    {
        pairsMultiply[pairPointer] = array[firstPointer] * array[secondPointer];
        firstPointer++;
        secondPointer--;
        pairPointer++;
    }
    if (firstPointer == secondPointer)
    {
        pairsMultiply[pairPointer] = array[firstPointer];
    }
    return pairsMultiply;
}

int length = GetLength();
int[] array = GetArray(length);

string arrayToStr = String.Join(", ", array);
Console.WriteLine(arrayToStr);
string multiplication = String.Join(", ",MultiplyPairs(array));
Console.WriteLine(multiplication);