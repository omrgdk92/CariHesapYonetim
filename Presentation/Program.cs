using BusinesLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Kefil Banka eklenecek YeniCariHesap ekranına.
namespace Presentation
{
    public static class Program
    {
        public static CariRepository CariRep = new CariRepository();
        public static GrupRepository GrupRep = new GrupRepository();
        public static HareketRepository HareketRep = new HareketRepository();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisPaneli());
        }

       public static void EkranGuncelle(string FormAdi)  // Kullanıcı hangi formadını girerse o formu güncelleyecek.
        {
            try
            {
                IGuncelleyebilme f = (IGuncelleyebilme)Application.OpenForms[FormAdi];
                if (f != null & f is IGuncelleyebilme) f.Guncelleme();  // form boş değilse ekranı güncelle boşsa zaten boş kalsın.
            }
            catch { }
        }

        public static void EkranGuncelle()
        {
            try
            {
                foreach (var item in Application.OpenForms)
                {
                    if(item is IGuncelleyebilme)
                    ((IGuncelleyebilme)item).Guncelleme();
                }
            }
            catch { }
        }
    }
}
