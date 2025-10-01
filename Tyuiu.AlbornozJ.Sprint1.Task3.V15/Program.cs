using Tyuiu.AlbornozJ.Sprint1.Task3.V15.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите скорость первого автомобиля V1 (км/ч): ");
double v1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость второго автомобиля V2 (км/ч): ");
double v2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите начальное расстояние S (км): ");
double S = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите время движения T (часов): ");
double T = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***********************************");
Console.WriteLine("* РЕЗУЛЬТАТ: *");
Console.WriteLine("***********************************");

Console.WriteLine("Расстояние между автомобилями через " + T + " часов = " + ds.DistanceOverTime(v1, v2, S, T) + " км");

Console.ReadKey();
