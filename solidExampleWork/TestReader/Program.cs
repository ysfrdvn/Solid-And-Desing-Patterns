using System;
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
            int retryCount = ReadValue.GetValue<int>("retryCount");
            Console.WriteLine(retryCount);
            int retryCount2 = ReadValue.GetValue<int>("retryCount");
            Console.WriteLine(retryCount2);
            String deneme = ReadValue.GetValue<String>("deneme");
            Console.WriteLine(deneme); 
            int retryCount3 = ReadValue.GetValue<int>("retryCount");
            Console.WriteLine(retryCount3);


        }
    }
}
