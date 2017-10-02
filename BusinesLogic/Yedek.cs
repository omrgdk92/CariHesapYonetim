using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.ViewModels;
using System.Web.Script.Serialization;
using System.IO;
using DataAccessLayer;

namespace BusinesLogic
{
   public class Yedek
    {
        public static string YedekAl(string dosyaYolu)
        {
            try
            {
                string bugun = DateTime.Today.ToShortDateString();
                dosyaYolu = dosyaYolu.Replace(".txt", bugun + ".txt");
                #region Versiyon1


                YedeklerViewModel y = new YedeklerViewModel();
                y.CariYedek = new CariRepository().Liste;
                y.GrupYedek = new GrupRepository().Liste;
                y.HesapYedek = new HareketRepository().Liste;

                Kayit<YedeklerViewModel>.Kaydet(y, dosyaYolu);
                #endregion

                #region Versiyon2
                /*
                List<object> yz = new List<object>();
                yz.Add(new CariRepository().Liste);
                yz.Add(new GrupRepository().Liste);
                yz.Add(new HareketRepository().Liste);
                Kayit<object>.Kaydet(y2,dosyaYolu);
               
                VERSİYON 2 */

                #endregion

                

                
                // .txt olarak kaydedeceği için, .txt'yı arayıp tarih. ile değiştirirsek
                
               

                return "Yedekleme başarılı.";
            }
            catch
            {
                return "Yedekleme sırasında bir hata oluştu !";
            }
        }

        public static string YedekYukle (string dosyaYolu, bool SilYedekle)
        {
            try
            {
                CariRepository cr =new CariRepository();
                HareketRepository hr = new HareketRepository();
                GrupRepository gr = new GrupRepository();

                if (SilYedekle)
                {
                    cr.SilYedekle();
                    gr.SilYedekle();
                    hr.SilYedekle();
                }
                var yedek = Kayit<YedeklerViewModel>.YedekOku(dosyaYolu);
                cr.YedekYukle(yedek.CariYedek);
                hr.YedekYukle(yedek.HesapYedek);
                gr.YedekYukle(yedek.GrupYedek);
                return "Yedekteki kayıtlar başarıyla aktarıldı.";
            }
            catch (Exception ex)
            {
                return "Yedek alınmaya çalışırken bir hata oluştu" + ex.Message;
            }
        }
    }
}
