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
            ReaderFactory readerFactory = new ReaderFactory();
            var reader = readerFactory.GetReader();
            return reader.ReadValue<T>(referances);
        }

    }
}
