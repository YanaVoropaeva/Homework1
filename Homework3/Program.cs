// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите 5значное число");
// int num = Convert.ToInt32(Console.ReadLine());

// bool PalindromNumber(int num)
// {
//     int a = num / 10000;
//     int b = num / 1000 % 10;
//     int c = num % 100 / 10;
//     int d = num % 10;
//     bool result = false;
//     if (a == d && c == b) result = true;

//     return result;
// }
// bool a = PalindromNumber(num);
// if (a)
// {
//     Console.WriteLine($"Число {num} является палиндромом");
// }
// else
// {
//     Console.WriteLine($"Число {num} не является палиндромом");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D 
//пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)), 2);
// }

// Console.WriteLine("Input coordinate X to A:");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to A:");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z to A:");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X to B:");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y to B:");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z to B:");
// double zb = Convert.ToDouble(Console.ReadLine());


// Console.WriteLine($"Distance between point A with coordinates ({xa},{ya},{za}) and point B with coordinates ({xb}, {yb},{zb})  -> {FindDistance(xa, ya, za, xb, yb, zb)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int count=1; count<=num; count++)
// {
//     Console.Write(Math.Pow(count, 3) + " ");
// }

