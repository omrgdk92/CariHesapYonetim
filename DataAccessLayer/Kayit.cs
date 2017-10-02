using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using DataAccessLayer;
using Entity.ViewModels;

namespace DataAccessLayer
{


    // Json, xml yada veritabanı; verilerimizi nerede saklıyorsak oraya veri ekleyip silmek güncellemek gibi işlemleri yaparken bu verilerle işlem yapacak olan, üretilmiş yada üretilecek nesnelerle iletişim kuracak olan kodlar burada olacak.

        // 1.) KayitJSON sınıfını ekledik
        // 2.) Kayit<T> sınıfındaki tüm metodları bu sınıfa aktardık.
        // 3.) Kayit<T> static değil , ilerde bu metodu farklı türden (Json,Xml vs) kullanmak istenirse kolay yazılabilmesi için yaptık. 
    public class Kayit<T> : KayitJSON<T> { }
    //public class Kayit<T> : KayitXML<T> { }

    }

