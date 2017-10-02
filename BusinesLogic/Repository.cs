using DataAccessLayer;
using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    // Cari Repos ve GrupRepos ilgili modellerle ilgili işlemleri asıl yönetecek sınıflardır.      
    // Cari görüntüleme , ekleme, silme, arama, güncelleme gibi tüm işlemleri CariRepository sınıfı barındırır.
    // Grup ekleme, silme, güncelleme işlemlerini GrupRepository barındırır.
    // Bunların ortak yaptığı ekleme ve silme işlemleri Base Repo'dan miras alınır.
    // BaseRep'in hangi modeli ekleyip sileceğini Type kullanarak aktardık.
    // Bu uygulamada IRepository olmasaydı hiçbirşey değişmezdi. IRepository bizim için bir class özeti görevi görmekte.
    public class CariRepository : BaseRepository<CariHesap>
    {

        public void Duzenle(CariHesap duzenlenecekCari)
        {
            CariHesap orjinal = Liste.Find(x => x.CariKod == duzenlenecekCari.CariKod);

            int index = Liste.IndexOf(orjinal);
            Liste[index] = duzenlenecekCari;
            Kayit<CariHesap>.Kaydet(Liste);
        }
        public List<CariHesapViewModel> CariHesapOzetListe ()
        {
            List<CariHesapViewModel> OzetListe = new List<CariHesapViewModel>();
            foreach (var item in base.Liste)
            {
                CariHesapViewModel ozet = new CariHesapViewModel();
                ozet.CariKod = item.CariKod;
                ozet.Unvan = item.Unvan;
                ozet.GrupAdi = item.Grup == null ? null : item.Grup.GrupAdi;
                ozet.CepTel = item.Iletisim == null ? null : item.Iletisim.CepTel;
                ozet.Ilgili1 = item.Iletisim == null ? null : item.Iletisim.Ilgili1;
                ozet.FirmaLogo = item.FirmaLogo;
                OzetListe.Add(ozet);

                // item boş olmaz. Ama itemden gelen class null olabilir. Class null olduğunda o classtan bir veri çekmek istersek o zaman hata alırız. Bu hatanın önüne geçebilmek için kontrol mekanizması geliştirdik.
            }
            return OzetListe;
        }

        public void Sil(CariHesapViewModel silinecek)
        {
            // LINQ
            // CariHesap c = Liste.Where ( x => x.CariKod == silinecek.CariKod).FirstOrDefault();

            CariHesap c = new CariHesap();
            foreach (var item in Liste)
            {
                if (item.CariKod == silinecek.CariKod)
                    c = item;
            }

            if (c.CariKod != 0)
                base.Sil(c);

        }
    }
    public class GrupRepository : BaseRepository<Grup>
    {
        public void Duzenle(Grup duzenlenecekGrup)
        {
            Grup orjinal = Liste.Find(x => x.GrupKodu == duzenlenecekGrup.GrupKodu);
            
            int index = Liste.IndexOf(duzenlenecekGrup);
            Liste[index] = duzenlenecekGrup;
            Kayit<Grup>.Kaydet(Liste);
        }
    }
    //RepositoryIsmi : BaseRepository<ÇalışılacakModelClassı>
    public class HareketRepository : BaseRepository<HesapHareket>
    {
        public List<MizanViewModel> GunlukMizanGetir(int CariKod, DateTime gun)
        {
            List<MizanViewModel> mListe = new List<MizanViewModel>();
            var orjListe = Liste.Where(a => a.Carihesap.CariKod == CariKod & a.IslemTarihi.Date == gun.Date).ToList();
            foreach (var item in orjListe)
            {
                MizanViewModel m = new MizanViewModel();
                m.HesapKod = HesapKod.KasaHesabi;
                m.Tutar = item.Tutar;
                if (item.IslemTipi == IslemTipi.NakitTediye)
                    m.Tutar *= -1;
                mListe.Add(m);
            }

            decimal toplam = mListe.Sum(x => x.Tutar);
            mListe.Add(new MizanViewModel() { HesapKod = HesapKod.Toplam, Tutar = toplam });

            return mListe;

        }

         
        public void Duzenle(HesapHareket duzenlenecekHareket)
        {
            HesapHareket orjinal = Liste.Find(x => x.HesapHareketKod == duzenlenecekHareket.HesapHareketKod);

            int index = Liste.IndexOf(duzenlenecekHareket);
            Liste[index] = duzenlenecekHareket;
            Kayit<HesapHareket>.Kaydet(Liste);
        }
        public List<HesapHareketViewModel> CariHareketOzet(int cariKod)
        {
            //LINQ
      

        List<HesapHareketViewModel> ozetListe = new List<HesapHareketViewModel>().ToList();

            foreach (var item in HesapHareketOzetListe())
            {
    
                if (item.CariKod == cariKod) ozetListe.Add(item);
               
            }
            return ozetListe;

        }

        public List<HesapHareketViewModel> HesapHareketOzetListe()
        {
            List<HesapHareketViewModel> OzetListe = new List<HesapHareketViewModel>();
            foreach (var item in Liste)
            {
                HesapHareketViewModel ozet = new HesapHareketViewModel();
                ozet.CariKod = item.Carihesap == null ? 0 : item.Carihesap.CariKod;
                ozet.HesapHareketKod = item.HesapHareketKod;
                ozet.IslemTarihi = item.IslemTarihi;
                ozet.IslemTipi = item.IslemTipi;
                ozet.Tutar = item.Tutar;
                try
                {
                    ozet.Unvan = new CariRepository().Liste.Where(x => x.CariKod == ozet.CariKod).FirstOrDefault().Unvan;
                }
                catch { }
                OzetListe.Add(ozet);
            }

            return OzetListe;
        }

        public void Sil(HesapHareketViewModel silinecekSey)
        {
            /*
            HesapHareket h = Liste.Where(x => x.HesapHareketKod == silinecekSey.HesapHareketKod).FirstOrDefault();
            */
            HesapHareket h = new HesapHareket();
            foreach (var item in Liste)
                if (item.HesapHareketKod == silinecekSey.HesapHareketKod)
                    h = item;

            if (h.HesapHareketKod != 0)
                base.Sil(h);
        }

        public List<MizanViewModel> AylikMizanGetir(int CariKod,int ay, int yil)
        {
            List<MizanViewModel> mListe = new List<MizanViewModel>();
            var orjListe = Liste.Where(a => a.Carihesap.CariKod == CariKod & a.IslemTarihi.Month == ay  && a.IslemTarihi.Year == yil).ToList();
            foreach (var item in orjListe)
            {
                MizanViewModel m = new MizanViewModel();
                m.HesapKod = HesapKod.KasaHesabi;
                m.Tutar = item.Tutar;
                if (item.IslemTipi == IslemTipi.NakitTediye)
                    m.Tutar *= -1;
                mListe.Add(m);
            }

            decimal toplam = mListe.Sum(x => x.Tutar);
            mListe.Add(new MizanViewModel() { HesapKod = HesapKod.Toplam, Tutar = toplam });

            return mListe;
        }
    }
}


