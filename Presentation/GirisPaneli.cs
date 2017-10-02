using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity.Models;
using System.Web.Script.Serialization;
using BusinesLogic;

namespace Presentation
{
    public partial class GirisPaneli : Form, IGuncelleyebilme
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }

        private void btnCariHesaplar_Click(object sender, EventArgs e)
        {
            new CariHesaplarList().Show();
        }

        private void gruplarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GrupListe g = new GrupListe();
            g.Show();
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {
            Guncelleme();
        }

        public void Guncelleme()
        {
            //  LINQ YÖNTEMİ
            //lblBorcToplam.Text = Program.HareketRep.Liste.Where(x => x.IslemTipi == Entity.Models.IslemTipi.NakitTediye).Sum(x => x.Tutar).ToString();
            //lblAlacakToplam.Text = Program.HareketRep.Liste.Where(x => x.IslemTipi == Entity.Models.IslemTipi.NakitTahsilat).Sum(x => x.Tutar).ToString();

            decimal tediyeToplam = 0;
            decimal tahsilatToplam = 0;
            foreach (var item in Program.HareketRep.Liste)
                if (item.IslemTipi == Entity.Models.IslemTipi.NakitTediye)
                    tediyeToplam += item.Tutar;
                else
                    tahsilatToplam += item.Tutar;

            lblAlacakToplam.Text = tahsilatToplam.ToString();
            lblBorcToplam.Text = tediyeToplam.ToString();

            decimal toplam = tahsilatToplam- tediyeToplam;
            
            lblNakiToplam.Text = toplam.ToString() ;
        }

        private void btnGruplar_Click(object sender, EventArgs e)
        {
            GrupListe g = new GrupListe();
            g.Show();
        }

        private void btnYeniHesapHareketi_Click(object sender, EventArgs e)
        {
            YeniHesapHareketEkrani y = new YeniHesapHareketEkrani();
            y.Show();
        }

        private void btnYedekAl_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog s = new SaveFileDialog())
            {
                s.Title = "Kaydedilecek Yeri Seçiniz";
                s.Filter = "Cari Hesap Yedeği | *.txt";
                if (s.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(Yedek.YedekAl(s.FileName));
                    //using kullandığımızda aşağıdakiler yapılır.
                    // s.Dispose();
                    // s = null;
                }
            }
        }

        private void btnYedekYukle_Click(object sender, EventArgs e)
        {
            new YedekYukle().Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            YeniCariHesapEkrani y = new YeniCariHesapEkrani();
            y.Show();
        }

        private void cHesapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCariHesaplar.PerformClick();  // btnCariHesaplar butonuyla aynı işi yap.
        }

        private void yeniCariHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
           
        }

        private void btnGunlukMizan_Click(object sender, EventArgs e)
        {
            new GunlukMizan().Show();
        }

        private void btnAylikMizan_Click(object sender, EventArgs e)
        {
            
            new AylikMizanEkrani().Show();


        }
    }
}
