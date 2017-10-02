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


namespace Presentation
{
    public partial class GrupListe : Form, IGuncelleyebilme
    {
        public GrupListe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Grup yeniGrup = new Grup();
            yeniGrup.GrupAdi = txtGrupAdi.Text;

            Program.GrupRep.Ekle(yeniGrup);
            ListeYenile();
            txtGrupAdi.Clear();
            // listBoxGrupList.Items.Add(yeniGrup);
            Program.EkranGuncelle();
           

        

        }

       
        void ListeYenile()
        {
            listBoxGrupList.DataSource = null;
            listBoxGrupList.DataSource = Program.GrupRep.Liste;
            listBoxGrupList.DisplayMember = "GrupAdi";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBoxGrupList.SelectedIndex == -1)  // listbox'tan hiçbir şey seçilmediyse
                MessageBox.Show("Silinecek birşey seçmediniz !","HATA !");
            else
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//uyarı mesajı verildi.
                if (cevap == DialogResult.Yes)
                {
                    Program.GrupRep.Sil((Grup)listBoxGrupList.SelectedItem);
                    ListeYenile();
                }

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        public void Guncelleme()
        {
            throw new NotImplementedException();
        }

        private void GrupListe_Load_1(object sender, EventArgs e)
        {
            ListeYenile();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (listBoxGrupList.SelectedIndex == -1)
                MessageBox.Show("Silinecek grup seçiniz");
            else
            {
                DialogResult secilenBtn = MessageBox.Show("Silmek istediğinize emin misiniz ?", "Emin misin?", MessageBoxButtons.OKCancel);
                if (secilenBtn == DialogResult.OK)
                {
                    Program.GrupRep.Sil((Grup)listBoxGrupList.SelectedItem);
                    ListeYenile();
                    Program.EkranGuncelle();
                }
            }
        }
       
        Grup duzenlenecekGrup { get; set; }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (btnDuzenle.Text == "Düzenle")
            {
                listBoxGrupList.Enabled = false;
                btnSil.Enabled = false;
                groupBox1.Text = "Grup Düzenle ";
                txtGrupAdi.Text = listBoxGrupList.Text;
                btnDuzenle.Text = "Kaydet";
                btnEkle.Enabled = false;
                btnDuzenle.Text = "Kaydet";
                duzenlenecekGrup = (Grup)listBoxGrupList.SelectedItem;
               

               
            }
            else
            {
                
                duzenlenecekGrup.GrupAdi = txtGrupAdi.Text;
                Program.GrupRep.Duzenle(duzenlenecekGrup);
                groupBox1.Text = "Yeni Grup Ekle";
                txtGrupAdi.Clear();                
                btnEkle.Enabled = true;
                btnDuzenle.Text = "Düzenle";
                ListeYenile();
                Program.EkranGuncelle();
                btnSil.Enabled = true;
                listBoxGrupList.Enabled = true;
            }
        }
    }
}
