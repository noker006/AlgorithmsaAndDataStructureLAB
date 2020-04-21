using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgLab1
{
    class Exercise3
    {
        public static int betterLinearSearch(List<int> dataList, int length, int num)
        {
            for (int i = 0; i < length; i++)
                if (dataList[i] == num)
                    return i;
            return -1;
        }
        public static int sentinelLinearSearch(List<int> dataList, int length, int num)
        {
            int last = dataList[length - 1], i = 0;
            dataList[length - 1] = num;
            while (dataList[i] != num)
            {
                i++;
            }
            if (i < length || last == num)
            {
                return i;
            }
            return -1;
        }
        public static int recursiveLinearSearch(List<int> dataList, int length, int i, int num)
        {
            if (i > length)
            {
                return -1;
            }
            else if (i <= length && dataList[i] == num)
            {
                return i;
            }
            else if (i <= length && dataList[i] != num)
            {
                i = recursiveLinearSearch(dataList, length, i+1, num);
            }
            return i;
        }
        public static List<int> getList500()
        {
            List<int> reqList = new List<int>();
            for (int i = 1; i <= 500; i++)
            {
                reqList.Add(i);
            }
            return reqList;
        }
        public static List<int> getList1000()
        {
            List<int> reqList = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                reqList.Add(i);
            }
            return reqList;
        }
        public static List<int> getList5000()
        {
            List<int> reqList = new List<int>();
            for (int i = 1; i <= 5000; i++)
            {
                reqList.Add(i);
            }
            return reqList;
        }
    }
}
