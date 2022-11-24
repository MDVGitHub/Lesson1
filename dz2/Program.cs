//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int Number1 = new int();
int Number2 = new int();
int Number3 = new int();
//int max = Number1;
Console.WriteLine("Введите число1");
Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число2");
Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число3");
Number3 = Convert.ToInt32(Console.ReadLine());
int max = Number1;
if      (Number2 > max)        {max = Number2;}
if      (Number3 > max)        {max = Number3;}
Console.WriteLine(max);