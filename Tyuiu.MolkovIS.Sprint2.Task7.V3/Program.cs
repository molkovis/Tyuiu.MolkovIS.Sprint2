using Tyuiu.MolkovIS.Sprint2.Task7.V3.Lib;



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();

        Console.Write("Введите значение X"); double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение Y"); double y = Convert.ToDouble(Console.ReadLine());

        bool res = dataService.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);
        Console.ReadKey();


    }
}