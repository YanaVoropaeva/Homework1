// Console.WriteLine("Input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 < num2)
// {
//     Console.WriteLine($"{num2} является максимальным");
// }
// else
// {
//     Console.WriteLine($"{num1} является максимальным");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input three number:");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 && num1 > num3) 
// {
//     Console.WriteLine($"{num1} является максимальным");
// }   
// else
//     if(num2 >num3)
//     {
//         Console.WriteLine($"{num2} является максимальным");
//     }
//     else
//     {
//         Console.WriteLine($"{num3} является максимальным");
//     }

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на 
// два без остатка).

// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// int ed = n % 2;
// if(ed == 0)
// {
//     Console.WriteLine($"{n} является четным");
// } 
// else
// {
//     Console.WriteLine($"{n} является нечетным");
// }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Input N");
// int n = Convert.ToInt32(Console.ReadLine());

// int evenNumber = 2;

// if(n > 1)
// {
//     while(evenNumber <= n)
//     {
//         Console.WriteLine(evenNumber + " ");
//         evenNumber = evenNumber + 2;
//     }
// }