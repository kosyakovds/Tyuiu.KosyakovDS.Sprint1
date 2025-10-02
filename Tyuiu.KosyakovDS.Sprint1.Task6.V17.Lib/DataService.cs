﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KosyakovDS.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            int left = 0;
            int right = value.Length - 1;

            while (left <= right)
            {
                if (value[left] != value[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}
