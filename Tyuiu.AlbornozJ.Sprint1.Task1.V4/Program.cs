using Tyuiu.AlbornozJ.Sprint1.Task1.V4.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Альборноз Г. Х. Х. | ИИПб-25-1";
//Длинна строки 83 символов
Console.WriteLine("***********************************************************************************");
Console.WriteLine("* Спринт #1                                                                       *");
Console.WriteLine("* Тема: базовые навыки работы в C#                                                *");
Console.WriteLine("* Задание #1                                                                      *");
Console.WriteLine("* Вариант #4                                                                      *");
Console.WriteLine("* Выполнил: Альборноз Гарсия Хосе Хулиан | ИИПб-25-1                              *");
Console.WriteLine("***********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                        *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,         *");
Console.WriteLine("* вычисляет результат по формуле ( x + y ) / ( x * y ) и печатает его на экране.  *");
Console.WriteLine("*                                                                                 *");
Console.WriteLine("***********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
Console.WriteLine("***********************************************************************************");

double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

//Метод Calculate находится в библиотеке Tyuiu.AlbornozJ.Sprint1.Task1.V4.Lib
//в классе DataService
Console.WriteLine(ds.Calculate(x, y));
Console.ReadLine();