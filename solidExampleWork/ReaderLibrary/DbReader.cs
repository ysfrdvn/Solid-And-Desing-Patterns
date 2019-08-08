using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertHelperLibrary;
namespace ReaderLibrary
{
    class DbReader : IReader
    {
        
        public T getValue<T>(String referances)
        {
            object value = null;    
            return Converter.convert<T>(value);
        }
    }
}
