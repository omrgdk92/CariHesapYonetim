using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace DataAccessLayer
{
    public class KayitXML<T>
    {

        public static void Kaydet(List<T> kaydedilecekSey)
        {
            XmlSerializer tercuman = new XmlSerializer(typeof(List<T>)); // System.Web.Exstensions

            string dosyaYolu = typeof(T).Name + ".xml";
            using (FileStream fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate))

                tercuman.Serialize(fs, kaydedilecekSey);

        }

        public static List<T> Oku()
        {
            XmlSerializer tercuman = new XmlSerializer(typeof(T)); // System.Web.Exstensions
            string dosyaYolu = typeof(T).Name + ".xml";
            if (File.Exists(dosyaYolu))
            {
                byte[] okunan = File.ReadAllBytes(dosyaYolu);
                object o = "";
                using (MemoryStream ms = new MemoryStream(okunan))
                    o = tercuman.Deserialize(ms);

                return (List<T>)o;
            }
            else return null;

        }

        public static void Kaydet(T kaydedilecekSey, string dosyaYolu)
        {
            XmlSerializer tercuman = new XmlSerializer(typeof(T)); // System.Web.Exstensions


            using (FileStream fs = new FileStream(dosyaYolu, FileMode.OpenOrCreate))

                tercuman.Serialize(fs, kaydedilecekSey);

        }
        public static T YedekOku(string dosyaYolu)
        {

            XmlSerializer tercuman = new XmlSerializer(typeof(T)); // System.Web.Exstensions

            byte[] okunan = File.ReadAllBytes(dosyaYolu);
            object o = "";
            using (MemoryStream ms = new MemoryStream(okunan))
                o = tercuman.Deserialize(ms);

            return (T)o;

        }
    }
}