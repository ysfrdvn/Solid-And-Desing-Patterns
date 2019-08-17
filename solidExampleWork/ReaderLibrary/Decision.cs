using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderLibrary
{
    class Decision // 2. olarak nerden okunacağının kontrolünü yapar
    {
       string source;
       
       public T getValue<T>(string referances)
        { 
            source= ConfigurationManager.AppSettings.Get("ValueSource"); // appconfig te valuesoure denen değerin içinde nereden okunacagı yazıyor onu okur Factoryye yollar
            ReaderFactory readerFactory = new ReaderFactory();
            return readerFactory.getValue<T>(source, referances);
        }
        
    }
}
