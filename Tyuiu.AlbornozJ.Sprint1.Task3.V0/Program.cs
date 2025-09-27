
using Tyuiu.AlbornozJ.Sprint1.Task3.V0.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double a = 12;
double b = 17;
Console.WriteLine("Сторона A прамоугольника = " + a);
Console.WriteLine("Сторона B прамоугольника = " + b);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Площадь прямоугольника = " + ds.Calculate(a, b));

Console.ReadKey();