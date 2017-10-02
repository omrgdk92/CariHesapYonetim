namespace Presentation
{
    partial class GirisPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cariHesaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHesapListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniCariHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.günlükRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylıkRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TumHareketlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBorcToplam = new System.Windows.Forms.Label();
            this.lblAlacakToplam = new System.Windows.Forms.Label();
            this.lblNakiToplam = new System.Windows.Forms.Label();
            this.lblBorc = new System.Windows.Forms.Label();
            this.lblAlacak = new System.Windows.Forms.Label();
            this.lblNakit = new System.Windows.Forms.Label();
            this.btnGunlukMizan = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnYeniHesapHareketi = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCariHesaplar = new System.Windows.Forms.Button();
            this.btnAylikMizan = new System.Windows.Forms.Button();
            this.btnGruplar = new System.Windows.Forms.Button();
            this.btnYedekAl = new System.Windows.Forms.Button();
            this.btnYedekYukle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cariHesaplarToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cariHesaplarToolStripMenuItem
            // 
            this.cariHesaplarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHesapListesiToolStripMenuItem,
            this.yeniCariHesapToolStripMenuItem});
            this.cariHesaplarToolStripMenuItem.Name = "cariHesaplarToolStripMenuItem";
            this.cariHesaplarToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.cariHesaplarToolStripMenuItem.Text = "Cari Hesaplar";
            // 
            // cHesapListesiToolStripMenuItem
            // 
            this.cHesapListesiToolStripMenuItem.Name = "cHesapListesiToolStripMenuItem";
            this.cHesapListesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cHesapListesiToolStripMenuItem.Text = "C.Hesap Listesi";
            this.cHesapListesiToolStripMenuItem.Click += new System.EventHandler(this.cHesapListesiToolStripMenuItem_Click);
            // 
            // yeniCariHesapToolStripMenuItem
            // 
            this.yeniCariHesapToolStripMenuItem.Name = "yeniCariHesapToolStripMenuItem";
            this.yeniCariHesapToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.yeniCariHesapToolStripMenuItem.Text = "Yeni Cari Hesap";
            this.yeniCariHesapToolStripMenuItem.Click += new System.EventHandler(this.yeniCariHesapToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.günlükRaporToolStripMenuItem,
            this.aylıkRaporToolStripMenuItem,
            this.TumHareketlerToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // günlükRaporToolStripMenuItem
            // 
            this.günlükRaporToolStripMenuItem.Name = "günlükRaporToolStripMenuItem";
            this.günlükRaporToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.günlükRaporToolStripMenuItem.Text = "Günlük Rapor";
            // 
            // aylıkRaporToolStripMenuItem
            // 
            this.aylıkRaporToolStripMenuItem.Name = "aylıkRaporToolStripMenuItem";
            this.aylıkRaporToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.aylıkRaporToolStripMenuItem.Text = "Aylık Rapor";
            // 
            // TumHareketlerToolStripMenuItem
            // 
            this.TumHareketlerToolStripMenuItem.Name = "TumHareketlerToolStripMenuItem";
            this.TumHareketlerToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.TumHareketlerToolStripMenuItem.Text = "Tüm Hesap Hareketleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBorcToplam);
            this.groupBox1.Controls.Add(this.lblAlacakToplam);
            this.groupBox1.Controls.Add(this.lblNakiToplam);
            this.groupBox1.Controls.Add(this.lblBorc);
            this.groupBox1.Controls.Add(this.lblAlacak);
            this.groupBox1.Controls.Add(this.lblNakit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 385);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güncel Durum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "-----------------------------------------";
            // 
            // lblBorcToplam
            // 
            this.lblBorcToplam.AutoSize = true;
            this.lblBorcToplam.Location = new System.Drawing.Point(125, 114);
            this.lblBorcToplam.Name = "lblBorcToplam";
            this.lblBorcToplam.Size = new System.Drawing.Size(46, 17);
            this.lblBorcToplam.TabIndex = 1;
            this.lblBorcToplam.Text = "label6";
            // 
            // lblAlacakToplam
            // 
            this.lblAlacakToplam.AutoSize = true;
            this.lblAlacakToplam.Location = new System.Drawing.Point(125, 79);
            this.lblAlacakToplam.Name = "lblAlacakToplam";
            this.lblAlacakToplam.Size = new System.Drawing.Size(46, 17);
            this.lblAlacakToplam.TabIndex = 1;
            this.lblAlacakToplam.Text = "label5";
            // 
            // lblNakiToplam
            // 
            this.lblNakiToplam.AutoSize = true;
            this.lblNakiToplam.Location = new System.Drawing.Point(126, 174);
            this.lblNakiToplam.Name = "lblNakiToplam";
            this.lblNakiToplam.Size = new System.Drawing.Size(46, 17);
            this.lblNakiToplam.TabIndex = 1;
            this.lblNakiToplam.Text = "label4";
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Location = new System.Drawing.Point(19, 114);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(100, 17);
            this.lblBorc.TabIndex = 0;
            this.lblBorc.Text = "Borç Toplam : ";
            // 
            // lblAlacak
            // 
            this.lblAlacak.AutoSize = true;
            this.lblAlacak.Location = new System.Drawing.Point(6, 79);
            this.lblAlacak.Name = "lblAlacak";
            this.lblAlacak.Size = new System.Drawing.Size(113, 17);
            this.lblAlacak.TabIndex = 0;
            this.lblAlacak.Text = "Alacak Toplam : ";
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Location = new System.Drawing.Point(16, 174);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(103, 17);
            this.lblNakit.TabIndex = 0;
            this.lblNakit.Text = "Nakit Toplam : ";
            // 
            // btnGunlukMizan
            // 
            this.btnGunlukMizan.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnGunlukMizan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGunlukMizan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGunlukMizan.Location = new System.Drawing.Point(3, 157);
            this.btnGunlukMizan.Name = "btnGunlukMizan";
            this.btnGunlukMizan.Size = new System.Drawing.Size(168, 71);
            this.btnGunlukMizan.TabIndex = 2;
            this.btnGunlukMizan.Text = "Günlük Mizan";
            this.btnGunlukMizan.UseVisualStyleBackColor = true;
            this.btnGunlukMizan.Click += new System.EventHandler(this.btnGunlukMizan_Click);
            // 
            // btnForm
            // 
            this.btnForm.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnForm.Location = new System.Drawing.Point(177, 80);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(168, 71);
            this.btnForm.TabIndex = 2;
            this.btnForm.Text = "Mutabakat Formu";
            this.btnForm.UseVisualStyleBackColor = true;
            // 
            // btnYeniHesapHareketi
            // 
            this.btnYeniHesapHareketi.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnYeniHesapHareketi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniHesapHareketi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniHesapHareketi.Location = new System.Drawing.Point(3, 80);
            this.btnYeniHesapHareketi.Name = "btnYeniHesapHareketi";
            this.btnYeniHesapHareketi.Size = new System.Drawing.Size(168, 69);
            this.btnYeniHesapHareketi.TabIndex = 2;
            this.btnYeniHesapHareketi.Text = "Yeni Hesap Hareketi";
            this.btnYeniHesapHareketi.UseVisualStyleBackColor = true;
            this.btnYeniHesapHareketi.Click += new System.EventHandler(this.btnYeniHesapHareketi_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAdd.Location = new System.Drawing.Point(177, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 71);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Yeni Cari Hesap";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCariHesaplar);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnYeniHesapHareketi);
            this.flowLayoutPanel1.Controls.Add(this.btnForm);
            this.flowLayoutPanel1.Controls.Add(this.btnGunlukMizan);
            this.flowLayoutPanel1.Controls.Add(this.btnAylikMizan);
            this.flowLayoutPanel1.Controls.Add(this.btnGruplar);
            this.flowLayoutPanel1.Controls.Add(this.btnYedekAl);
            this.flowLayoutPanel1.Controls.Add(this.btnYedekYukle);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(417, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 385);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCariHesaplar
            // 
            this.btnCariHesaplar.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnCariHesaplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCariHesaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCariHesaplar.Location = new System.Drawing.Point(3, 3);
            this.btnCariHesaplar.Name = "btnCariHesaplar";
            this.btnCariHesaplar.Size = new System.Drawing.Size(168, 71);
            this.btnCariHesaplar.TabIndex = 2;
            this.btnCariHesaplar.Text = "Cari Hesaplar";
            this.btnCariHesaplar.UseVisualStyleBackColor = true;
            this.btnCariHesaplar.Click += new System.EventHandler(this.btnCariHesaplar_Click);
            // 
            // btnAylikMizan
            // 
            this.btnAylikMizan.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnAylikMizan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAylikMizan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAylikMizan.Location = new System.Drawing.Point(177, 157);
            this.btnAylikMizan.Name = "btnAylikMizan";
            this.btnAylikMizan.Size = new System.Drawing.Size(168, 71);
            this.btnAylikMizan.TabIndex = 3;
            this.btnAylikMizan.Text = "Aylık Mizan";
            this.btnAylikMizan.UseVisualStyleBackColor = true;
            this.btnAylikMizan.Click += new System.EventHandler(this.btnAylikMizan_Click);
            // 
            // btnGruplar
            // 
            this.btnGruplar.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnGruplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGruplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnGruplar.Location = new System.Drawing.Point(3, 234);
            this.btnGruplar.Name = "btnGruplar";
            this.btnGruplar.Size = new System.Drawing.Size(168, 71);
            this.btnGruplar.TabIndex = 4;
            this.btnGruplar.Text = "Gruplar";
            this.btnGruplar.UseVisualStyleBackColor = true;
            this.btnGruplar.Click += new System.EventHandler(this.btnGruplar_Click);
            // 
            // btnYedekAl
            // 
            this.btnYedekAl.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnYedekAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYedekAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnYedekAl.Location = new System.Drawing.Point(177, 234);
            this.btnYedekAl.Name = "btnYedekAl";
            this.btnYedekAl.Size = new System.Drawing.Size(168, 71);
            this.btnYedekAl.TabIndex = 5;
            this.btnYedekAl.Text = "Yedek Al";
            this.btnYedekAl.UseVisualStyleBackColor = true;
            this.btnYedekAl.Click += new System.EventHandler(this.btnYedekAl_Click);
            // 
            // btnYedekYukle
            // 
            this.btnYedekYukle.BackgroundImage = global::Presentation.Properties.Resources.expences_button_png_hi;
            this.btnYedekYukle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYedekYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnYedekYukle.Location = new System.Drawing.Point(3, 311);
            this.btnYedekYukle.Name = "btnYedekYukle";
            this.btnYedekYukle.Size = new System.Drawing.Size(168, 71);
            this.btnYedekYukle.TabIndex = 6;
            this.btnYedekYukle.Text = "Yedek Yükle";
            this.btnYedekYukle.UseVisualStyleBackColor = true;
            this.btnYedekYukle.Click += new System.EventHandler(this.btnYedekYukle_Click);
            // 
            // GirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 468);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GirisPaneli";
            this.Text = "Cari Hesap Yönetimi";
            this.Load += new System.EventHandler(this.GirisPaneli_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cariHesaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHesapListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem günlükRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylıkRaporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TumHareketlerToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label lblAlacak;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblBorcToplam;
        private System.Windows.Forms.Label lblAlacakToplam;
        private System.Windows.Forms.Label lblNakiToplam;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnYeniHesapHareketi;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnGunlukMizan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCariHesaplar;
        private System.Windows.Forms.Button btnAylikMizan;
        private System.Windows.Forms.Button btnGruplar;
        private System.Windows.Forms.Button btnYedekAl;
        private System.Windows.Forms.Button btnYedekYukle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem yeniCariHesapToolStripMenuItem;
    }
}

