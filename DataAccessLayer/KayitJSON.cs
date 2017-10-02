using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DataAccessLayer
{
   public class KayitJSON<T>
    {
        static JavaScriptSerializer tercuman = new JavaScriptSerializer(); // System.Web.Exstensions
        public static void Kaydet(List<T> kaydedilecekSey)
        {
            string dosyaYolu = typeof(T).Name + ".json";
            string jsonYazi = tercuman.Serialize(kaydedilecekSey);
            File.WriteAllText(dosyaYolu, jsonYazi);
        }

        public static List<T> Oku()
        {
            string dosyaYolu = typeof(T).Name + ".json";
            if (File.Exists(dosyaYolu))
            {
                string JsonOkunan = File.ReadAllText(dosyaYolu);
                return tercuman.Deserialize<List<T>>(JsonOkunan);

            }
            else return null;

        }

        public static void Kaydet(T kaydedilecekSey, string dosyaYolu)
        {

            string jsonYazi = tercuman.Serialize(kaydedilecekSey);
            File.WriteAllText(dosyaYolu, jsonYazi);
        }
        public static T YedekOku(string dosyaYolu)
        {

            string OkunanDosya = File.ReadAllText(dosyaYolu);
            return tercuman.Deserialize<T>(OkunanDosya);

        }

    }
    
}
