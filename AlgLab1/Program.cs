using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace AlgLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            List<int> aList = new List<int>{ -7, 1, 3, 3, 4, 7, 11, 13 };
            List<int> bList = new List<int> { -7, 2, 2, 3, 4, 7, 8, 11, 13 };
            List<int> cList = new List<int> { -7 , 1 , 2 , 3 , 5 , 7 , 10 , 13 };
            List<int> List500 = Exercise3.getList500();
            List<int> List1000 = Exercise3.getList1000();
            List<int> List5000 = Exercise3.getList5000();

            Console.WriteLine("///////////Exercise 1///////////");
            stopwatch.Start();
            Console.WriteLine(Exercise1.LinearSearch(aList, 7));
            stopwatch.Stop();
            Console.WriteLine("A.time linear: " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise1.BinarySearch(bList, 8));
            stopwatch.Stop();
            Console.WriteLine("B.time bin: " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise1.BinarySearch(cList, 8));
            stopwatch.Stop();
            Console.WriteLine("C.time bin: " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();

            Console.WriteLine("///////////Exercise 2///////////");
            stopwatch.Start();
            Console.WriteLine("binV1 return: "+Exercise2.BinarySearch_V1(cList, 8));
            stopwatch.Stop();
            Console.WriteLine("time binV1: " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine("binV2 return: " + Exercise2.BinarySearch_V2(cList, 8));
            stopwatch.Stop();
            Console.WriteLine("time binV2: " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();

            Console.WriteLine("///////////Exercise 3///////////");
            stopwatch.Start();
            Console.WriteLine(Exercise3.betterLinearSearch(List500, List500.Count, 499));
            stopwatch.Stop();
            Console.WriteLine("BetterLinear 500 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise3.betterLinearSearch(List1000, List1000.Count, 999));
            stopwatch.Stop();
            Console.WriteLine("BetterLinear 1000 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise3.betterLinearSearch(List5000, List5000.Count, 4999));
            stopwatch.Stop();
            Console.WriteLine("BetterLinear 5000 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();

            stopwatch.Start();
            Console.WriteLine(Exercise3.sentinelLinearSearch(List500, List500.Count, 499));
            stopwatch.Stop();
            Console.WriteLine("SentinelLinear 500 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise3.sentinelLinearSearch(List1000, List1000.Count, 999));
            stopwatch.Stop();
            Console.WriteLine("SentinelLinear 1000 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise3.sentinelLinearSearch(List5000, List5000.Count, 4999));
            stopwatch.Stop();
            Console.WriteLine("SentinelLinear 5000 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();

            stopwatch.Start();
            Console.WriteLine(Exercise3.recursiveLinearSearch(List500, List500.Count, 0, 499));
            stopwatch.Stop();
            Console.WriteLine("recursLinear 500 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise3.recursiveLinearSearch(List1000, List1000.Count, 0, 999));
            stopwatch.Stop();
            Console.WriteLine("recursLinear 1000 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Console.WriteLine(Exercise3.recursiveLinearSearch(List5000, List5000.Count, 0, 4999));
            stopwatch.Stop();
            Console.WriteLine("recursLinear 5000 time " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Reset();
            Console.ReadKey();

        }
    }
}
