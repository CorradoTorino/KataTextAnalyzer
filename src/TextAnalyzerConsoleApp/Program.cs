using System;
using TextSortFileService;
using TextStatisticsFileService;

namespace CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var textSort = new TextSorterFileService();
            var statistician = new TextStatisticianFileService();
        }
    }
}
