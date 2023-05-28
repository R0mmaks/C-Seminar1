// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.
// Console.WriteLine("Введите число");

// int num=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");

// int num2=Convert.ToInt32(Console.ReadLine());

// if(num==num2)
// {
//     Console.WriteLine("числа равны, попробуйте ввести другие числа");
// }
// else if(num>num2)
// {
//     Console.WriteLine(num + " - max");
// }
// else
// {
//     Console.WriteLine(num2 + " - max");
// }

// ___________________________
// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Введите число");

// int num=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");

// int num2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");

// int num3=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Max(num, Math.Max(num2, num3)));

// ______________Второй вариант решения задачи4

// Console.WriteLine("Введите число");

// int num=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");

// int num2=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");

// int num3=Convert.ToInt32(Console.ReadLine());

// if (num > num2)
//     {
//         if (num > num3)
//         {
//             Console.Write(num + " наибольшее");
//         }
//         else
//         {
//             Console.Write(num3 + " наибольшее");
//         }
//     }
//     else if (num2 > num3)
//         Console.Write(num2 + " наибольшее");
//     else
//         Console.Write(num3 + " наибольшее");

// ________________________________________
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).
// Console.WriteLine("Введите число");

// int num=Convert.ToInt32(Console.ReadLine());

// if (num%2==0)
// {
//     Console.Write("четное");
// }
// else
// {
//     Console.Write("нечетное");
// }
// _________________________
// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");

int num=Convert.ToInt32(Console.ReadLine());

int num2=2;

while (num2<num)
{
Console.Write(num2 +", ");
num2=num2+2;
}

