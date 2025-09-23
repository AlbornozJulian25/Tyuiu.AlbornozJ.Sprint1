// See https://aka.ms/new-console-template for more information
using Tyuiu.AlbornozJ.Sprint1.Task0.V0.Lib;
//ЗАДАНИЕ
//Написать программу, которая вычисляет 10 / (2 + 3) и печатает результат на экране.
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hello, World!");
DataService ds  = new DataService();

Console.Title = "Спринт #1 | Выполнил: Альборноз Г. Х. Х. | ИИПб-25-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: базовые навыки работи в C#                                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #0                                                              *");
Console.WriteLine("* Выполнил: Альборноз Гарсия Хосе Хулиан | ИИПб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)            *");
Console.WriteLine("* и печатает результат на экране.                                         *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* 10 / (2 + 3)                                                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
//Метод calculate находится в библиотеке Tyuiu.AlbornozJ.Sprint1.Task0.V0.Lib
//В классе DataService
Console.WriteLine(ds.Calculate());
Console.ReadLine();