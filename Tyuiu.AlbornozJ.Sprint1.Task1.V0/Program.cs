// See https://aka.ms/new-console-template for more information
using Tyuiu.AlbornozJ.Sprint1.Task1.V0.Lib;
//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//вычисляет результат по формуле x / ( y - 1 ) и печатает результат на экране.
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Hello, World!");
DataService ds  = new DataService();

Console.Title = "Спринт #1 | Выполнил: Альборноз Г. Х. Х. | ИИПб-25-1";
//Длинна строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #0                                                              *");
Console.WriteLine("* Выполнил: Альборноз Гарсия Хосе Хулиан | ИИПб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* вычисляет результат по формуле x / ( y - 1 ) и печатает его на экране.  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());
                                                        
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

//Метод Calculate находится в библиотеке Tyuiu.AlbornozJ.Sprint1.Task1.V0.Lib
//в классе DataService
Console.ReadLine();