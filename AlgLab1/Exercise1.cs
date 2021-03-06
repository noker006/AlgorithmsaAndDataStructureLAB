﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab1
{
    public class Exercise1
    {
        public static int LinearSearch(List<int> dataList, int num)
        {
            for (int i = 0; i < dataList.Count; i++)
                if (dataList[i] == num)
                    return i;
            return -1;
        }
        public static int BinarySearch(List<int> dataList, int num)
        {
            int maxIndex = dataList.Count - 1;
            int minIndex = 0;
            int mid;
            while (minIndex <= maxIndex)
            {
                mid = (minIndex + maxIndex) / 2;
                if (num == dataList[mid])
                {
                    return ++mid;
                }
                else if (num < dataList[mid])
                {
                    maxIndex = mid - 1;
                }
                else
                {
                    minIndex = mid + 1;
                }
            }
            return -1;
        }
    }
}
