using Tyuiu.MolkovIS.Sprint2.Task6.V5.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();

        Console.Write("Введите порядковое число: ");
        int x = Convert.ToInt32(Console.ReadLine());

        string res = "";

        if (x >= 6 & x <= 14)
        {
            res = dataService.FindCardValue(x);
        }
        else
        {
            res = "Введено неверное значение";
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Достоинство карты: {0}", res);

        Console.ReadKey();
    }
}