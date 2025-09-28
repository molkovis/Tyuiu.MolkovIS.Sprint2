﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolkovIS.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = x + Math.Pow((x + 1) / (x - 1), x);
            }
            else
            {
                if (x == 0)
                {
                    y = 1 + Math.Cos(Math.Sqrt(x + 1));
                }
                else
                {
                    if (-16 < x && x < 2)
                    {
                        double pr1 = (5d) / (x * x);
                        double pr2 = 7d + pr1;
                        y = Math.Pow(pr2, x);
                    }
                    else
                    {
                        if (x < -16)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
            
    }
}
