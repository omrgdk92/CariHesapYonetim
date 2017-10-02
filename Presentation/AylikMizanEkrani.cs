using Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class AylikMizanEkrani : Form, IGuncelleyebilme
    {
        public AylikMizanEkrani()
        {
            InitializeComponent();
        }

        public void Guncelleme()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = Program.CariRep.Liste;
            comboBox1.DisplayMember = "Unvan";
            comboBox1.ValueMember = "CariKod";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.HareketRep.AylikMizanGetir((int)comboBox1.SelectedValue, comboBox2.SelectedIndex + 1, Convert.ToInt32(comboBox3.SelectedItem));
            string b1 = "gübre";
            string b2 = b1;
            MessageBox.Show(b1);
        }

        private void AylikMizanEkrani_Load(object sender, EventArgs e)
        {
            Type tanim = typeof(Aylar);
            FieldInfo[] fi = tanim.GetFields();
            foreach (var item in fi)
            {
                if (!item.Name.StartsWith("value"))
                    comboBox2.Items.Add(item.Name);

                for (int i = DateTime.Today.Year; i > DateTime.Today.Year - 50; i--)
                    comboBox3.Items.Add(i);
                Guncelleme();
            }


            string[] aylar = tanim.GetEnumNames();
            comboBox2.DataSource = aylar;
            Guncelleme();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Guncelleme();
        }
    }
}
