
using Tyuiu.AlbornozJ.Sprint1.Task0.V17.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Альборноз Г. Х. Х. | ИИПб-25-1";
//Длинна строки 86 символов
Console.WriteLine("**************************************************************************************");
Console.WriteLine("* Спринт #1                                                                          *");
Console.WriteLine("* Тема: базовые навыки работы в C#                                                   *");
Console.WriteLine("* Задание #0                                                                         *");
Console.WriteLine("* Вариант #17                                                                        *");
Console.WriteLine("* Выполнил: Альборноз Гарсия Хосе Хулиан | ИИПб-25-1                                 *");
Console.WriteLine("**************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                           *");
Console.WriteLine("* Написать программу, которая вычисляет выражение (9 / 3) * 2 + (12 / 4) / 3 - 2     *");
Console.WriteLine("* и печатает результат на экране.                                                    *");
Console.WriteLine("*                                                                                    *");
Console.WriteLine("**************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
Console.WriteLine("**************************************************************************************");
Console.WriteLine("* (9 / 3) * 2 + (12 / 4) / 3 - 2                                                     *");
Console.WriteLine("**************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
Console.WriteLine("**************************************************************************************");
//Метод calculate находится в библиотеке Tyuiu.AlbornozJ.Sprint1.Task0.V17.Lib
//В классе DataService
Console.WriteLine(ds.Calculate());
Console.ReadLine();
