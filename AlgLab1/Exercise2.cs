using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab1
{
    class Exercise2
    {
        public static int BinarySearch_V1(List<int> dataList, int num)
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
        public static int BinarySearch_V2(List<int> dataList, int num)
        {
            int maxIndex = dataList.Count - 1;
            int minIndex = 0;
            int mid=0;
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
            return (mid * - 1)-1;
        }
    }
}
