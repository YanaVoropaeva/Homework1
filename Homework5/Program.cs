// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size)
// {
//     int[] result = new int[size];
//     for (int count = 0; count < size; count++)
//     {
//         result[count] = new Random().Next(100, 1000);
//     }
//     return result;
// }
// void ShowEven(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }

//     }
//     Console.Write("Колличество четных чисел " + count);
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// int[] a = CreateRandomArray(100);
// ShowArray(a);
// Console.WriteLine($"");
// ShowEven(a);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine($"Введи длину массива: ");
// int ElementNumbers = Convert.ToInt32(Console.ReadLine()); 
// int randomNumber =  RandomNumbers(ElementNumbers, 1, 10);
// Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");



// int RandomNumbers(int ElementNumbers, int min, int max)
//   {
//   int[] randomNumber = new int[ElementNumbers];
//   int sumElements = 0;
//   Console.Write("Получившийся массив: ");

//     for (int i = 0; i <randomNumber.Length; i++ ){
//       randomNumber[i] = new Random().Next(min, max);

//       Console.Write(randomNumber[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumber[i];
//       }
//     }
//   return sumElements;
//   }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите длину массива  ");

// int size = Convert.ToInt32(Console.ReadLine());

// double[] number = new double[size];

// FillArrayRandomNumbers(number);

// Console.WriteLine("Массив: ");

// PrintArray(number);


// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int a = 0; a < number.Length; a++)
// {
//     if (number[a] > max)
//     {
//         max = number[a];
//     }
//     if (number[a] < min)
//     {
//         min = number[a];
//     }
// }

// Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
// Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");

// void FillArrayRandomNumbers(double[] number)
// {
//     for (int i = 0; i < number.Length; i++)
//     {
//         number[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
//     }
// }
// void PrintArray(double[] number)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < number.Length; i++)
//     {
//         Console.Write(number[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }