using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReaderLibrary;

namespace TestReader
{
    class Program
    {
        static void Main(string[] args)
        {
            int retryCount = ReadHelper.GetValue<int>("retryCount");
            Console.WriteLine(retryCount);
            int retryCount2 = ReadHelper.GetValue<int>("retryCount");
            Console.WriteLine(retryCount2);
            String deneme = ReadHelper.GetValue<String>("deneme");
            Console.WriteLine(deneme);
            String retryCount3 = ReadHelper.GetValue<String>("deneme");
            Console.WriteLine(retryCount3);
            String retryCount4 = ReadHelper.GetValue<String>("deneme");
            Console.WriteLine(retryCount4);


        }
    }
}
