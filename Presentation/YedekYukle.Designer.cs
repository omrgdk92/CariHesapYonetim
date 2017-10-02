namespace Presentation
{
    partial class YedekYukle
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
            this.components = new System.ComponentModel.Container();
            this.lblYuklemeTercih = new System.Windows.Forms.Label();
            this.radioSilYedekle = new System.Windows.Forms.RadioButton();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.radioKoruYedekle = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblYuklemeTercih
            // 
            this.lblYuklemeTercih.AutoSize = true;
            this.lblYuklemeTercih.Location = new System.Drawing.Point(27, 50);
            this.lblYuklemeTercih.Name = "lblYuklemeTercih";
            this.lblYuklemeTercih.Size = new System.Drawing.Size(144, 13);
            this.lblYuklemeTercih.TabIndex = 0;
            this.lblYuklemeTercih.Text = "Yükleme Tercihinizi Seçiniz : ";
            // 
            // radioSilYedekle
            // 
            this.radioSilYedekle.AutoSize = true;
            this.radioSilYedekle.Location = new System.Drawing.Point(188, 48);
            this.radioSilYedekle.Name = "radioSilYedekle";
            this.radioSilYedekle.Size = new System.Drawing.Size(191, 17);
            this.radioSilYedekle.TabIndex = 1;
            this.radioSilYedekle.TabStop = true;
            this.radioSilYedekle.Text = "Tüm Kayıtları Sil ve Yedekten Aktar";
            this.toolTip1.SetToolTip(this.radioSilYedekle, "Yedekte olan tüm kayıtları siler ve yedekten gelen dosyayı aktarır. ");
            this.radioSilYedekle.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(333, 153);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(90, 30);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // radioKoruYedekle
            // 
            this.radioKoruYedekle.AutoSize = true;
            this.radioKoruYedekle.Location = new System.Drawing.Point(188, 96);
            this.radioKoruYedekle.Name = "radioKoruYedekle";
            this.radioKoruYedekle.Size = new System.Drawing.Size(178, 17);
            this.radioKoruYedekle.TabIndex = 3;
            this.radioKoruYedekle.TabStop = true;
            this.radioKoruYedekle.Text = "Kayıtları Koru ve Yedekten Aktar";
            this.toolTip1.SetToolTip(this.radioKoruYedekle, "Var olan kayıtları silmeden yedekten gelen tüm bilgileri üzerine ekler.");
            this.radioKoruYedekle.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Yedekten Yükle";
            // 
            // YedekYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 200);
            this.Controls.Add(this.radioKoruYedekle);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.radioSilYedekle);
            this.Controls.Add(this.lblYuklemeTercih);
            this.Name = "YedekYukle";
            this.Text = "Yedek Yükle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYuklemeTercih;
        private System.Windows.Forms.RadioButton radioSilYedekle;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.RadioButton radioKoruYedekle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}