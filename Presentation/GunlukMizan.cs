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
    public partial class GunlukMizan : Form , IGuncelleyebilme
    {
        public GunlukMizan()
        {
            InitializeComponent();
        }

        public void Guncelleme()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Program.CariRep.Liste;
            comboBox1.DisplayMember = "Unvan";
            comboBox1.ValueMember = "CariKod";
            int CariKod =(int) comboBox1.SelectedValue;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.HareketRep.GunlukMizanGetir(CariKod, dateTimePicker1.Value);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Guncelleme();
        }

        private void GunlukMizan_Load(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}
