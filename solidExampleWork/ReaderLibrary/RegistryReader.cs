using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using ConvertHelperLibrary;

namespace ReaderLibrary
{
    class RegistryReader : IReader
    {
       public T getValue<T>(String referances)
        {
            var value = Registry.Users.GetValue(referances);
            return Converter.convert<T>(value);
        
        }
    }
}
