using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entity.Models;
using System.Collections;

namespace BusinesLogic
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public List<T> Liste = new List<T>();

        public void Ekle(T eklenecekSey)
        {
            if (eklenecekSey is CariHesap)
                (eklenecekSey as CariHesap).CariKod = Liste.Count + 1;
            else if (eklenecekSey is Grup)
                (eklenecekSey as Grup).GrupKodu = Liste.Count + 1;

            else if (eklenecekSey is HesapHareket)
                (eklenecekSey as HesapHareket).HesapHareketKod = Liste.Count + 1;
            Liste.Add(eklenecekSey);

            List<T> ekle = new List<T>();
            //DataAccessLayer.Kayit<T> kaydedilecek = new DataAccessLayer.Kayit<T>();

            //kaydedilecek.Kaydet(eklenecekSey);

            // DataAccessLayer'da tanımlanmış olan methodu burada çağırmak için ;  1-) BusinessLogic'te DataAccessLayer referansı ekledik. 2-) Daha sonra farklı bir project'te olduğu için öncelikle bir nesne oluşturuyoruz, daha sonra o objeden methoda ulaşıyoruz. 3-) Methodun içine parametreyi gönderiyoruz.

            Kayit<T>.Kaydet(Liste);  // Kayit metodunu static yaptıktan sonra burada usinge DataAccessLayer'i ekledik. Bu şekilde ulaşmak daha kısa.
        }

        public void Sil(T silinecekSey)
        {

            Liste.Remove(silinecekSey);
            Kayit<T>.Kaydet(Liste);

        }
        public void SilYedekle()
        {
            Liste.Clear();
            Kayit<T>.Kaydet(Liste);
        }
        public void YedekYukle(List<T> yedek)
        {
            Liste.AddRange(yedek);
            Kayit<T>.Kaydet(Liste);
        }
        private void Listele()
        {
            Liste = Kayit<T>.Oku();
        }

        public BaseRepository()  // Uygulama açılırken program.cs içerisinde new ile inşa edildiğinde tüm listeleri hazırlayıp getirir.
        {

            Listele();
            if (Liste == null) Liste = new List<T>();  //Nullreference hatası aldık ! Liste boş değer döndürdüğünden add'in içindeki liste referansı null geliyordu. Bu sebeple new list ürettik.
        }

       

    }
}
