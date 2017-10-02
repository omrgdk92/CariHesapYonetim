namespace Presentation
{
    partial class YeniHesapHareketEkrani
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
            this.lblCariHesap = new System.Windows.Forms.Label();
            this.comboCariHesap = new System.Windows.Forms.ComboBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.numericTutar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioNTediye = new System.Windows.Forms.RadioButton();
            this.radioNTahsilat = new System.Windows.Forms.RadioButton();
            this.lblIslemTrh = new System.Windows.Forms.Label();
            this.lblVadeTrh = new System.Windows.Forms.Label();
            this.dateTimeIslemTar = new System.Windows.Forms.DateTimePicker();
            this.dateTimeVadeTar = new System.Windows.Forms.DateTimePicker();
            this.lblVadeGunu = new System.Windows.Forms.Label();
            this.numerVadeGunu = new System.Windows.Forms.NumericUpDown();
            this.lblEvrNo = new System.Windows.Forms.Label();
            this.lblEvrTipi = new System.Windows.Forms.Label();
            this.lblEvrCinsi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerVadeGunu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCariHesap
            // 
            this.lblCariHesap.AutoSize = true;
            this.lblCariHesap.Location = new System.Drawing.Point(32, 44);
            this.lblCariHesap.Name = "lblCariHesap";
            this.lblCariHesap.Size = new System.Drawing.Size(68, 13);
            this.lblCariHesap.TabIndex = 0;
            this.lblCariHesap.Text = "Cari Hesap : ";
            // 
            // comboCariHesap
            // 
            this.comboCariHesap.FormattingEnabled = true;
            this.comboCariHesap.Location = new System.Drawing.Point(139, 41);
            this.comboCariHesap.Name = "comboCariHesap";
            this.comboCariHesap.Size = new System.Drawing.Size(200, 21);
            this.comboCariHesap.TabIndex = 1;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(59, 94);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(41, 13);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "Tutar : ";
            // 
            // numericTutar
            // 
            this.numericTutar.Location = new System.Drawing.Point(139, 92);
            this.numericTutar.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.numericTutar.Name = "numericTutar";
            this.numericTutar.Size = new System.Drawing.Size(137, 20);
            this.numericTutar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İşlem Tipi  : ";
            // 
            // radioNTediye
            // 
            this.radioNTediye.AutoSize = true;
            this.radioNTediye.Location = new System.Drawing.Point(139, 142);
            this.radioNTediye.Name = "radioNTediye";
            this.radioNTediye.Size = new System.Drawing.Size(85, 17);
            this.radioNTediye.TabIndex = 3;
            this.radioNTediye.TabStop = true;
            this.radioNTediye.Text = "Nakit Tediye";
            this.radioNTediye.UseVisualStyleBackColor = true;
            // 
            // radioNTahsilat
            // 
            this.radioNTahsilat.AutoSize = true;
            this.radioNTahsilat.Location = new System.Drawing.Point(245, 142);
            this.radioNTahsilat.Name = "radioNTahsilat";
            this.radioNTahsilat.Size = new System.Drawing.Size(90, 17);
            this.radioNTahsilat.TabIndex = 4;
            this.radioNTahsilat.TabStop = true;
            this.radioNTahsilat.Text = "Nakit Tahsilat";
            this.radioNTahsilat.UseVisualStyleBackColor = true;
            // 
            // lblIslemTrh
            // 
            this.lblIslemTrh.AutoSize = true;
            this.lblIslemTrh.Location = new System.Drawing.Point(31, 187);
            this.lblIslemTrh.Name = "lblIslemTrh";
            this.lblIslemTrh.Size = new System.Drawing.Size(69, 13);
            this.lblIslemTrh.TabIndex = 5;
            this.lblIslemTrh.Text = "İşlem Tarihi : ";
            // 
            // lblVadeTrh
            // 
            this.lblVadeTrh.AutoSize = true;
            this.lblVadeTrh.Location = new System.Drawing.Point(31, 230);
            this.lblVadeTrh.Name = "lblVadeTrh";
            this.lblVadeTrh.Size = new System.Drawing.Size(70, 13);
            this.lblVadeTrh.TabIndex = 5;
            this.lblVadeTrh.Text = "Vade Tarihi : ";
            // 
            // dateTimeIslemTar
            // 
            this.dateTimeIslemTar.Location = new System.Drawing.Point(139, 181);
            this.dateTimeIslemTar.Name = "dateTimeIslemTar";
            this.dateTimeIslemTar.Size = new System.Drawing.Size(200, 20);
            this.dateTimeIslemTar.TabIndex = 6;
            // 
            // dateTimeVadeTar
            // 
            this.dateTimeVadeTar.Location = new System.Drawing.Point(139, 224);
            this.dateTimeVadeTar.Name = "dateTimeVadeTar";
            this.dateTimeVadeTar.Size = new System.Drawing.Size(200, 20);
            this.dateTimeVadeTar.TabIndex = 7;
            // 
            // lblVadeGunu
            // 
            this.lblVadeGunu.AutoSize = true;
            this.lblVadeGunu.Location = new System.Drawing.Point(30, 280);
            this.lblVadeGunu.Name = "lblVadeGunu";
            this.lblVadeGunu.Size = new System.Drawing.Size(70, 13);
            this.lblVadeGunu.TabIndex = 5;
            this.lblVadeGunu.Text = "Vade Günü : ";
            // 
            // numerVadeGunu
            // 
            this.numerVadeGunu.Location = new System.Drawing.Point(139, 273);
            this.numerVadeGunu.Name = "numerVadeGunu";
            this.numerVadeGunu.Size = new System.Drawing.Size(85, 20);
            this.numerVadeGunu.TabIndex = 8;
            // 
            // lblEvrNo
            // 
            this.lblEvrNo.AutoSize = true;
            this.lblEvrNo.Location = new System.Drawing.Point(32, 325);
            this.lblEvrNo.Name = "lblEvrNo";
            this.lblEvrNo.Size = new System.Drawing.Size(58, 13);
            this.lblEvrNo.TabIndex = 5;
            this.lblEvrNo.Text = "Evrak No :";
            // 
            // lblEvrTipi
            // 
            this.lblEvrTipi.AutoSize = true;
            this.lblEvrTipi.Location = new System.Drawing.Point(32, 368);
            this.lblEvrTipi.Name = "lblEvrTipi";
            this.lblEvrTipi.Size = new System.Drawing.Size(61, 13);
            this.lblEvrTipi.TabIndex = 5;
            this.lblEvrTipi.Text = "Evrak Tipi :";
            // 
            // lblEvrCinsi
            // 
            this.lblEvrCinsi.AutoSize = true;
            this.lblEvrCinsi.Location = new System.Drawing.Point(31, 418);
            this.lblEvrCinsi.Name = "lblEvrCinsi";
            this.lblEvrCinsi.Size = new System.Drawing.Size(66, 13);
            this.lblEvrCinsi.TabIndex = 5;
            this.lblEvrCinsi.Text = "Evrak Cinsi :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(139, 415);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(336, 429);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 29);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // YeniHesapHareketEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 482);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.numerVadeGunu);
            this.Controls.Add(this.dateTimeVadeTar);
            this.Controls.Add(this.dateTimeIslemTar);
            this.Controls.Add(this.lblEvrCinsi);
            this.Controls.Add(this.lblVadeGunu);
            this.Controls.Add(this.lblEvrTipi);
            this.Controls.Add(this.lblVadeTrh);
            this.Controls.Add(this.lblEvrNo);
            this.Controls.Add(this.lblIslemTrh);
            this.Controls.Add(this.radioNTahsilat);
            this.Controls.Add(this.radioNTediye);
            this.Controls.Add(this.numericTutar);
            this.Controls.Add(this.comboCariHesap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblCariHesap);
            this.Name = "YeniHesapHareketEkrani";
            this.Text = "Yeni Hesap Hareketi Tanımla";
            this.Load += new System.EventHandler(this.YeniHesapHareketEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerVadeGunu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCariHesap;
        private System.Windows.Forms.ComboBox comboCariHesap;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.NumericUpDown numericTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioNTediye;
        private System.Windows.Forms.RadioButton radioNTahsilat;
        private System.Windows.Forms.Label lblIslemTrh;
        private System.Windows.Forms.Label lblVadeTrh;
        private System.Windows.Forms.DateTimePicker dateTimeIslemTar;
        private System.Windows.Forms.DateTimePicker dateTimeVadeTar;
        private System.Windows.Forms.Label lblVadeGunu;
        private System.Windows.Forms.NumericUpDown numerVadeGunu;
        private System.Windows.Forms.Label lblEvrNo;
        private System.Windows.Forms.Label lblEvrTipi;
        private System.Windows.Forms.Label lblEvrCinsi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnEkle;
    }
}