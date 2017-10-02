using Entity.Models;
using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CariHesaplarList : Form, IGuncelleyebilme
    {
        public CariHesaplarList()
        {
            InitializeComponent();
        }

        private void btnNewCari_Click(object sender, EventArgs e)
        {
            new YeniCariHesapEkrani().Show();
        }

        private void CariHesaplarList_Load(object sender, EventArgs e)
        {
            Guncelleme();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       

        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)   // Seçili tüm satırları sildirmek istiyoruz
                                                                           //item : silinecek datagrid satırı
            {
                string unvan = item.Cells["Unvan"].Value.ToString();   // cells satırı temsil eder
                DialogResult cevap;
                cevap = MessageBox.Show(unvan.ToUpper() + "adlı satırı silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//uyarı mesajı verildi.
                if (cevap == DialogResult.Yes)
                {
                    Program.CariRep.Sil((CariHesapViewModel)item.DataBoundItem);
                }
            }
            Program.EkranGuncelle();
        }

        private void btnNewHareket_Click(object sender, EventArgs e)
        {


            YeniHesapHareketEkrani y = new YeniHesapHareketEkrani();
            if(dataGridView1.SelectedRows.Count != 0)  // Eğer seçili bir satır varsa
            y.SecilenCariOzet = (CariHesapViewModel)dataGridView1.SelectedRows[0].DataBoundItem;

            y.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // StartsWith("A")   -   a harfi ile başlıyor mu?
            // EndsWith("A")   -   a harfi ile bitiyor mu?
            // ContainsWith("A") - a harfi bulunduruyor mu ?

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.CariRep.CariHesapOzetListe().Where(x => x.Unvan.ToLower().Contains(txtSearch.Text.ToLower())).ToList();

            //List<CariHesapViewModel> araListe = new List<CariHesapViewModel>();

            //foreach (var item in Program.CariRep.CariHesapOzetListe())
            //{
            //    if (item.Unvan.ToLower().Contains(txtSearch.Text.ToLower()))
            //        araListe.Add(item);
            //    dataGridView1.DataSource = araListe;
            //}
            // ToLower metodu text ifadedeki büyük yada küçük harflerin tamamını küçük olarak alır. Arama yaparken Büyük küçük harf karmaşasının önüne geçmek için her iki datadan gelen textleri de küçük harfe çevirdik.Bu metodun zıttı ToUpper metodudur. 
            // Linq kullandığımız zaman gelen şeyin sonunda toList yada FirstOrDefault metodu kullanırız. FirstOrDefault ilk bulduğunu getirir. Fakat bize gelecek şey birden fazla sonuç içeriyorsa ToList metodunu kullanmalıyız. 
        }

        private void btnHareketler_Click(object sender, EventArgs e)
        {
            HesapHareketListe h = new HesapHareketListe();
            h.Show();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CariHesap secilen = Program.CariRep.Liste[e.RowIndex];

            HesapHareketListe hForm = new HesapHareketListe();
            hForm.SecilenCariHesap = secilen;
            hForm.Show();
        }


        public void Guncelleme()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.CariRep.CariHesapOzetListe();

            int yuzdeBirim = dataGridView1.Width / 100;
            //CariKod
            dataGridView1.Columns[0].Width = yuzdeBirim * 6;
            dataGridView1.Columns[0].HeaderText = "Kod";
            //Ünvan
            dataGridView1.Columns[1].Width = yuzdeBirim * 20;
            // Resim
            dataGridView1.Columns[2].Width = yuzdeBirim * 20;
            //GrupAdı
            dataGridView1.Columns[3].Width = yuzdeBirim * 15;
            //Cep tel
            dataGridView1.Columns[4].Width = yuzdeBirim * 15;
            //İlgili Kişi
            dataGridView1.Columns[5].Width = yuzdeBirim * 24;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Height = 35;
            }
        }

        private void CariHesaplarList_Resize(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}
