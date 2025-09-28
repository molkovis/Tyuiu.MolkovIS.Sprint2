using Tyuiu.MolkovIS.Sprint2.Task4.V17.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();

        Console.Write("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение Y: ");
        double y = Convert.ToDouble(Console.ReadLine());




        double res = dataService.Calculate(x,y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();
    }
}