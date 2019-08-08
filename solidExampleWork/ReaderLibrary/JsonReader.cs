using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertHelperLibrary;
namespace ReaderLibrary
{
    public class JsonReader : IReader
    {
        public T getValue<T>(string referances)
        {

            return Converter.convert<T>(null);
        }
    }
}
