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
    public partial class HesapHareketListe : Form, IGuncelleyebilme
    {
        public CariHesap SecilenCariHesap { get; set; }
        public HesapHareketListe()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //dataGridView1.SelectionMode = SelectionMode.FullRowSelect;

            //Silmek istediğiniz hesap hareketini seçiniz.

            // .... İşletmeye ait ..... tutarındaki hesap hareketini silmek istediğinize emin misiniz?

            //Eğer evet derse ilgili rep nesnesinin Sil metodunu çağıralım.

            //seçili satırların sayısı 0 sa

            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Silinecek hesap hareketini seçiniz.");
            else
            {   //silinecek şeyler var
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    HesapHareketViewModel silinecek = (HesapHareketViewModel)item.DataBoundItem;
                    Program.HareketRep.Sil(silinecek);
                    
                }
                Program.EkranGuncelle();
            }
        }

        private void HesapHareketListe_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }
        void FillDataGrid()
        {
            List<HesapHareketViewModel> ozetListe;
            
            if (SecilenCariHesap == null)
                ozetListe = Program.HareketRep.HesapHareketOzetListe();
            else
                ozetListe = Program.HareketRep.CariHareketOzet(SecilenCariHesap.CariKod);
            dataGridView1.DataSource = ozetListe;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ozetListe;

            int yuzdeBirim = dataGridView1.Width / 100;
            //CariKod
            dataGridView1.Columns[0].Width = yuzdeBirim * 10;
            dataGridView1.Columns[0].HeaderText = "H.Hareket Kod";

            //Ünvan
            dataGridView1.Columns[1].Width = yuzdeBirim * 25;
            // Resim
            dataGridView1.Columns[2].Width = yuzdeBirim * 20;
            //GrupAdı
            dataGridView1.Columns[3].Width = yuzdeBirim * 15;
            //Cep tel
            dataGridView1.Columns[4].Width = yuzdeBirim * 10;
            //İlgili Kişi
            dataGridView1.Columns[5].Width = yuzdeBirim * 10;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 35;
            }
        }

        public void Guncelleme()
        {
            FillDataGrid();
        }

        private void btnYeniHesapHareketi_Click(object sender, EventArgs e)
        {
            YeniHesapHareketEkrani y = new YeniHesapHareketEkrani();
            if (dataGridView1.SelectedCells.Count != 0)
            {
                int SecilenCariKod = ((HesapHareketViewModel)dataGridView1.SelectedRows[0].DataBoundItem).CariKod;
                y.SecilenCariOzet = new CariHesapViewModel();
                y.SecilenCariOzet.CariKod = SecilenCariKod;
            }
                y.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cari Düzenle
            int c = ((HesapHareketViewModel) dataGridView1.SelectedRows[0].DataBoundItem).CariKod;
            YeniCariHesapEkrani y = new YeniCariHesapEkrani();
            y.SeciliCari = Program.CariRep.Liste.Where(x => x.CariKod == c).FirstOrDefault();
            y.Show();

        }
    }
}
