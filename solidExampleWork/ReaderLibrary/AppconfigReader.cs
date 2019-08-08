using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertHelperLibrary;
namespace ReaderLibrary

{
    class AppconfigReader :IReader
    {
        

        public T getValue<T>(String referances)
        {
            var value = ConfigurationManager.AppSettings.Get(referances);
            return Converter.convert<T>(value);
            
          
        }
    }
}
