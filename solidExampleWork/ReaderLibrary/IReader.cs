using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderLibrary
{
     interface  IReader // abstract ve template
    {
         T getValue<T>(String referances);
    }
}
