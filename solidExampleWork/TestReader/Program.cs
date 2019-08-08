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
            int retryCount = ValueReader.GetValue<int>("retryCount");
            Console.WriteLine(retryCount);
            Console.ReadLine();
        }
    }
}
