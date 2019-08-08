using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ReaderLibrary
{
     class ReaderFactory
    {
        
       public T getValue<T>(string sources, string referances)
        {

            if (sources == "Appconfig") { 
                return new AppconfigReader().getValue<T>(referances);
            }
            else if (sources == "Registry") { 
                return new RegistryReader().getValue<T>(referances);
            }
            else { 
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
                return (T)converter.ConvertFrom(null);
            }

        }


       
    }
}
