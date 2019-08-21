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
    class RegistryReader : ReaderBase
    {
        protected override object GetValue(String referances)
        {
            return Registry.Users.GetValue(referances);
        
        }
    }
}
