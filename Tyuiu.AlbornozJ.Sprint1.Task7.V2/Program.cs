using Tyuiu.AlbornozJ.Sprint1.Task7.V2.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x, y;

Console.WriteLine("Введите значение X (в радианах):");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение Y (в радианах):");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x, y));
Console.ReadKey();