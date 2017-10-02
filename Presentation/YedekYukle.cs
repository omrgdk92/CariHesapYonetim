using BusinesLogic;
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
    public partial class YedekYukle : Form
    {
        public YedekYukle()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            string msj = radioSilYedekle.Checked ? "Yedekte olmayan tüm kayıtlarınız silinecek. Devam edilsin mi ?" : "Yedeklemek istediğiniz klasör mevcut kayıtlarınızın üstüne eklenecektir. Devam edilsin mi ?";
            DialogResult s = MessageBox.Show(msj, "Yedek Yükle",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(s== DialogResult.Yes)
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Title = "Yedeklenecek dosyayı seçiniz";
                o.Filter = "Yedek | *.txt";
                if(o.ShowDialog()== DialogResult.OK)
                {
                    MessageBox.Show(Yedek.YedekYukle(o.FileName, radioSilYedekle.Checked));
                }
                Program.EkranGuncelle();
            }
            
        }
        
    }
}
