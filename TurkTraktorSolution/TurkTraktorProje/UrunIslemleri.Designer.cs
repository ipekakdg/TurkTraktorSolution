namespace TurkTraktorProje
{
    partial class UrunIslemleri
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
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtUrunStokMiktari = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxUrunlerKategoriId = new System.Windows.Forms.ComboBox();
            this.cbxUrunlerTedarikciId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunSatisFiyati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnGeriUrunler = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(273, 54);
            this.btnUrunGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(70, 23);
            this.btnUrunGuncelle.TabIndex = 11;
            this.btnUrunGuncelle.Text = "GÜNCELLE";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.ForeColor = System.Drawing.Color.Black;
            this.btnUrunEkle.Location = new System.Drawing.Point(273, 95);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(70, 22);
            this.btnUrunEkle.TabIndex = 10;
            this.btnUrunEkle.Text = "EKLE";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtUrunStokMiktari
            // 
            this.txtUrunStokMiktari.Location = new System.Drawing.Point(133, 56);
            this.txtUrunStokMiktari.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunStokMiktari.Name = "txtUrunStokMiktari";
            this.txtUrunStokMiktari.Size = new System.Drawing.Size(125, 20);
            this.txtUrunStokMiktari.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbxUrunlerKategoriId);
            this.groupBox1.Controls.Add(this.cbxUrunlerTedarikciId);
            this.groupBox1.Controls.Add(this.btnUrunGuncelle);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Controls.Add(this.txtUrunStokMiktari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUrunSatisFiyati);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(299, 110);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(369, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İslemleri";
            // 
            // cbxUrunlerKategoriId
            // 
            this.cbxUrunlerKategoriId.FormattingEnabled = true;
            this.cbxUrunlerKategoriId.Location = new System.Drawing.Point(133, 80);
            this.cbxUrunlerKategoriId.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUrunlerKategoriId.Name = "cbxUrunlerKategoriId";
            this.cbxUrunlerKategoriId.Size = new System.Drawing.Size(125, 21);
            this.cbxUrunlerKategoriId.TabIndex = 17;
            // 
            // cbxUrunlerTedarikciId
            // 
            this.cbxUrunlerTedarikciId.FormattingEnabled = true;
            this.cbxUrunlerTedarikciId.Location = new System.Drawing.Point(133, 133);
            this.cbxUrunlerTedarikciId.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUrunlerTedarikciId.Name = "cbxUrunlerTedarikciId";
            this.cbxUrunlerTedarikciId.Size = new System.Drawing.Size(125, 21);
            this.cbxUrunlerTedarikciId.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Stok Miktarı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satış Fiyatı : ";
            // 
            // txtUrunSatisFiyati
            // 
            this.txtUrunSatisFiyati.Location = new System.Drawing.Point(133, 108);
            this.txtUrunSatisFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunSatisFiyati.Name = "txtUrunSatisFiyati";
            this.txtUrunSatisFiyati.Size = new System.Drawing.Size(125, 20);
            this.txtUrunSatisFiyati.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Adı : ";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(133, 29);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(125, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı : ";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.White;
            this.btnUrunSil.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunSil.ForeColor = System.Drawing.Color.Black;
            this.btnUrunSil.Location = new System.Drawing.Point(273, 30);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(70, 23);
            this.btnUrunSil.TabIndex = 14;
            this.btnUrunSil.Text = "SİL";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnUrunSil);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(299, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(369, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Sil";
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.GridColor = System.Drawing.Color.Black;
            this.dgwUrunler.Location = new System.Drawing.Point(84, 367);
            this.dgwUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.RowHeadersWidth = 62;
            this.dgwUrunler.RowTemplate.Height = 28;
            this.dgwUrunler.Size = new System.Drawing.Size(584, 120);
            this.dgwUrunler.TabIndex = 11;
            this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btnUrunler_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TurkTraktorProje.Properties.Resources._2621727_810x458;
            this.pictureBox1.Location = new System.Drawing.Point(55, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 207);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TurkTraktorProje.Properties.Resources.TurkTraktorLogo;
            this.pictureBox2.Location = new System.Drawing.Point(241, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnGeriUrunler
            // 
            this.btnGeriUrunler.BackColor = System.Drawing.Color.Transparent;
            this.btnGeriUrunler.BackgroundImage = global::TurkTraktorProje.Properties.Resources.gerii;
            this.btnGeriUrunler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGeriUrunler.Location = new System.Drawing.Point(55, 29);
            this.btnGeriUrunler.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeriUrunler.Name = "btnGeriUrunler";
            this.btnGeriUrunler.Size = new System.Drawing.Size(49, 42);
            this.btnGeriUrunler.TabIndex = 18;
            this.btnGeriUrunler.UseVisualStyleBackColor = false;
            this.btnGeriUrunler.Click += new System.EventHandler(this.btnGeriUrunler_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "silmek istediğiniz satırın en soluna tıklayınız !";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ürün silmek için verilerin listelendiği ekranda";
            // 
            // UrunIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurkTraktorProje.Properties.Resources.giris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 510);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGeriUrunler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwUrunler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UrunIslemleri";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunStokMiktari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunSatisFiyati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnGeriUrunler;
        private System.Windows.Forms.ComboBox cbxUrunlerKategoriId;
        private System.Windows.Forms.ComboBox cbxUrunlerTedarikciId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}