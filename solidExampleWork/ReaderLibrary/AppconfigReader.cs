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
    class AppconfigReader :BaseReader 
    {
         protected override object GetValue(String referances)
        {
            return ConfigurationManager.AppSettings.Get(referances);
         }
    }
}
