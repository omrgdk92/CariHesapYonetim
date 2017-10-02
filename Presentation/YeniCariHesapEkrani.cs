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
using System.IO;

namespace Presentation
{
    public partial class YeniCariHesapEkrani : Form, IGuncelleyebilme
    {
        public CariHesap SeciliCari { get; set; }

        private void YeniCariHesapEkrani_Load(object sender, EventArgs e)
        {
            Guncelleme();
            checkSahis_CheckedChanged(checkSahis, e);

            if (SeciliCari != null)
            DuzenlemeIcinFormuDoldur(); // Fill Form
        }

        private void DuzenlemeIcinFormuDoldur()
        {
            #region Genel
            txtUnvan.Text = SeciliCari.Unvan;
            comboGrup.SelectedItem = SeciliCari.Grup;

            try
            {
                byte[] resimDizi = SeciliCari.FirmaLogo;
                using (MemoryStream m = new MemoryStream(resimDizi))


                    pictureLogo.Image = Image.FromStream(m);
            }

            catch { }
            

            #endregion
            #region Ticari
            textBoxKDV.Text = SeciliCari.Ticari.KDVNo;
            textBoxVergiDairesi.Text = SeciliCari.Ticari.VergiDairesi;
            masktxtTcKimlik.Text = SeciliCari.Ticari.TCKimlikNo.ToString();
            masktxtVergiNo.Text = SeciliCari.Ticari.VergiNo.ToString();
            if (SeciliCari.Ticari.SahisFirmasi)
                checkSahis.Checked = true;

            if (SeciliCari.Ticari.YabanciUyruk)
                checkYabanci.Checked = true;
            #endregion
            #region Iletisim

            textBox3.Text = SeciliCari.Iletisim.Adres;
            maskedTextBox1.Text = SeciliCari.Iletisim.Tel;
            maskedTextBox2.Text = SeciliCari.Iletisim.CepTel;
            textBox4.Text = SeciliCari.Iletisim.EMail;
            textBox5.Text = SeciliCari.Iletisim.Web;
            textBox6.Text = SeciliCari.Iletisim.Ilgili1;
            textBox7.Text = SeciliCari.Iletisim.Ilgili2;
            #endregion
            #region Kefil 

            textBox9.Text = SeciliCari.Kefil.AdSoyad;
            textBox10.Text = SeciliCari.Kefil.Adres;
            maskedTextBox3.Text = SeciliCari.Kefil.CepTel;
            maskedTextBox4.Text = SeciliCari.Kefil.Tel;
            #endregion
            #region Banka

            textBox16.Text = SeciliCari.Banka.BankaAdi ;
            textBox13.Text = SeciliCari.Banka.HesapNo;
            maskedTextBox5.Text = SeciliCari.Banka.IBAN;
            textBox15.Text = SeciliCari.Banka.SubeAdi;
            textBox14.Text = SeciliCari.Banka.SubeKodu;
            #endregion

        }

        public void Guncelleme()
        {
            
            comboGrup.DataSource = null;
            comboGrup.DataSource = Program.GrupRep.Liste;
            comboGrup.DisplayMember = "GrupAdi";

        }
        public YeniCariHesapEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            CariHesap yeniHesap = new CariHesap();
            if (SeciliCari != null)
                yeniHesap.CariKod = SeciliCari.CariKod;

            Ticari tYeniHesap = new Ticari();


            #region Genel
            yeniHesap.Unvan = txtUnvan.Text;
            yeniHesap.Grup = (Grup)comboGrup.SelectedItem;
            if (!string.IsNullOrEmpty(pictureLogo.ImageLocation))
                yeniHesap.FirmaLogo = File.ReadAllBytes(pictureLogo.ImageLocation);
            else if (pictureLogo.Image != null)
            {
               
                using (MemoryStream m = new MemoryStream())
                {
                    pictureLogo.Image.Save(m, pictureLogo.Image.RawFormat);
                    yeniHesap.FirmaLogo = m.ToArray();
                }
            }
            
            #endregion

            #region Ticari
            tYeniHesap.SahisFirmasi = checkSahis.Checked;
            tYeniHesap.YabanciUyruk = checkYabanci.Checked;

            try
            {
                tYeniHesap.VergiNo = Convert.ToInt64(masktxtVergiNo.Text); // Bu mask'a girilen değeri çevir ve aktar demektir. TC'de ise farklı yöntem deneyeceğiz.
            }  // Bu kodu çalıştırmayı bir dene, burada hata çıkarsa catch'e geç.
            catch
            {
                // Burası boş bırakıldığından dolayı hata görmezden gelinecek.
            }
            long geciciTc;
            long.TryParse(masktxtTcKimlik.Text, out geciciTc);
            tYeniHesap.TCKimlikNo = geciciTc;
            tYeniHesap.VergiDairesi = textBoxVergiDairesi.Text;
            tYeniHesap.KDVNo = textBoxKDV.Text;


            yeniHesap.Ticari = tYeniHesap;

            #endregion

            #region Iletisim
            yeniHesap.Iletisim = new Iletisim();
            yeniHesap.Iletisim.Adres = textBox3.Text;
            yeniHesap.Iletisim.Tel = maskedTextBox1.Text;
            yeniHesap.Iletisim.CepTel = maskedTextBox2.Text;
            yeniHesap.Iletisim.EMail = textBox4.Text;
            yeniHesap.Iletisim.Web = textBox5.Text;
            yeniHesap.Iletisim.Ilgili1 = textBox6.Text;
            yeniHesap.Iletisim.Ilgili2 = textBox7.Text;
            #endregion

            #region Kefil 
            yeniHesap.Kefil = new Kefil();
            yeniHesap.Kefil.Adres = textBox10.Text;
            yeniHesap.Kefil.AdSoyad = textBox9.Text;
            yeniHesap.Kefil.CepTel = maskedTextBox3.Text;
            yeniHesap.Kefil.Tel = maskedTextBox4.Text;
            #endregion

            #region Banka
            yeniHesap.Banka = new Banka();
            yeniHesap.Banka.BankaAdi = textBox16.Text;
            yeniHesap.Banka.HesapNo = textBox13.Text;
            yeniHesap.Banka.IBAN = maskedTextBox5.Text;
            yeniHesap.Banka.SubeAdi = textBox15.Text;
            yeniHesap.Banka.SubeKodu = textBox14.Text;
            #endregion

            if (SeciliCari == null)
                Program.CariRep.Ekle(yeniHesap);
            else
                Program.CariRep.Duzenle(yeniHesap);
            Program.EkranGuncelle();

        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();  // Kaydet dialog menüsü getiriyoruz
            ofd.Title = "Firma Logosu Seç";
            ofd.Filter = "Resim ( *.png, *.jpg )  | *.png;*.jpg";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);  //OpenFile Dialog ilk geldiğinde nerden başlayacağını seçiyoruz.
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // pictureLogo.ImageLocation = ofd.FileName;  // pictureboxa resmi yazdırdık.
                pictureLogo.Image = Image.FromFile(ofd.FileName);
            }

        }

        private void checkSahis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSahis.Checked == true)
            {
                masktxtTcKimlik.Enabled = true;
                masktxtVergiNo.Enabled = false;
            }
            else
            {
                masktxtTcKimlik.Enabled = false;
                masktxtVergiNo.Enabled = true;
            }

        }

       

        
    }
}
