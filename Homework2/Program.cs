// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру 
// этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("введите трехзначное число");
// int number = Int32.Parse(Console.ReadLine());

// int GetSecondDigit(int digit)
// {
//     digit = digit/10%10;
//     return digit;
// }

// Console.WriteLine(GetSecondDigit(number));

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int GetThreeDigit(int digit)
// {
//     while (digit > 999)
//     {
//         digit /= 10;
//     }
//     return digit % 10;
// }

// bool ValidateNumber(int digit)
// {
//     if (digit < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }

// int digit = Prompt ("Введите число >");
// if (ValidateNumber(digit))
// {
//     Console.WriteLine(GetThreeDigit(digit));
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// bool IsDayOff(int number)
// {
//     return (number == 6 || number == 7);
// }
// Console.Write("Введите число ");
// int num = Int32.Parse(Console.ReadLine());
// if (IsDayOff(num)) Console.Write($"{num} -> да");
// else Console.Write($"{num} -> нет");