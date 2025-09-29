using Tyuiu.MolkovIS.Sprint2.Task5.V4.Lib;

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

        if (x >= 1 & x <= 4)
        {
            res = dataService.FindCardSuit(x);
        }
        else
        {
            res = "Введено неверное значение";
        }


        


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Масть карты: {0}", res);

        Console.ReadKey();
    }
}