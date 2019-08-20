using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderLibrary
{
    public class ReadHelper //  1inci 
    {  public static T GetValue<T>(String referances)   // okuma için ilk çağırılan yer. Ben nerden okuyacağım seçimini bilmiyor. O yüzden Decisiona yollarız 
        {
            T value;
            ReaderFactory readerFactory = new ReaderFactory();
            value = readerFactory.getValue<T>(referances);
            return value;
        }

    }
}
