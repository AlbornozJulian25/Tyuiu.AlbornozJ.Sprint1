using Tyuiu.AlbornozJ.Sprint1.Task4.V15.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x, y;

Console.WriteLine("Введите значение X:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("******************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                 *");
Console.WriteLine("******************************");

Console.WriteLine("(x + y * y) / Math.Exp(2 - 4 * y) = " + ds.Calculate(x, y));
Console.ReadKey();
