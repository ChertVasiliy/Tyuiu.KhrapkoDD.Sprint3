﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapkoDD.Sprint3.Task6.V18.Lib
{
    public class DataService : ISprint3Task6V18
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x; //Диопозон
            int sum = 0;
            
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d < 10; d++)
                {
                    if (x % d == 0) 
                    { 
                        sum+= d; 
                    }
                }
            }
            return sum;
        }
    }
}