using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class YeniHesapHareketEkrani : Form, IGuncelleyebilme
    {
        public CariHesapViewModel SecilenCariOzet { get; set; }

        private void YeniHesapHareketEkrani_Load(object sender, EventArgs e)
        {
            Guncelleme();
            if (SecilenCariOzet != null)
            {
                //  LINQ KOD
                //  Program.CariRep.Liste.Where(x => x.CariKod == SecilenCariOzet.CariKod).FirstOrDefault();

                CariHesap gercek = new CariHesap();
                foreach (var item in Program.CariRep.Liste)
               
                    if (item.CariKod == SecilenCariOzet.CariKod)
                        gercek = item;
                comboCariHesap.SelectedItem = gercek;
                

            }
        }
        public YeniHesapHareketEkrani()
        {
            InitializeComponent();
        }

        public void Guncelleme()
        {

            comboCariHesap.DataSource = null;
            comboCariHesap.DataSource = Program.CariRep.Liste;
            comboCariHesap.DisplayMember = "Unvan";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            HesapHareket h = new HesapHareket();
            h.Carihesap = (CariHesap)comboCariHesap.SelectedItem;
            h.Evrak = new Evrak()
            {
                EvrakCinsi = comboBox1.Text,
                EvrakNo = textBox1.Text,
                EvrakTipi = comboBox2.Text


            };
            h.Tutar = numericTutar.Value;
            h.IslemTipi = radioNTahsilat.Checked ? IslemTipi.NakitTahsilat : IslemTipi.NakitTediye;
            h.IslemTarihi = dateTimeIslemTar.Value;
            h.VadeTarihi = dateTimeVadeTar.Value;
            h.VadeGunu = (int)numerVadeGunu.Value;
            Program.HareketRep.Ekle(h);

            Program.EkranGuncelle();
        }
        


    }
}
